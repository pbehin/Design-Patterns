using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Policy policy;

            #region without Fluent 
            //policy = new FirePolicy()
            //var fireDeclaration = new FireDeclaration();
            //fireDeclaration.AddName("Fire Dec");
            //fireDeclaration.AddAddress("Fire Address");
            //fireDeclaration.AddFireSpecialItem(new FireSpecialItem("Fire Sp Itm"));

            //var lifeDeclaration = new LifeDeclaration();
            //lifeDeclaration.AddName("Life Dec");
            //lifeDeclaration.AddAddress("Life Address ");
            //lifeDeclaration.AddLifeSpecialItem(new LifeSpecialItem("Life Sp Itm"));

            //policy.AddDeclaration(lifeDeclaration);
            //policy.AddDeclaration(fireDeclaration);

            #endregion

            #region with Fluent

            var fireDeclarationBuilder = new FireDeclaration.FirePolicyDeclarationBuilder();
            fireDeclarationBuilder.AddName("Fire Dec")
                .AddAddress("Fire Address")
                .AddFireSpecialItem(new FireSpecialItem("Fire Sp Itm"))
                ;

            var lifeDeclarationBuilder = new LifeDeclaration.LifePolicyDeclarationBuilder();
            lifeDeclarationBuilder.AddName("Life Dec")
                .AddAddress("Life Address ")
                .AddLifeSpecialItem(new LifeSpecialItem("Life Sp Itm"));

            Policy.PolicyBuilder policyBuilder = new Policy.PolicyBuilder();
            policyBuilder.AddDeclaration(lifeDeclarationBuilder.Build())
                  .AddDeclaration(fireDeclarationBuilder.Build());

            policy = policyBuilder.Build();
            #endregion

            Console.WriteLine(policy);
        }
    }
}