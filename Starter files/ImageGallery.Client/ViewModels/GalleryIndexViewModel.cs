using ImageGallery.Model;

namespace ImageGallery.Client.ViewModels;

public class GalleryIndexViewModel
{
    public GalleryIndexViewModel(IEnumerable<Image> images)
    {
        Images = images;
    }

    public IEnumerable<Image> Images { get; }
        = new List<Image>();
}