using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pPatronesDiseño.Patrones.Comportamiento.Strategy
{
    class GymContext
    {
        private IMembershipStrategy _strategy;

        public GymContext()
        {
        }

        public GymContext(IMembershipStrategy strategy)
        {
            _strategy = strategy;
        }

        // here we can replace the current or default strategy
        // if we choose
        public void SetStrategy(IMembershipStrategy strategy)
        {
            _strategy = strategy;
        }

        // method to display the time they are allowed
        // at the gym depending on the type of membership they choose
        public void MemberAcceptableTime()
        {
            MessageBox.Show("Context: Member is Selecting " +
                "Their Membership Type");
            var customerMembership = _strategy
                .SelectMembership(new List<string>
                {
                "Anytime",
                "2 PM to 4 PM."
                });
            MessageBox.Show("This membership will " +
                "allow you to access the gym at " + customerMembership);
        }
    }

    public interface IMembershipStrategy
    {
        string SelectMembership(IList<string> timeData);
    }

    // strategy for selecting a peak membership
    class PeakStrategy : IMembershipStrategy
    {
        public string SelectMembership(IList<string> timeData)
        {
            // Peak Membership Implementation
            return timeData[0];
        }
    }

    // strategy for selecting an off-peak membership
    class OffPeakStrategy : IMembershipStrategy
    {
        public string SelectMembership(IList<string> timeData)
        {
            // Off Peak Membership Implementation
            return timeData[1];
        }
    }
}
