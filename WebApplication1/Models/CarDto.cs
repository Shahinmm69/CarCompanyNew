using AutoMapper;
using Entities;
using WebFramework.Api;

namespace MyApi
{
    public class CarDto : BaseDto<CarDto, Car>
    {
        public string CarName { get; set; }
        public int CompanyId { get; set; }
    }

    public class CarSelectDto : BaseDto<CarSelectDto, Car>
    {
        public string CarName { get; set; }
        public string CompanyName { get; set; }
    }
}
