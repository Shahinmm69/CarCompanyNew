using AutoMapper;
using Data.Contract;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CosthistoriesController : CrudController<CostHistoryDto, CostHistorySelectDto, CostHistory>
    {
        public CosthistoriesController(IRepository<CostHistory> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
