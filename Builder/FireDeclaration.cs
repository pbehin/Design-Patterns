using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class FireDeclaration : PolicyDeclaration
    {
        private readonly List<FireSpecialItem> _specialItems = new List<FireSpecialItem>();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var fireSpecialItem in _specialItems)
            {
                sb.AppendLine(fireSpecialItem.ToString());
            }
            return base.ToString() + sb;
        }

        public class FirePolicyDeclarationBuilder : PolicyDeclarationBuilder<FirePolicyDeclarationBuilder>
        {
            public FirePolicyDeclarationBuilder()
            {
                PolicyDeclaration = new FireDeclaration();
            }

            public FirePolicyDeclarationBuilder AddFireSpecialItem(FireSpecialItem specialItem)
            {
                (PolicyDeclaration as FireDeclaration)?._specialItems.Add(specialItem);
                return this;
            }

            protected override PolicyDeclaration PolicyDeclaration { get; }
        }
    }
}