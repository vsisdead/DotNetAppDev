﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Spa.Startup))]

namespace Spa
{
   public partial class Startup
   {
      public void Configuration(IAppBuilder app)
      {
         ConfigureAuth(app);
      }
   }
}
