using Entities;
using WebFramework.Api;

namespace MyApi
{
    public class CarModelDto : BaseDto<CarModelDto, CarModel>
    {
        public string CarModelName { get; set; }
        public int CarId { get; set; }
    }

    public class CarModelSelectDto : BaseDto<CarModelSelectDto, CarModel>
    {
        public string CarModelName { get; set; }
        public string CarName { get; set; }
        public string CompanyName { get; set; }
    }
}
