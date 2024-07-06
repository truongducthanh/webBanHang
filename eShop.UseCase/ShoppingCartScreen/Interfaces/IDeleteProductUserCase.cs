using TruongDucThanh_K54.CoreBusiness.Model;

namespace TruongDucThanh_K54.UseCase.ShoppingCartScreen.Interfaces
{
    public interface IDeleteProductUserCase
    {
        Task<Order> Execute(int productId);
    }
}