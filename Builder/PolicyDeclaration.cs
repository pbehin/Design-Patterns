namespace Builder
{
    public class PolicyDeclaration : IPolicyDeclaration
    {
        public string Name { get; private set; }

        public string Address { get; private set; }
        //public string PolicyDates { get; private set;  }
        //public string Description { get; private set; }
        //public string Coverages { get;  private set;}
        //public string CoverageLimits { get;  private set;}
        //public string Premiums { get;  private set;}
        //public string Forms { get;  private set;}
        //public string Schedules { get;  private set;}
        //public string RatingClassifications { get;  private set;}
        //public string SpecialProperty { get;  private set;}
        //public string RetroactiveDate { get;  private set;}

        public void AddAddress(string address)
        {
            Address = address;
        }

        public override string ToString()
        {
            return Name +" , "+ Address;
        }

        public abstract class PolicyDeclarationBuilder<T>
            where T : PolicyDeclarationBuilder<T>
        {
            protected abstract PolicyDeclaration PolicyDeclaration { get; }

            public PolicyDeclaration Build()
            {
                return PolicyDeclaration;
            }


            public T AddName(string decName)
            {
                PolicyDeclaration.Name = decName;
                return (T) this;
            }

            public T AddAddress(string address)
            {
                PolicyDeclaration.Address = address;
                return (T) this;
            }
        }
    }
}