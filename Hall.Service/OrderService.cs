using Hall.Core.Entities;
using Hall.Core.Repository;
using Hall.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Service
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Orders> GetAllList()
        {
            return _orderRepository.GetAllList();
        }
        public Orders GetById(int id)
        {
            return _orderRepository.GetById(id);

        }
        public void PostOrders(Orders value)
        {
            _orderRepository.PostOrders(value);
        }
        public bool PutOrders(int id, Orders value)
        {
            bool flag = _orderRepository.PutOrders(id, value);
            if (flag)
                return true;
            return false;
        }
        public bool DeleatOrders(int id)
        {
            bool flag = _orderRepository.DeleatOrders(id);
            if (flag)
                return true;
            return false;
        }
    }
}
