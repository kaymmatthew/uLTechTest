﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uLTechTest.Support
{
    public class readTestDataConfig
    {
        private static IConfigurationRoot? config { get; set; }

        private static IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "Support"))
                .AddJsonFile("Settings.json");

            config = builder.Build();

            return config;
        }

        public static Uri ULSolutionUrl = new Uri(GetConfiguration().GetValue<string>("Url:ULSolutionUrl"));
    }
}