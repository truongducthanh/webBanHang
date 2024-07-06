using TruongDucThanh_K54.CoreBusiness.Model;

namespace TruongDucThanh_K54.UseCase.AdminPortal.ProcessedOrderScreen
{
    public interface IViewPrcessedOrderUserCase
    {
        IEnumerable<Order> Execute();
    }
}