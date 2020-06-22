using System;
using System.Collections.Generic;
using System.Text;

namespace Fortune
{
    public class FortuneTeller : IFortuneTeller
    {
        private IFortuneLoader _fortuneT;
        public FortuneTeller(IFortuneLoader fortuneTell)
        {
            _fortuneT = fortuneTell;
        }

        public void TellFortune()
        {
            string tellFortune = _fortuneT.LoadFortune();
            Console.WriteLine(tellFortune);
        }
    }
}
