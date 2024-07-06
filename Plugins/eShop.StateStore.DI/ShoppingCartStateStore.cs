using TruongDucThanh_K54.UseCase.PluginInterface.StateStore;
using TruongDucThanh_K54.UseCase.PluginInterface.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongDucThanh_K54.StateStore.DI
{
    public class ShoppingCartStateStore : StateStoreBase,IShoppingCartStateStore
    {
        private readonly IShopingCart _shopingCart;
        public ShoppingCartStateStore(IShopingCart shopingCart)
        {
            this._shopingCart = shopingCart;
        }

        public async Task<int> GetItemsCount()
        {
            // throw new NotImplementedException();
            var order = await _shopingCart.GetOrderAsync();
            if (order != null && order.LineItems != null && order.LineItems.Count > 0)
                return order.LineItems.Count;
            return 0;
        }

        public void UpdateLineItemsCount()
        {
            //throw new NotImplementedException();
            base.BroadCastStateChange();
        }

        public void UpdateProductQuatity()
        {
            //throw new NotImplementedException();
            base.BroadCastStateChange();
        }
    }
}
