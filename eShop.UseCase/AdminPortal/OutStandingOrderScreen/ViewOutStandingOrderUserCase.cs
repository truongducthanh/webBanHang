using TruongDucThanh_K54.CoreBusiness.Model;
using TruongDucThanh_K54.UseCase.PluginInterface.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongDucThanh_K54.UseCase.AdminPortal.OutStandingOrderScreen
{
    public class ViewOutStandingOrderUserCase : IViewOutStandingOrderUserCase
    {
        private readonly IOrderRespository _orderRespository;
        public ViewOutStandingOrderUserCase(IOrderRespository orderRespository)
        {
            this._orderRespository = orderRespository;
        }
        public IEnumerable<Order> Execute()
        {
            return _orderRespository.GetOutstandingOrders();
        }
    }
}
