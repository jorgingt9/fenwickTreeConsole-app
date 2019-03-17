using Autofac;
using Autofac.Builder;
using ConsoleApp.Core;
using ConsoleApp.Core.Interfaces;
using ConsoleApp.Service.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class DependencyContainer
    {
        private static readonly Lazy<DependencyContainer> lazy =
           new Lazy<DependencyContainer>(() => new DependencyContainer());
        public static DependencyContainer Instance { get { return lazy.Value; } }
        IContainer container { get; set; }
        private DependencyContainer()
        {
            CreateContainer();
        }
        private void CreateContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Process>().SingleInstance();
            builder.RegisterType<Calculos>().As<ICalculos>();

            container = builder.Build(ContainerBuildOptions.None);
        }

        public T Get<T>() where T : class
        {
            if (container == null)
            {
                CreateContainer();
            }
            return container.Resolve<T>();
        }
    }
}
