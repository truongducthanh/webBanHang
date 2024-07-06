using TruongDucThanh_K54.CoreBusiness.Model;

namespace TruongDucThanh_K54.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IUpdateQuantityUserCase
    {
        Task<Order> Execute(int productId, int quatity);
    }
}