using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Ex0_Common.Services;

namespace Ex4_UnityMvc5
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // �b�o�̦V�e�����U�A������C�A�� controller ���ε��U�C
            container.RegisterType<IHelloService, HelloService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}