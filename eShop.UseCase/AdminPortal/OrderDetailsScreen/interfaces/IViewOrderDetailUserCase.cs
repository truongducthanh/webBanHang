using TruongDucThanh_K54.CoreBusiness.Model;

namespace TruongDucThanh_K54.UseCase.AdminPortal.OrderDetailsScreen.interfaces
{
    public interface IViewOrderDetailUserCase
    {
        Order Execute(int orderId);
    }
}