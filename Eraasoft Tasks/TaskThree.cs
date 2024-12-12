using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eraasoft_Tasks
{
    public enum SpaAccessType
    {
        NotAllowed = 1,
        OnceaWeek,
        OnceaMonth,
        Unlimited
    }

    public enum MembershipType
    {
        Normal = 200,
        Gold = 500,
        Premium = 2000,
    }


    public abstract class GymMembership
    {
        // Attributes and Properties

        protected string _Name;
        protected int    _DurationByMonths;
        protected MembershipType _Membership = MembershipType.Premium;

        public string Name { get { return _Name; } }
        public int DurationByDays { get { return _DurationByMonths; } }
        public MembershipType Membership { get { return _Membership; } }


        // Constructor 
        public GymMembership(string name, int durationbymonths) 
        {
            this._Name = name;
            this._DurationByMonths = durationbymonths;
        }


        // Methods

        public int CalculateFees()
        {
            return (int)_Membership * _DurationByMonths;
        }

        public abstract void Offers();
    }

    public class PremiumMembership : GymMembership
    {
        // Attributes and Properties

        public SpaAccessType SpaAccess { get; set; }
        public bool PersonalTrainerAvailability { get; set; }


        // Constructor 
        public PremiumMembership(string name, int durationbymonths, SpaAccessType access, bool personaltraineravailability) : base(name, durationbymonths)
        {
            _Membership = MembershipType.Premium;
            SpaAccess = access;
            PersonalTrainerAvailability = personaltraineravailability;
        }


        // Method
        public override void Offers()
        {
            Console.WriteLine("You have special offers, because you are premium");
        }
    
    }

    public class GoldMembership : GymMembership
    {
        // Attributes and Properties
        public SpaAccessType SpaAccess { get; set; }

        // Constructor 
        public GoldMembership(string name, int durationbymonths, SpaAccessType access) : base(name, durationbymonths)
        {
            _Membership = MembershipType.Gold;
            SpaAccess = access;
        }

        // Method
        public override void Offers()
        {
            Console.WriteLine("You have special offers, because you are Gold");
        }

    }

    public class NormalMembership : GymMembership
    {
        // Constructor 
        public NormalMembership(string name, int durationbymonths) : base(name, durationbymonths)
        {
            _Membership = MembershipType.Normal;
        }

        // Method
        public override void Offers()
        {
            Console.WriteLine("You have offers, because you are a client");
        }
    }

}
