using System;
using Autofac;
using DAT.Context;
using DAT.Template.Services;

namespace DAT.Template
{
    class Program
    {
        static void Main(string[] args)
        {
            DATContext.PreContainerBuild += (sender, builder) =>
            {
                builder.RegisterType<SampleService>();
                builder.RegisterType<Handlers>();

                // TODO: Add custom services

            };
            
            DATContext.Bootstrap();

            IContainer container = DATContext.Container;

            Handlers handlers = container.Resolve<Handlers>();
            
            handlers.Setup();
        }
    }
}