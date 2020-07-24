using Autofac;
using Banking_API.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking_API.IOC
{
    public class BankingModule: Module
    {
        private readonly IConfiguration configuration;

        public BankingModule(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        private T GetSettings<T>(string path = null) where T : new()
        {
            path = path ?? typeof(T).Name;
            var settings = new T();
            this.configuration.GetSection(path).Bind(settings);
            return settings;
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.Register(c => this.GetSettings<DataBaseSettings>("DataBaseSettings"))
            .As<DataBaseSettings>()
            .SingleInstance();
        }


    }
}
