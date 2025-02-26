using MemoryGame.Configuration;
using System.Drawing;

namespace MemoryGame.Services
{
    public interface IImageService
    {
        Bitmap ReadReverse(Config config);
    }
}