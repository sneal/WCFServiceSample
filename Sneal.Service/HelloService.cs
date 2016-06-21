using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Sneal.Service
{
    [ServiceContract]
    public interface IHelloService
    {
        [WebGet]
        string Echo(string msg);
    }

    public class HelloService : IHelloService
    {
        public string Echo(string msg)
        {
            return "Hello from " + msg;
        }
    }
}
