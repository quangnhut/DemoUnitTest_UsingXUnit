using CleverCore.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleverCore.Utilities.Test.Dtos
{
    public class GenericResultTest
    {
        [Fact]
        public void Constructor_CreateObjectNotNull()
        {
            var genericResult = new GenericResult();
            Assert.NotNull(genericResult);
        }

        [Fact]
        public void Constructor_Success()
        {
            var genericResult = new GenericResult(true);
            Assert.True(genericResult.Success);
        }

        [Fact]
        public void Constructor_SuccessAndData()
        {
            var genericResult = new GenericResult(true, new object());
            Assert.NotNull(genericResult.Data);
        }

        [Fact]
        public void Constructor_SuccessAndMessage()
        {
            var genericResult = new GenericResult(true, "test");
            Assert.Equal("test", genericResult.Message);
        }
    }
}
