using EHealthCare_API.Controllers;
using EHealthCare_API.Data;
using EHealthCare_API.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NUnitTest
{
    public class Tests
    {
        private readonly  MedicineStoreDbContext _context;
        private readonly AdminsController admin;
        private readonly CartsController cart;
        private readonly CategoriesController category;
        public Tests()
        {
            _context = new MedicineStoreDbContext();
            admin = new AdminsController(_context);
            cart = new CartsController(_context);
            category = new CategoriesController(_context);
        }
        [SetUp]
        public void Setup()
        {
            //added comment
            //added second comment
            //added third commit
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void GetAdmins()
        {
            //Act
            Task<ActionResult<IEnumerable<Admin>>> result = (Task<ActionResult<IEnumerable<Admin>>>)admin.GetAdmins();

            //Assert
            Assert.IsNotNull(result);

        }
        [Test]
        public void GetCarts()
        {
            //Act
            Task<ActionResult<IEnumerable<Cart>>> result = (Task<ActionResult<IEnumerable<Cart>>>)cart.GetCarts();

            //Assert
            Assert.IsNotNull(result);

        }
        [Test]
        public void GetCartItem()
        {
            Task<ActionResult<Cart>> res = (Task<ActionResult<Cart>>)cart.GetCarts(2);
            Assert.IsNotNull(res);
           
        }
        [Test]
        public void CategoryExists()
        {
            var res = category.CategoriesExists(6);
            Assert.AreEqual(true, res);
        }
        [Test]
        public void DeleteCategory()
        {
            Task<IActionResult> res = (Task<IActionResult>)category.DeleteCategories(5);
            Assert.IsNotNull(res);

        }
        
    }
}