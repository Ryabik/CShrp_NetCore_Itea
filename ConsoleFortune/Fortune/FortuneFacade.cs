using System;
using System.Collections.Generic;
using System.Text;

namespace Fortune
{
    public class FortuneFacade : IFortuneFacade
    {
        private IFortuneTeller _fortuneT;
        private IFortuneGetter _fortuneG;
        
        public FortuneFacade(IFortuneGetter fortuneG, IFortuneTeller fortuneT)
        {
            _fortuneG = fortuneG;
            _fortuneT = fortuneT;
        }
        public string FortuneGet()
        {
            return _fortuneG.GetFortune();
        }

        public void FortuneTell()
        {
            _fortuneT.TellFortune();

        }
    }
}
