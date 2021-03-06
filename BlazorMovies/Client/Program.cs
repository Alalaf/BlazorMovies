﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorMovies.Shared.Models;
using Blazor.FileReader;
using BlazorMovies.Client.Helpers;
using BlazorMovies.Client.Repository;

namespace BlazorMovies.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            ConfigureServices(builder.Services);
            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.AddTransient<IRepositoryMovie, RepositoryMovie>();
            services.AddScoped<IHttpService, HttpService>();
            services.AddScoped<IReopsitoryGenre, ReopsitoryGenre>();
            services.AddScoped<IReopsitoryPerson, ReopsitoryPerson>();
            services.AddFileReaderService(options => options.InitializeOnFirstCall = true);
        }
    }
}
