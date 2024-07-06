using TruongDucThanh_K54.CoreBusiness.Model;

namespace TruongDucThanh_K54.UseCase.OrderConfirmScreen
{
    public interface IViewOrderConfrimUserCase
    {
        Order Execute(string uniqueId);
    }
}