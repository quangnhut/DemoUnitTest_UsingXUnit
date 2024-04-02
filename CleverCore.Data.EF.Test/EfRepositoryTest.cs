using CleverCore.Data.Entities;
using CleverCore.Data.Enums;
using CleverCore.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleverCore.Data.EF.Test
{
    public class EfRepositoryTest
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;


        public EfRepositoryTest()
        {
            _context = ContextFactory.Create();
            _context.Database.EnsureCreated();
            _unitOfWork = new EFUnitOfWork(_context);
        }

        [Fact]
        public void Constructor_Create_Success()
        {
            EfRepository<Function, string> repository = new EfRepository<Function, string>(_context);
            Assert.NotNull(repository);
        }

        [Fact]
        public void Add_Test()
        {
            EfRepository<Function, string> efrepository = new EfRepository<Function, string>(_context);
            var func = new Function()
            {
                Id = "USER1",
                Name = "test name",
                Status = Status.Active,
                SortOrder = 1
            };

             efrepository.Add(func);
            _unitOfWork.Commit();

            Function function = efrepository.FindById("USER1");
            Assert.NotNull(function);
        }

        [Fact]
        public void FindAll_Test()
        {
            EfRepository<Function, string> efrepository = new EfRepository<Function, string>(_context);
            var func1 = new Function()
            {
                Id = "USER1",
                Name = "test name",
                Status = Status.Active,
                SortOrder = 1
            };
            var func2 = new Function()
            {
                Id = "USER2",
                Name = "test name 2",
                Status = Status.Active,
                SortOrder = 1
            };
            efrepository.Add(func1);
            efrepository.Add(func2);

            _unitOfWork.Commit();

            var function = efrepository.FindAll().ToList();
            Assert.Equal(2, function.Count());
        }

        [Fact]
        public void Update_Test()
        {
            EfRepository<Function, string> efrepository = new EfRepository<Function, string>(_context);
            var func = new Function()
            {
                Id = "USER1",
                Name = "test name",
                Status = Status.Active,
                SortOrder = 1
            };
            efrepository.Add(func);
            _unitOfWork.Commit();

            var function = efrepository.FindById("USER1");
            function.Name = "test name update";

            efrepository.Update(function);
            _unitOfWork.Commit();

            var finalFunction = efrepository.FindById("USER1");
            Assert.Equal("test name update", finalFunction.Name);
        }

        [Fact]
        public void Remove_Test()
        {
            EfRepository<Function, string> efrepository = new EfRepository<Function, string>(_context);
            var func = new Function()
            {
                Id = "USER1",
                Name = "test name",
                Status = Status.Active,
                SortOrder = 1
            };
            efrepository.Add(func);
            _unitOfWork.Commit();

            var function = efrepository.FindById("USER1");

            efrepository.Remove(function);
            _unitOfWork.Commit();

            var finalFunction = efrepository.FindById("USER1");
            Assert.Null(finalFunction);
        }

        [Fact]
        public void FindSingle_Test()
        {
            EfRepository<Function, string> efrepository = new EfRepository<Function, string>(_context);
            var func = new Function()
            {
                Id = "USER1",
                Name = "test name",
                Status = Status.Active,
                SortOrder = 1
            };
            efrepository.Add(func);
            _unitOfWork.Commit();

            var finalFunction = efrepository.FindSingle(f => f.Name == "test name");
            Assert.NotNull(finalFunction);
        }

    }
}
