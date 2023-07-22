using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pPatronesDiseño.Patrones.Comportamiento.Observer
{
    /*
    //Abstract Subject
    public abstract class iPhoneStock
    {
        //list of customers waiting for iPhone 
        private List<iPhoneCustomer> _customers = new List<iPhoneCustomer>();

        //adding a new customer
        public void AddCustomer(iPhoneCustomer customer)
        {
            _customers.Add(customer);
        }

        //removing a customer
        public void RemoveCustomer(iPhoneCustomer customer)
        {
            _customers.Remove(customer);
        }

        //notifying customers whenever the subject's state changes
        public void Notify()
        {
            foreach (iPhoneCustomer iCustomer in _customers)
            {
                iCustomer.Update();
            }
        }
    }

    //Concrete Subject
    public class iPhone : iPhoneStock
    {
        public string Availability { get; set; } = string.Empty;
    }

    //Abstract Observer
    public interface iPhoneCustomer
    {
        public abstract void Update();
    }

    //Concrete Observer
    public class Customer : iPhoneCustomer
    {
        private string _name;
        private string _state = string.Empty;
        private iPhone _iPhone;

        public Customer(
            iPhone Iphone, string customer_name)
        {
            _iPhone = Iphone;
            _name = customer_name;
        }

        public void Update()
        {
            _state = _iPhone.Availability;
            MessageBox.Show($"Customer: {_name}\nState Changed " +
                $"to {_state} as iPhone is {_iPhone.Availability}");
        }
    }*/
}
