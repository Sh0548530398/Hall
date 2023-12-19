using Hall.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Core.Repository
{
    public interface IOrderRepository
    {
        List<Orders> GetAllList();
        public Orders GetById(int id);
        public void PostOrders(Orders value);
        public bool PutOrders(int id, Orders value);
        public bool DeleatOrders(int id);
    }
}
