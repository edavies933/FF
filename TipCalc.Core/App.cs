using MvvmCross;
using MvvmCross.ViewModels;
using FF.Core.Services;
using FF.Core.ViewModels;

namespace FF.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}
