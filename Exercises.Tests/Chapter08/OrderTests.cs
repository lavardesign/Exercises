﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises.Classes.Chapter08;

namespace Exercises.Tests.Chapter08
{
    public class OrderTests
    {
        [Fact]
        public void CanCreateLineItemInstance()
        {
            var item = new LineItem(1, "Product 1", 2, 10, 50);

            Assert.NotNull(item);
            Assert.Equal(1, item.Id);
            Assert.Equal("Product 1", item.Product);
            Assert.Equal(2, item.Quantity);
            Assert.Equal(10, item.Price);
            Assert.Equal(10, item.VatCost);
            Assert.Equal(30, item.Total);
        }
        [Fact]
        public void CanCreateOrderInstance()
        {
            var order = new Order(1, "Customer 1", "Address 1");

            Assert.NotNull(order);
            Assert.Equal(1, order.Id);
            Assert.Equal("Customer 1", order.Customer);
            Assert.Equal("Address 1", order.Address);
            Assert.Empty(order.Items);
        }
        [Fact]
        public void CanAddLineItemToOrderInstance()
        {
            var order = new Order(1, "Customer 1", "Address 1");
            order.AddLineItem("Product 1", 2, 10, 50);
            var addedItem = order.Items.Find(i => i.Id.Equals(1));

            Assert.NotNull(order);
            Assert.Equal(1, order.Id);
            Assert.Equal("Customer 1", order.Customer);
            Assert.Equal("Address 1", order.Address);
            Assert.NotEmpty(order.Items);

            Assert.Equal(1, addedItem.Id);
            Assert.Equal("Product 1", addedItem.Product);
            Assert.Equal(2, addedItem.Quantity);
            Assert.Equal(10, addedItem.Price);
            Assert.Equal(10, addedItem.VatCost);
            Assert.Equal(30, addedItem.Total);
        }
        [Fact]
        public void CanGetTotalAndVatInOrderInstance()
        {
            var order = new Order(1, "Customer 1", "Address 1");

            order.AddLineItem("Product 1", 2, 10, 50);
            order.AddLineItem("Product 2", 1, 100, 0.5);
            order.GetOrderTotalAndVat(out double total, out double vat);

            Assert.NotNull(order);
            Assert.Equal(60, vat);
            Assert.Equal(180, total);
        }
        [Fact]
        public void CanCreateOrderFactoryInstance()
        {
            var orders = new OrderFactory();

            Assert.NotNull(orders);
        }
        [Fact]
        public void CanAddOrderWithFactoryInstance()
        {
            var orders = new OrderFactory();

            orders.Add("Customer 1", "Address 1");

            Assert.NotEmpty(orders.Get());
        }
    }
}
