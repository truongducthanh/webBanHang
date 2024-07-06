using TruongDucThanh_K54.CoreBusiness.Model;
using TruongDucThanh_K54.UseCase.AdminPortal.OrderDetailsScreen.interfaces;
using TruongDucThanh_K54.UseCase.PluginInterface.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongDucThanh_K54.UseCase.AdminPortal.OrderDetailsScreen  
{
    public class ViewOrderDetailUserCase : IViewOrderDetailUserCase
    {
        private readonly IOrderRespository _orderRespository;
        public ViewOrderDetailUserCase(IOrderRespository orderRespository)
        {
            this._orderRespository = orderRespository;
        }
        public Order Execute(int orderId)
        {

            return _orderRespository.GetOrder(orderId);
        }
    }
}
