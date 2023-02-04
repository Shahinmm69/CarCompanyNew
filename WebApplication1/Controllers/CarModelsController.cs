using AutoMapper;
using Data.Contract;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CarModelsController : CrudController<CarModelDto, CarModelSelectDto, CarModel>
    {
        public CarModelsController(IRepository<CarModel> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
