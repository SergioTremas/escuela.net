using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace libs.dao
{
    public static class dependencias
    {
        static void initInjections()
        {
            new ServiceDescriptor(typeof(IEscuelaDao), new EscuelaDao());

        }
    }
}
