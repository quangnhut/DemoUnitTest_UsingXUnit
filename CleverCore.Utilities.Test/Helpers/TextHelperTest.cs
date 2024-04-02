using CleverCore.Utilities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleverCore.Utilities.Test.Helpers
{
    public class TextHelperTest
    {
        [Theory]
        [InlineData("Chuỗi để test")]
        [InlineData("Chuỗi, . test")]
        public void ToUnsignStringTest(string input)
        {
            var result = TextHelper.ToUnsignString(input);
            Assert.Equal("Chuoi-de-test", result);
        }

        [Theory]
        [InlineData(1234)]
        [InlineData(5645)]
        public void ToStringTest(decimal number)
        {
            var result = TextHelper.ToString(number);
            Assert.Equal("một nghìn hai trăm ba mươi bốn đồng chẵn", result);
        }



    }
}
