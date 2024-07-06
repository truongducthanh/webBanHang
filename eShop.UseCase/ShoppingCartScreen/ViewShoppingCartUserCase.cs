using TruongDucThanh_K54.CoreBusiness.Model;
using TruongDucThanh_K54.UseCase.PluginInterface.UI;
using TruongDucThanh_K54.UseCase.ShoppingCartScreen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongDucThanh_K54.UseCase.ShoppingCartScreen
{
    public class ViewShoppingCartUserCase : IViewShoppingCartUserCase
    {
        //khai báo
        private readonly IShopingCart _shoppingCart;

        //khởi tạo
        public ViewShoppingCartUserCase(IShopingCart shopingCart)
        {
            this._shoppingCart = shopingCart;
        }
        public Task<Order> Execute()
        {
            return _shoppingCart.GetOrderAsync();
        }
    }
}
