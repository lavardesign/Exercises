using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Exercises.Classes.Chapter09;

namespace Exercises.Tests.Chapter09
{
    public class OrderTests
    {
        [Fact]
        public void CreateLineItemExceptionWrongId()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var item = new LineItem(-1, "Product 1", 2, 10, 50);
            });
        }
        [Fact]
        public void CreateLineItemExceptionEmptyProductName()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var item = new LineItem(1, "", 2, 10, 50);
            });
        }
        [Fact]
        public void CreateLineItemExceptionWrongQuantity()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var item = new LineItem(1, "Product 1", 0, 10, 50);
            });
        }
        [Fact]
        public void CreateLineItemExceptioWrongPrice()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var item = new LineItem(1, "Product 1", 2, 0, 50);
            });
        }
        [Fact]
        public void CreateLineItemExceptionWrongVat()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var item = new LineItem(1, "Product 1", 2, 10, -1);
            });
        }
        [Fact]
        public void CreateOrderExceptionWrongId()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var order = new Order(-1, "Customer 1", "Address 1");
            });
        }
        [Fact]
        public void CreateOrderExceptioEmptyCustomerName()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var order = new Order(1, "", "Address 1");
            });
        }
        [Fact]
        public void CreateOrderExceptionEmptyAddress()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var order = new Order(1, "Customer 1", "");
            });
        }
        [Fact]
        public void AddMethodInOrderFactoryThrowsExceptionForWrongCustomerData()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var orderFactory = new OrderFactory();
                orderFactory.Add("", "Address 1");
            });
        }
        [Fact]
        public void AddMethodInOrderFactoryThrowsExceptionForWrongAddressData()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var orderFactory = new OrderFactory();
                orderFactory.Add("Customer 1", "");
            });
        }
    }
}
