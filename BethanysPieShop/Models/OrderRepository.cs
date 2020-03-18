﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class OrderRepository: IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.Orders.Add(order);

            var shoopingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoopingCartItem in shoopingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoopingCartItem.Amount,
                    PieId = shoopingCartItem.Pie.PieId,
                    OrderId = order.OrderId,
                    Price = shoopingCartItem.Pie.Price
                };

                _appDbContext.OrderDetails.Add(orderDetail);
            }
            _appDbContext.SaveChanges();
    }
    }
}
