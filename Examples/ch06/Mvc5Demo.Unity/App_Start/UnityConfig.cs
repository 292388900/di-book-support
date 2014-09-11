using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Examples.Common.Services;

namespace Mvc5Demo.Unity.App_Start
{
    /// <summary>
    /// �Ψӳ]�w�D�n�� Unity �e���C
    /// </summary>
    public class UnityConfig
    {
        #region Unity �e��
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// ���o Unity �e�����������C
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>�V Unity �e�����U���O�����C</summary>
        /// <param name="container">���]�w�� Unity �e���C</param>
        /// <remarks>
        ///   ���D�A�Q�n���ܹw�]�欰�A�_�h���ݭn�ۦ���U��H���O�A�Ҧp controllers �� 
        ///   API controllers�F�]���L�׬O�_�w�����U��H���O�AUnity ����۰ʸѪR���̡C
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // �p���z�L web.config �ӳ]�w Unity �e���A�i��_���U�o����ѱ����{���X�C
            // �O�ѤF�٭n�ޥΩR�W�Ŷ� Microsoft.Practices.Unity.Configuration�C

            // �b�����U�A�����O�C
            container.RegisterType<IMessageService, MessageService>();
        }
    }
}
