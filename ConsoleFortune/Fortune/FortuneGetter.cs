using System;
using System.Collections.Generic;
using System.Text;

namespace Fortune
{
    public class FortuneGetter : IFortuneGetter
    {
        private IFortuneLoader _fortuneG;

        public FortuneGetter(IFortuneLoader fortuneGet)
        {
            _fortuneG = fortuneGet;
        }
        public string GetFortune()
        {
           return _fortuneG.LoadFortune();
        }
    }
}
