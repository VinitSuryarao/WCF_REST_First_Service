using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace ClientMaster.Service
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ClientService
    {
        [OperationContract, WebGet(ResponseFormat = WebMessageFormat.Json)]
        public string DoWork()
        {
            return "Welcome to First RESt WCF App";
        }

    }
}
