using AutoMapper;
using Data.Contract;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CarsController : CrudController<CarDto, CarSelectDto, Car>
    {
        public CarsController(IRepository<Car> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
