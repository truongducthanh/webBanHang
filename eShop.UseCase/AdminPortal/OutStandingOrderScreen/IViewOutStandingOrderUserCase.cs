using TruongDucThanh_K54.CoreBusiness.Model;

namespace TruongDucThanh_K54.UseCase.AdminPortal.OutStandingOrderScreen
{
    public interface IViewOutStandingOrderUserCase
    {
        IEnumerable<Order> Execute();
    }
}