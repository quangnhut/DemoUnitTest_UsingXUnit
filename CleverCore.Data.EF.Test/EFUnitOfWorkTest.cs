using CleverCore.Data.Entities;
using CleverCore.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleverCore.Data.EF.Test
{
    public class EFUnitOfWorkTest
    {
        private readonly AppDbContext _context;

        public EFUnitOfWorkTest()
        {
            _context = ContextFactory.Create();
        }

        [Fact]
        public void Commit_Test()
        {
            var efRepository = new EfRepository<Function, string>(_context);
            var unitOfWork = new EFUnitOfWork(_context);

            var func = new Function()
            {
                Id = "USER1",
                Name = "test name",
                Status = Status.Active,
                SortOrder = 1
            };

            efRepository.Add(func);
            unitOfWork.Commit();

            var function = efRepository.FindAll().ToList();
            Assert.Single(function);
        }

    }
}
