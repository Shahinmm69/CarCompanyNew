using AutoMapper;
using Data.Contract;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CompaniesController : CrudController<CompanyDto, CompanySelectDto, Company>
    {
        public CompaniesController(IRepository<Company> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
