using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Policy
    {
        protected Policy()
        {
            Declarations = new List<IPolicyDeclaration>();
        }

        private List<IPolicyDeclaration> Declarations { get; }

        //public void AddDeclaration(IPolicyDeclaration policyDeclaration)
        //{
        //    Declarations.Add(policyDeclaration);
        //}

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var policyDeclaration in Declarations)
            {
                sb.AppendLine(policyDeclaration.ToString());
            }

            return sb.ToString();
        }


        public class PolicyBuilder
        {
            readonly Policy _policy = new Policy();

            public PolicyBuilder AddDeclaration(IPolicyDeclaration policyDeclaration)
            {
                _policy.Declarations.Add(policyDeclaration);
                return this;
            }

            public Policy Build()
            {
                return _policy;
            }
        }
    }
}