using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleverCore.Data.EF.Test
{
    public class AppDbContextTest
    {
        [Fact]
        public void Constructor_AppDbContext_Success() {
            var context = ContextFactory.Create();
            Assert.True(context.Database.EnsureCreated());
        }



    }
}
