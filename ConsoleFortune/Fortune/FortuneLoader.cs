using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace Fortune
{
    class FortuneLoader : IFortuneLoader
    {
       
        public string LoadFortune()
        {
            MyFortune text = new MyFortune();

            return text.Fortune();

            //return "I'll finish all my homeworks soon!";
            //return File.ReadAllText(@"..\..\res\SomeText.txt");
        }
    }
}