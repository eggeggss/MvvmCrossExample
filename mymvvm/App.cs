using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using Cirrious.MvvmCross.ViewModels;
namespace mymvvm
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {

       
        public override void Initialize()
        {
            /*
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
			*/	
            RegisterAppStart<ViewModels.TipCalViewModel>();

           
           
        }
    }
}