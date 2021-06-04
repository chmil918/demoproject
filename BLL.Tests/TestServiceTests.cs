using AutoMapper;
using BLL.Automapper;
using BLL.DTO;
using BLL.Services.Abstract;
using BLL.Services.Implementation;
using DAL.UnitOfWork;
using Moq;
using NUnit.Framework;
using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.Tests
{
    public class TestServiceTests
    {
        [Test]
        public void Ctor_InputNull_ThrowArgumentNullException()
        {
            IUnitOfWork nullUnitOfWork = null;

            var mapper = new MapperConfiguration(cnf => cnf.AddProfile(new TestMapper()))
                .CreateMapper();

            Assert.Throws<ArgumentNullException>(() => new TestService(nullUnitOfWork, mapper));
        }

        [Test]
        public void Create_InvalidPolicemanDTO_ThrowValidationException()
        {
            // Arrange
            TestDTO test = new TestDTO
            {
                Id = 1,                
            };

            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var mapper = new MapperConfiguration(cnf => cnf.AddProfile(new TestMapper()))
                .CreateMapper();
            ITestService driverSevice = new TestService(mockUnitOfWork.Object, mapper);
            // Act
            // Assert
            Assert.Throws<ValidationException>(() => driverSevice.Create(test));
        }
    }
}