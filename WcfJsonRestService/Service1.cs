using System;
using System.Runtime.Serialization;
using System.ServiceModel.Web;

namespace WcfJsonRestService
{
    public class Service1 : IService1
    {
      
        [WebInvoke(Method = "GET",
                  ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "guitar/{id}")]
        public Guitar GetGuitarData(string id)
        {
            return new Guitar(id);
        }
         [WebInvoke(Method = "GET",
                  ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "guitars/{id}")]
        public Guitar[] GetGuitars(string id)
        {
            if (!string.IsNullOrEmpty(id) && id!="0")
                return new Guitar[] { new Guitar(id) };
            
            return new Guitar[] {
                new Guitar("1"),
                new Guitar("2"),
                new Guitar("3")
            };
        }
    }
  
    [DataContract]
    public class Guitar
    {
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Image { get; set; }

        public Guitar(string id)
        {
            switch (id)
            {
                case "1":
                    Name = "Akustara";
                    Description = "Akustična gitara marke ŠBRK";
                    Image = "Acoustic";
                    break;
                case "2":
                    Name = "Električna";
                    Description = "Električna gitara marke ŠBRK";
                    Image = "Electric";
                    break;
                case "3":
                    Name = "Bas";
                    Description = "Bas gitara marke ŠBRK";
                    Image = "Bass";
                    break;

            }
        }
    }
}
