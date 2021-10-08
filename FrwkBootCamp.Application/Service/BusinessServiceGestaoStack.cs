using System.Collections.Generic;
using AutoMapper;
using FrameBook.Business.DTO.DTO;
using FrameBook.Business.Interfaces;
using FrameBook.Domain.Interfaces.Services;
using FrameBook.Domain.Models;

namespace FrameBook.Business.Service
{
    public class BusinessServiceGestaoStack : IBusinessServiceGestaoStack
    {
        private readonly IServiceStack _serviceStack;
        private readonly IMapper _mapper;

        public BusinessServiceGestaoStack(IServiceStack serviceStack, IMapper mapper)
        {
            _serviceStack = serviceStack;
            _mapper = mapper;
        }

        public void Add(StackDTO obj)
        {
            var objStack = _mapper.Map<Stack>(obj);
            _serviceStack.Add(objStack);
        }

        public void Dispose()
        {
            _serviceStack.Dispose();
        }

        public IEnumerable<StackDTO> GetAll()
        {
            var objStack = _serviceStack.GetAll();
            return _mapper.Map<List<StackDTO>>(objStack);
        }

        public StackDTO GetById(int id)
        {
            var objStack = _serviceStack.GetById(id);
            if (objStack == null)
                return null;
            return _mapper.Map<StackDTO>(objStack);
        }

        public void Remove(StackDTO obj)
        {
            var objStack = _mapper.Map<Stack>(obj);
            _serviceStack.Remove(objStack);
        }

        public void Update(StackDTO obj)
        {
            var objStack = _mapper.Map<Stack>(obj);
            _serviceStack.Update(objStack);
        }
    }
}