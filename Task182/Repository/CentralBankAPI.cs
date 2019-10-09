using Newtonsoft.Json;
using RestSharp;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Task182.Model;

namespace Task182.Repository
{
    public static class CentralBankAPI
    {

        public static ValCurs getData()
        {


                XmlDocument xml = new XmlDocument();
                xml.Load("http://www.cbr.ru/scripts/XML_daily.asp?date_req=04/10/2019");
                XmlSerializer ser = new XmlSerializer(typeof(ValCurs));
                var res = new StringReader(xml.InnerXml);
                var model = (ValCurs)ser.Deserialize(res);

                return model;

        }

    }
}
