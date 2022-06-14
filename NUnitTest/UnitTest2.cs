using EHealthCare_API.Controllers;
using EHealthCare_API.Data;
using EHealthCare_API.Models;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NUnitTest
{
    public class UnitTest2
    {
        private readonly MedicineStoreDbContext _context;
        private readonly ProductsController product;
        private readonly UsersController user;
        private readonly OrdersController order;
        public UnitTest2()
        {
            _context = new MedicineStoreDbContext();
            product = new ProductsController(_context);
            user = new UsersController(_context);
            order = new OrdersController(_context);
        }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void GetProducts()
        {
            //Act
            Task<ActionResult<IEnumerable<Product>>> result = (Task<ActionResult<IEnumerable<Product>>>)product.GetProducts();

            //Assert
            Assert.IsNotNull(result);

        }
        [Test]
        public void GetUsers()
        {
            //Act
            Task<ActionResult<IEnumerable<User>>> result = (Task<ActionResult<IEnumerable<User>>>)user.GetUsers();

            //Assert
            Assert.IsNotNull(result);

        }
        [Test]
        public void GetOrder()
        {
            Task<ActionResult<Order>> res = (Task<ActionResult<Order>>)order.GetOrders(3);
            Assert.IsNotNull(res);

        }
        
        [Test]
        public void DeleteProduct()
        {
            Task<IActionResult> res = (Task<IActionResult>)product.DeleteProducts(7);
            Assert.IsNotNull(res);

        }
        [Test]
        public void AddProduct()
        {
            Product p1 = new Product();
            p1.ProductName = "test name";
            p1.ProductPrice = 234;
            p1.ProductSeller = "test seller";
            p1.ProductDescription = "test decription";
            p1.ProductImage = "https://test/img.jpg";
            Task<ActionResult<Product>> res = (Task<ActionResult<Product>>)product.PostProducts(p1);
            Assert.IsNotNull(res);

        }
        [Test]
        public void EditProduct()
        {
            Product p1 = new Product();
            p1.ID = 7;
            p1.ProductName = "test name";
            p1.ProductPrice = 234;
            p1.ProductSeller = "test seller";
            p1.ProductDescription = "test decription";
            p1.ProductImage = "https://test/img.jpg";
            Task<IActionResult> res = (Task < IActionResult > )product.PutProducts(7,p1);
            Assert.IsNotNull(res);

        }


    }
}