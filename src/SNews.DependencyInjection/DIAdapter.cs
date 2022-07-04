using Microsoft.Extensions.DependencyInjection;
using SNews.BusinessLogic;
using SNews.BusinessLogic.Interfaces;
using SNews.Services;
using SNews.Services.Interfaces;
using System;

namespace SNews.DependencyInjection
{
    public static class DIAdapter
    {
        public static void AddMyServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<INewsBusinessLogic, NewsBusinessLogic>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryBusinessLogic, CategoryBusinessLogic>();
            services.AddScoped<IAuthorBusinessLogic, AuthorBusinessLogic>();
            services.AddScoped<IAuthorService, AuthorService>();

        }
    }
}
