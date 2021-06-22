using System;

namespace MyBanker
{
    //subclass to the superclass: Card, and interfaces: ICredit and IUseLimit
    public class Mastercard : Card, ICredit, IUseLimet
    {
    
    //Hvorfor ligger Random i din sub-klasse
        private Random random = new Random();
        //constructor
        public Mastercard(string name, int age) : base(name, age)
        {
            Prefix = random.Next(51,55);
            CreateCardNumber(14);

        }
        
        //implementet (not written) methode from the interface: ICredit
        public bool Credit()
        {
        //Hmmmm
            throw new NotImplementedException();
        }
        
        //implementet (not written) methode from the interface: IUseLimit
        public int SpendLimit()
        {
            throw new NotImplementedException();
        }
    }
}
