// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.AspNetIdentity;
using IdentityServer4.Configuration;
using IdentityServer4.Configuration.DependencyInjection;
using IdentityServer4.Host.Repositories.Extensions;
using IdentityServer4.Host.Services;
using IdentityServer4.Host.Stores;
using IdentityServer4.Host.Stores.Contracts;
using IdentityServer4.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace IdentityServer4.Host
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages()
                .AddRazorPagesOptions(options =>
                    {
                        options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
                    });

            services.AddIdentity<ApplicationUser, IdentityRole>().AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
                options.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            }).AddCookie(options =>
            {
                options.CookieManager = new ChunkingCookieManager();

                options.Cookie.HttpOnly = true;
                options.Cookie.SameSite = SameSiteMode.None;
                options.Cookie.SecurePolicy = CookieSecurePolicy.None;
            });

            services.AddIdentityServer(options =>
                {
                    options.UserInteraction.LoginUrl = "/Identity/Account/Login";
                    options.UserInteraction.LogoutUrl = "/Identity/Account/Logout";
                })
                .AddResourceStore<ResourcesStore>()
                .AddClientStore<ClientStore>()
                .AddUserEmailStore<UserEmailStore>()
                .AddSavedConsentStore<SavedConsentStore>()
                .AddPersistedGrantStore<PersistentGrantStore>()
                .AddAspNetIdentity<ApplicationUser>()
                .AddProfileService<ProfileService>()
                .AddResourceOwnerValidator<MyResourceOwnerPasswordValidator>()
                .AddDeveloperSigningCredential();

            services.AddTransient(typeof(IRoleStore<>), typeof(RoleStore<>));
            services.AddTransient<IApplicationUserStore, UserStore<ApplicationUser>>();
            services.AddTransient(typeof(IUserStore<>), typeof(UserStore<>));

            services.AddTransient<IProfileService, ProfileService>();
            services.AddTransient<IEmailSender, EmailSender>();

            services
                .RegisterStoreRepositories();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseIdentityServer();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}