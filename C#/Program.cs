using Microsoft.Extensions.DependencyInjection;
using System;

namespace LDC
{
    class Progam
    {
        static void Main(string[] args)
        {
            //set up DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IStringProcessor, StringProcessor>()
                .BuildServiceProvider();

            var serv = serviceProvider.GetService<IStringProcessor>();


            // single string
            string inString = "AAAc91%cWwWkLq$1ci3_848v3d__K";
            var retString = serv.Process(inString);
            Console.WriteLine(retString);


            // string collection, with sample data
            string[] strCollection = new string[] { "cho47ragic",
                                                    "_d_$eciar£e",
                                                    "blo_cki6est6",
                                                    "ps3eud$ocot#yledonal",
                                                    "inte4%rt$ransfo#rmable",
                                                    "preadvertisement",
                                                    "unaccomplishable" };

            var retVal = serv.ProcessCollection(strCollection);

            foreach (string str in retVal)
                Console.WriteLine(str);

            if (serviceProvider is IDisposable sv)
                sv.Dispose();

        }
    }
}