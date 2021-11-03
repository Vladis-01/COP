using StudentBusinessLogic.BusinessLogics;
using StudentBusinessLogic.Interfaces;
using StudentDatabaseImplement.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace AppanovLab3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<Form1>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IStudentStorage, StudentStorage>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IDirectionStorage, DirectionStorage>(new
           HierarchicalLifetimeManager());

            currentContainer.RegisterType<StudentLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<DirectionLogic>(new
           HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
