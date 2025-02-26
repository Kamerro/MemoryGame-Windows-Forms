using MemoryGame.Configuration;
using System.Drawing;

namespace MemoryGame.Services
{
    public class ImageService : IImageService
    {
        public Bitmap ReadReverse(Config config)
        {
            var backImage = Image.FromFile(config.ReverseLocalisation);
            return new Bitmap(backImage, new Size(config.ImageWidth, config.ImageHeight));
        }
    }
}
