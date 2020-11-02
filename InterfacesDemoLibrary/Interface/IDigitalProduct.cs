
namespace InterfacesDemoLibrary.Interface
{
    public interface IDigitalProduct : IProduct
    {
        int TotalDownloadsLeft { get; }
    }
}
