using TruongDucThanh_K54.CoreBusiness.Model;
using TruongDucThanh_K54.UseCase.PluginInterface.StateStore;
using TruongDucThanh_K54.UseCase.PluginInterface.UI;
using TruongDucThanh_K54.UseCase.ShoppingCartScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongDucThanh_K54.UseCase.ShoppingCartScreen
{

    public class DeleteProductUserCase : IDeleteProductUserCase
    {
        private readonly IShopingCart _shoppingcart;
        private readonly IShoppingCartStateStore _shoppingCartStateStore;
        public DeleteProductUserCase(IShopingCart shopingCart, IShoppingCartStateStore shoppingCartStateStore)
        {

            this._shoppingcart = shopingCart;
            this._shoppingCartStateStore = shoppingCartStateStore;
        }
        public async Task<Order> Execute(int productId)
        {
            var order = await this._shoppingcart.DeleteProductAsync(productId);
            this._shoppingCartStateStore.UpdateLineItemsCount();
            return order;
        }
    }
}
