using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace AuthApi.Providers
{
    public class CustomAuthenticationTokenProvider : AuthenticationTokenProvider
    {
        public override void Create(AuthenticationTokenCreateContext context)
        {
            base.Create(context);
        }

        public override Task CreateAsync(AuthenticationTokenCreateContext context)
        {
            return base.CreateAsync(context);
        }

        public override void Receive(AuthenticationTokenReceiveContext context)
        {
            base.Receive(context);
        }

        public override Task ReceiveAsync(AuthenticationTokenReceiveContext context)
        {
            return base.ReceiveAsync(context);
        }
    }
}