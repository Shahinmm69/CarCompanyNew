using Entities;
using WebFramework.Api;

namespace MyApi
{
    public class CarImagesGalleryDto : BaseDto<CarImagesGalleryDto, CarImagesGallery>
    {
        public string CarImagesGalleryAddress { get; set; }
        public int ModelId { get; set; }
    }

    public class CarImagesGallerySelectDto : BaseDto<CarImagesGallerySelectDto, CarImagesGallery>
    {
        public string CarImagesGalleryAddress { get; set; }
        public string ModelName { get; set; }
        public string CarName { get; set; }
        public string CompanyName { get; set; }
    }
}

