using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    internal class LifeDeclaration : PolicyDeclaration
    {
        private readonly List<LifeSpecialItem> _specialItems = new List<LifeSpecialItem>();
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var fireSpecialItem in _specialItems)
            {
                sb.AppendLine(fireSpecialItem.ToString());
            }
            return base.ToString()+sb.ToString();
        }

        public class LifePolicyDeclarationBuilder : PolicyDeclarationBuilder<LifePolicyDeclarationBuilder>
        {
            public LifePolicyDeclarationBuilder()
            {
                PolicyDeclaration = new LifeDeclaration();
            }

            internal void AddLifeSpecialItem(LifeSpecialItem lifeSpecialItem)
            {
                (PolicyDeclaration as LifeDeclaration)?._specialItems.Add(lifeSpecialItem);
            }
            protected override PolicyDeclaration PolicyDeclaration { get; }
        }
    }
}