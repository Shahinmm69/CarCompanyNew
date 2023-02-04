using AutoMapper;
using Data.Contract;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using WebFramework.Api;

namespace MyApi.Controllers.v1
{
    public class CarImagesGalleryController : CrudController<CarImagesGalleryDto, CarImagesGallerySelectDto, CarImagesGallery>
    {
        public CarImagesGalleryController(IRepository<CarImagesGallery> repository, IMapper mapper)
            : base(repository,mapper)
        {
        }
    }
}
