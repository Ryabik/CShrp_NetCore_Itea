using System;
using Unity;

namespace Fortune
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IFortuneLoader, FortuneLoader>();
            container.RegisterType<IFortuneTeller, FortuneTeller>();
            container.RegisterType<IFortuneGetter, FortuneGetter>();
            container.RegisterType<IFortuneFacade, FortuneFacade>();

            var fortune = container.Resolve<FortuneFacade>();
            fortune.FortuneGet();
            Console.WriteLine(fortune.FortuneGet());

            //var fortunetell = container.Resolve<FortuneFacade>();
            //fortunetell.FortuneTell();

            Console.Read();

        }
    }
}
