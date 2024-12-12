using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eraasoft_Tasks
{
    public enum OrderStatus
    {
        InStore,
        InWay,
        Arrived,
    }

    public enum Address
    {
        Cairo = 2,
        Alex = 4,
        Others = 8
    }


    public class CustomerOrder
    {
        // Attributes and Properties

        protected int _ID;
        protected string _Customer;
        protected DateTime _OrderDate;

        public int ID { get { return _ID; } }
        public string Customer { get { return _Customer; } }
        public DateTime OrderDate { get { return _OrderDate; } }


        // Constructor 
        public CustomerOrder(int id, string customer, DateTime orderdate)
            {
                this._ID = id;
                this._Customer = customer;
                this._OrderDate = orderdate;
            }
    }

    public class OnlineOrder : CustomerOrder
    {
        // Attributes and Properties

        protected string _TrackingNumber;
        protected Address _DeliveryAddress;
        protected OrderStatus _Status;

        public string TrackingNumber { get { return _TrackingNumber; } }
        public Address DeliveryAddress { get { return _DeliveryAddress; } }


        // Constructor 
        public OnlineOrder(int id, string customer, DateTime orderdate, string trackingnumber, Address deliveryaddress) : base(id, customer, orderdate)
        {
            this._TrackingNumber = trackingnumber;
            this._DeliveryAddress = deliveryaddress;
            this._Status = OrderStatus.InStore;
        }


        // Methods

        public void ChangeTrackingStatus(OrderStatus newstatus)
        {
            if (_Status == OrderStatus.Arrived)
                return;

            _Status = newstatus;
        }

        public DateTime CalcDeliveryTime()
        {
            DateTime deliverydate = _OrderDate;

            return deliverydate.AddDays((int)_DeliveryAddress);
        }

        public void PrintInformations()
        {
            Console.WriteLine("ID: {0}", _ID);
            Console.WriteLine("Tracking Number: {0}", _TrackingNumber);
            Console.WriteLine("Customer Name: {0}",_Customer);
            Console.WriteLine("Order Date: {0}", _OrderDate);
            Console.WriteLine("Delivery Date: {0}", CalcDeliveryTime());
            Console.WriteLine("Delivery Address: {0}", _DeliveryAddress);
        }

    }

}
