using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extensions
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwaggerSecurityService(this IServiceCollection services,IConfiguration config){

             services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
                // c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                // {
                //     Name = "Authentication",
                //     Type = SecuritySchemeType.Http,
                //     Scheme = "basic",
                //     In = ParameterLocation.Header,
                //     Description = "Basic Authorization header using the Basic scheme.",

                // });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme.",

                });

                // c.AddSecurityRequirement(new OpenApiSecurityRequirement
                // {
                //     {
                //           new OpenApiSecurityScheme
                //             {
                //                 Reference = new OpenApiReference
                //                 {
                //                     Type = ReferenceType.SecurityScheme,
                //                     Id = "basic"
                //                 },
                //                 Name = "basic"
                //             },
                //             new string[] {}
                //     }
                // });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                },
                                Name = "Bearer"
                            },
                            new string[] {}
                    }
                });

                // var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                // var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                // c.IncludeXmlComments(xmlPath);
            });

            return services;
        }
    }
}