using CleverCore.Application.Interfaces;
using CleverCore.Application.ViewModels.Product;
using CleverCore.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleverCore.WebApi.Test
{
    public class ProductControllerTest
    {
        [Fact]
        public void Get_ValidRequest_Test()
        {
            var mockProductCategory = new Mock<IProductCategoryService>();
            mockProductCategory.Setup(x => x.GetAll()).Returns(new List<ProductCategoryViewModel>() 
            {
                new ProductCategoryViewModel(){Id = 1, Name = "test 1"},
                new ProductCategoryViewModel(){Id = 2, Name = "test 2"}
            });
            var productController = new ProductController(mockProductCategory.Object);
            var result = productController.Get();
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(200, (result as OkObjectResult).StatusCode);
        }

        [Fact]
        public void Get_BadRequest_Test()
        {
            var mockProductCategory = new Mock<IProductCategoryService>();
            mockProductCategory.Setup(x => x.GetAll()).Throws<Exception>();

            var productController = new ProductController(mockProductCategory.Object);
            Assert.ThrowsAny<Exception>(() => { productController.Get(); });
        }
    }
}
