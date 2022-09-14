using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitFramework.TestUtilities
{
    public class JsonReader
    {
        public string GetTestData(string tokenKey)
        {
            string JsonFile = File.ReadAllText(ConfigurationManager.AppSettings["testDataFilePath"]);
            //Helps to read all Json file from "TestData/LoginTestData"

            var JsonObject = JToken.Parse(JsonFile); //Helps to pick the each object from the "TestData/LoginTestData"

            return JsonObject.SelectToken(tokenKey).Value<string>(); 

        }
    }
}
