using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1
{
    [DataContract]
    public class Bocauhoi
    {

        string noidungcauhoi = string.Empty;
        string dapana = string.Empty;
        string dapanb = string.Empty;
        string dapanc = string.Empty;
        string dapand = string.Empty;
        int dapandung = int.MaxValue;
        int cautraloi = int.MaxValue;

        int titleid = int.MaxValue;

        [DataMember]
        public int titleId
        {
            get { return titleid; }
            set { titleid = value; }
        }

        [DataMember]
        public string noiDungCauHoi
        {
            get { return noidungcauhoi; }
            set { noidungcauhoi=value; }
        }

        [DataMember]
        public string dapanA
        {
            get { return dapana; }
            set { dapana=value; }
        }

        [DataMember]
        public string dapanB
        {
            get { return dapanb; }
            set { dapanb=value; }
        }

        [DataMember]
        public string dapanC
        {
            get { return dapanc; }
            set { dapanc=value; }
        }

        [DataMember]
        public string dapanD
        {
            get { return dapand; }
            set { dapand=value; }
        }

        [DataMember]
        public int dapAnDung
        {
            get { return dapandung; }
            set { dapandung=value; }
        }

        [DataMember]
        public int cauTraLoi
        {
            get { return cautraloi; }
            set { cautraloi = value; }
        }
        //public Bocauhoi()
        //{
        //    this.noiDungCauHoi = string.Empty;
        //    this.dapanA = string.Empty;
        //    this.dapanB = string.Empty;
        //    this.dapanC = string.Empty;
        //    this.dapanD = string.Empty;
        //    this.dapAnDung = 0;
        //    this.cauTraLoi = 0;
        //}
        //public Bocauhoi(Bocauhoi cauHoi)
        //{
        //    this.noiDungCauHoi = cauHoi.noiDungCauHoi;
        //    this.dapanA = cauHoi.dapanA;
        //    this.dapanB = cauHoi.dapanB;
        //    this.dapanC = cauHoi.dapanC;
        //    this.dapanD = cauHoi.dapanD;
        //    this.dapAnDung = cauHoi.dapAnDung;
        //    this.cauTraLoi = cauHoi.cauTraLoi;
        //}
    }
}