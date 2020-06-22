using System;
using System.Collections.Generic;
using System.Text;

namespace Fortune
{
    public class FortuneFacade : IFortuneFacade
    {
        private IFortuneTeller _fortuneT;
        private IFortuneGetter _fortuneG;
        
        public FortuneFacade(IFortuneGetter fortuneG)
        {
            _fortuneG = fortuneG;
        }
        public string FortuneGet()
        {
            return _fortuneG.GetFortune();
        }

        public FortuneFacade(IFortuneTeller fortuneT)
        {
           
             _fortuneT = fortuneT;
        }

        public void FortuneTell()
        {
            _fortuneT.TellFortune();

        }
    }
}
