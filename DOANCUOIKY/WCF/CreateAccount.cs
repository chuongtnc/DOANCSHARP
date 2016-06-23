using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [DataContract]
    public class CreateAccount
    {

        string username = string.Empty;
        string password = string.Empty;
        int mssv = int.MinValue;
        string hovaten = string.Empty;

        [DataMember]
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DataMember]
        public int Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }

        [DataMember]
        public string HovaTen
        {
            get { return hovaten; }
            set { hovaten = value; }
        }
    }
}