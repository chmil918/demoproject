using AutoMapper;
using BLL.DTO;
using BLL.Services.Abstract;
using DAL.Entities;
using DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BLL.Services.Implementation
{
    public class TestService : ITestService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TestService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException("UnitOfWork shouldn't be null");
            if (mapper == null)
                throw new ArgumentNullException("Mapper shouldn't be null");

            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Create(TestDTO model)
        {
            if (!Validate(model, out var results))
                throw new ValidationException(string.Join("\n", results.Select(r => r.ErrorMessage)));

            var test = _mapper.Map<Test>(model); 

            _unitOfWork.Tests.Create(test);
        }

        public void Delete(int id)
        {
            _unitOfWork.Tests.Delete(id);            
        }

        public TestDTO Get(int id)
        {
            var test = _unitOfWork.Tests.Get(id);

            var testDTO = _mapper.Map<TestDTO>(test);

            return testDTO;
        }

        public IEnumerable<TestDTO> GetAll()
        {
            var tests = _unitOfWork.Tests.GetAll();

            var testDTOs = _mapper.Map<IEnumerable<TestDTO>>(tests);

            return testDTOs;
        }

        public void Update(TestDTO model)
        {
            var test = _mapper.Map<Test>(model);

            _unitOfWork.Tests.Update(test);
        }

        private bool Validate(TestDTO obj, out ICollection<ValidationResult> results)
        {
            results = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, new System.ComponentModel.DataAnnotations.ValidationContext(obj), results, true);
        }
    }
}
