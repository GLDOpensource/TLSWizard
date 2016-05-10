using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace GenerateIt {
    public  class MC4RPC : IDisposable {
        private string m_URL;
        private string m_pass;
        private string m_login;
        private string m_SessionID;

        private JObject request(string servername, string session, string ubusNode, string command, JObject callArgs) {
            var request = (HttpWebRequest)WebRequest.Create("http://" + servername + "/ubus/");
            var postData = "{jsonrpc: \"2.0\", method: \"call\",params:[]}";
            JObject objTmp = JObject.Parse(postData);
            (objTmp["params"] as JArray).Add(session);
            (objTmp["params"] as JArray).Add(ubusNode);
            (objTmp["params"] as JArray).Add(command);
            (objTmp["params"] as JArray).Add(callArgs);

            var data = Encoding.ASCII.GetBytes(objTmp.ToString());
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream()) {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            JObject obj = JObject.Parse(responseString);
            if (obj["result"][0].ToString() != "0")
                throw new Exception("MC4RPC Webrequest Failed.");
            return obj;

        }

        public MC4RPC(string URL, string login, string pass) {
            m_URL = URL;
            m_login = login;
            m_pass = pass;
            m_SessionID = ReLogin();
        }

        public bool uploadTLS(string cert, string key){
            JObject obj = request(m_URL, m_SessionID, "mc4eth", "set_SSL", new JObject { { "key", key }, { "cert", cert } });
            if (obj["result"][1]["installed"].ToString() != "2")
                return false;
            return true;
        }

        public void Dispose() {
            Close();
        }

        public void Close() {
            JObject obj = request(m_URL, m_SessionID, "session", "destroy", new JObject());
        }

        public string ReLogin() {
            JObject jo = new JObject{
                         { "username", m_login },
                         { "password", m_pass }
                     };
            JObject obj = request(m_URL, "00000000000000000000000000000000", "session", "login", jo);
            m_SessionID = obj["result"][1]["ubus_rpc_session"].ToString();
            return m_SessionID;

        }
        
    }
}
