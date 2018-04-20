using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Web;
using System.Data;
using Newtonsoft.Json;

namespace SkkingData.tools
{
    class JSONHandle
    {
        //List<T>转Json
        public static string Obj2Json<T>(T data)
        {
            try
            {
                System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(data.GetType());
                using (MemoryStream ms = new MemoryStream())
                {
                    serializer.WriteObject(ms, data);
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
            catch
            {
                return null;
            }
        }

        //Json转List<T>
        public static Object Json2Obj(String json, Type t)
        {
            try
            {
                System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(t);
                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
                {

                    return serializer.ReadObject(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        public static String getJsonString(object obj) {
            //Json.NET序列化
            string jsonData = JsonConvert.SerializeObject(obj);
            return jsonData;
        }

        public static object getObjFromJson<T>(String jsonString) {
            if (null == jsonString) {
                return null;
            }
            T t = JsonConvert.DeserializeObject<T>(jsonString);
            return t;
        }

    }
    
}
