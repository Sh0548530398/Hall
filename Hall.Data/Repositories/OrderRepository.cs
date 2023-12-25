using Hall.Core;
using Hall.Core.Entities;
using Hall.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Data.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private static int i = 0;
        private readonly DataContext _context;
        public OrderRepository(DataContext context)
        {
            _context = context;
        }
        public List<Orders> GetAllList()
        {
            return _context.OrdersList.ToList();
        }
        public Orders GetById(int id)
        {
            return _context.OrdersList.ToList().Find(c => c.Id == id);
        }
        public void PostOrders(Orders value)
        {
            _context.OrdersList.Add(new Orders(i++, value.Name, value.Descreption, value.Date, value.Price));
        }
        public bool PutOrders(int id, Orders value)
        {
            var exist = _context.OrdersList.ToList().Find(c => c.Id == id);
            if (exist == null)
            {
                return false;
            }
            exist.Name = value.Name;
            exist.Descreption = value.Descreption;
            exist.Date = value.Date;
            exist.Price = value.Price;
            return true;
        }
        public bool DeleatOrders(int id)
        {
            var delete = _context.OrdersList.ToList().Find(c => c.Id == id);
            if (delete == null)
            {
                return false;
            }
            _context.OrdersList.Remove(delete);
            return true;
        }
    }
}
