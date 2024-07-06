using TruongDucThanh_K54.CoreBusiness.Model;

namespace TruongDucThanh_K54.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IViewShoppingCartUserCase
    {
        Task<Order> Execute();
    }
}