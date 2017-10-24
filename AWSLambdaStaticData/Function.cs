using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Amazon.Lambda.Core;
using System.IO;
using Newtonsoft.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AWSLambdaStaticData
{
    public class GigawadData
    {
        
        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string Get(ILambdaContext context)
        {
            GigawadStaticData myData = new GigawadStaticData();

            myData.name = "Gigawad from Lambda";
            myData.message = "Hooray for Lambda!";

            return JsonConvert.SerializeObject(myData);
        }
    }

    [DataContract]
    public class GigawadStaticData
    {
        [DataMember]
        internal string name;

        [DataMember]
        internal string message;
    }

}
