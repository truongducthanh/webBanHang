using TruongDucThanh_K54.CoreBusiness.Model;

namespace TruongDucThanh_K54.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IPlaceOrderUserCase
    {
        Task<string> Execute(Order order);
    }
}