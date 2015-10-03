using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Modified.Json.Bson;
using Newtonsoft.Modified.Json.Linq;

namespace Newtonsoft.Modified.Json.Tests.Documentation.Samples.Linq
{
    public class ReadJTokenFromBson
    {
        public void Example()
        {
            #region Usage
            byte[] data = Convert.FromBase64String("KQAAAAJuYW1lMQAHAAAAdmFsdWUxAAJuYW1lMgAHAAAAdmFsdWUyAAA=");
            MemoryStream ms = new MemoryStream(data);

            JObject o;
            using (BsonReader reader = new BsonReader(ms))
            {
                o = (JObject)JToken.ReadFrom(reader);
            }

            string value = (string)o["name1"];

            Console.WriteLine(value);
            // value1
            #endregion
        }
    }
}