﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DOANCUOIKY.WCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfoToValidate", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class UserInfoToValidate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateAccount", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class CreateAccount : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HovaTenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MssvField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HovaTen {
            get {
                return this.HovaTenField;
            }
            set {
                if ((object.ReferenceEquals(this.HovaTenField, value) != true)) {
                    this.HovaTenField = value;
                    this.RaisePropertyChanged("HovaTen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Mssv {
            get {
                return this.MssvField;
            }
            set {
                if ((this.MssvField.Equals(value) != true)) {
                    this.MssvField = value;
                    this.RaisePropertyChanged("Mssv");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bocauhoi", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class Bocauhoi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int cauTraLoiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int dapAnDungField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dapanAField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dapanBField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dapanCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dapanDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string noiDungCauHoiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int titleIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int cauTraLoi {
            get {
                return this.cauTraLoiField;
            }
            set {
                if ((this.cauTraLoiField.Equals(value) != true)) {
                    this.cauTraLoiField = value;
                    this.RaisePropertyChanged("cauTraLoi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int dapAnDung {
            get {
                return this.dapAnDungField;
            }
            set {
                if ((this.dapAnDungField.Equals(value) != true)) {
                    this.dapAnDungField = value;
                    this.RaisePropertyChanged("dapAnDung");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dapanA {
            get {
                return this.dapanAField;
            }
            set {
                if ((object.ReferenceEquals(this.dapanAField, value) != true)) {
                    this.dapanAField = value;
                    this.RaisePropertyChanged("dapanA");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dapanB {
            get {
                return this.dapanBField;
            }
            set {
                if ((object.ReferenceEquals(this.dapanBField, value) != true)) {
                    this.dapanBField = value;
                    this.RaisePropertyChanged("dapanB");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dapanC {
            get {
                return this.dapanCField;
            }
            set {
                if ((object.ReferenceEquals(this.dapanCField, value) != true)) {
                    this.dapanCField = value;
                    this.RaisePropertyChanged("dapanC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string dapanD {
            get {
                return this.dapanDField;
            }
            set {
                if ((object.ReferenceEquals(this.dapanDField, value) != true)) {
                    this.dapanDField = value;
                    this.RaisePropertyChanged("dapanD");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string noiDungCauHoi {
            get {
                return this.noiDungCauHoiField;
            }
            set {
                if ((object.ReferenceEquals(this.noiDungCauHoiField, value) != true)) {
                    this.noiDungCauHoiField = value;
                    this.RaisePropertyChanged("noiDungCauHoi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int titleId {
            get {
                return this.titleIdField;
            }
            set {
                if ((this.titleIdField.Equals(value) != true)) {
                    this.titleIdField = value;
                    this.RaisePropertyChanged("titleId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="examheader", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class examheader : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ehIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ehScoreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ehTTanswerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ehTquestionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ehId {
            get {
                return this.ehIdField;
            }
            set {
                if ((this.ehIdField.Equals(value) != true)) {
                    this.ehIdField = value;
                    this.RaisePropertyChanged("ehId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ehScore {
            get {
                return this.ehScoreField;
            }
            set {
                if ((this.ehScoreField.Equals(value) != true)) {
                    this.ehScoreField = value;
                    this.RaisePropertyChanged("ehScore");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ehTTanswer {
            get {
                return this.ehTTanswerField;
            }
            set {
                if ((this.ehTTanswerField.Equals(value) != true)) {
                    this.ehTTanswerField = value;
                    this.RaisePropertyChanged("ehTTanswer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ehTquestion {
            get {
                return this.ehTquestionField;
            }
            set {
                if ((this.ehTquestionField.Equals(value) != true)) {
                    this.ehTquestionField = value;
                    this.RaisePropertyChanged("ehTquestion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="examLine", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class examLine : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int elAnswerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int elIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int elQuestionIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int elAnswer {
            get {
                return this.elAnswerField;
            }
            set {
                if ((this.elAnswerField.Equals(value) != true)) {
                    this.elAnswerField = value;
                    this.RaisePropertyChanged("elAnswer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int elId {
            get {
                return this.elIdField;
            }
            set {
                if ((this.elIdField.Equals(value) != true)) {
                    this.elIdField = value;
                    this.RaisePropertyChanged("elId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int elQuestionId {
            get {
                return this.elQuestionIdField;
            }
            set {
                if ((this.elQuestionIdField.Equals(value) != true)) {
                    this.elQuestionIdField = value;
                    this.RaisePropertyChanged("elQuestionId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCF.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoginUserDetails", ReplyAction="http://tempuri.org/IService1/LoginUserDetailsResponse")]
        string[] LoginUserDetails(DOANCUOIKY.WCF.UserInfoToValidate userInfoToValidate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddTitle", ReplyAction="http://tempuri.org/IService1/AddTitleResponse")]
        bool AddTitle(string titleNo, string titleName, int titleCategory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadDataTitle", ReplyAction="http://tempuri.org/IService1/LoadDataTitleResponse")]
        System.Data.DataTable LoadDataTitle();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadDataTitleByParameters", ReplyAction="http://tempuri.org/IService1/LoadDataTitleByParametersResponse")]
        System.Data.DataTable LoadDataTitleByParameters(string titleNo, string titleName, int titleCategory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateTitle", ReplyAction="http://tempuri.org/IService1/UpdateTitleResponse")]
        bool UpdateTitle(string titleID, string titleNo, string titleName, int titleCategory);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteTitle", ReplyAction="http://tempuri.org/IService1/DeleteTitleResponse")]
        bool DeleteTitle(string titleID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddCategory", ReplyAction="http://tempuri.org/IService1/AddCategoryResponse")]
        bool AddCategory(string categoryNo, string categoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadDataCategory", ReplyAction="http://tempuri.org/IService1/LoadDataCategoryResponse")]
        System.Data.DataTable LoadDataCategory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadDataCategoryByParameters", ReplyAction="http://tempuri.org/IService1/LoadDataCategoryByParametersResponse")]
        System.Data.DataTable LoadDataCategoryByParameters(string categoryNo, string categoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateCategory", ReplyAction="http://tempuri.org/IService1/UpdateCategoryResponse")]
        bool UpdateCategory(string categoryID, string categoryNo, string categoryName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCategory", ReplyAction="http://tempuri.org/IService1/DeleteCategoryResponse")]
        bool DeleteCategory(string categoryID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddQuestion", ReplyAction="http://tempuri.org/IService1/AddQuestionResponse")]
        bool AddQuestion(int titleID, string questionNo, string question, string A, string B, string C, string D, string answer, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadDataQuestion", ReplyAction="http://tempuri.org/IService1/LoadDataQuestionResponse")]
        System.Data.DataTable LoadDataQuestion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadDataQuestionByParameters", ReplyAction="http://tempuri.org/IService1/LoadDataQuestionByParametersResponse")]
        System.Data.DataTable LoadDataQuestionByParameters(int titleID, string questionNo, string question, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateQuestion", ReplyAction="http://tempuri.org/IService1/UpdateQuestionResponse")]
        bool UpdateQuestion(int questionID, int titleID, string question, string A, string B, string C, string D, string answer, string status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteQuestion", ReplyAction="http://tempuri.org/IService1/DeleteQuestionResponse")]
        bool DeleteQuestion(string questionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadDataStudentByParameters", ReplyAction="http://tempuri.org/IService1/LoadDataStudentByParametersResponse")]
        System.Data.DataTable LoadDataStudentByParameters(string studentNo, string studentName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadDataExamByParameters", ReplyAction="http://tempuri.org/IService1/LoadDataExamByParametersResponse")]
        System.Data.DataTable LoadDataExamByParameters(string studentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadDataExamLineByParameters", ReplyAction="http://tempuri.org/IService1/LoadDataExamLineByParametersResponse")]
        System.Data.DataTable LoadDataExamLineByParameters(string examHeaderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertCreateAccount", ReplyAction="http://tempuri.org/IService1/InsertCreateAccountResponse")]
        string InsertCreateAccount(DOANCUOIKY.WCF.CreateAccount c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateAccount", ReplyAction="http://tempuri.org/IService1/updateAccountResponse")]
        string updateAccount(DOANCUOIKY.WCF.CreateAccount uc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/loadQuestion1", ReplyAction="http://tempuri.org/IService1/loadQuestion1Response")]
        System.Data.DataTable loadQuestion1(DOANCUOIKY.WCF.Bocauhoi q);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveExam", ReplyAction="http://tempuri.org/IService1/saveExamResponse")]
        int saveExam(DOANCUOIKY.WCF.examheader eh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/insertExamLine", ReplyAction="http://tempuri.org/IService1/insertExamLineResponse")]
        string insertExamLine(DOANCUOIKY.WCF.examLine el);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : DOANCUOIKY.WCF.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<DOANCUOIKY.WCF.IService1>, DOANCUOIKY.WCF.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] LoginUserDetails(DOANCUOIKY.WCF.UserInfoToValidate userInfoToValidate) {
            return base.Channel.LoginUserDetails(userInfoToValidate);
        }
        
        public bool AddTitle(string titleNo, string titleName, int titleCategory) {
            return base.Channel.AddTitle(titleNo, titleName, titleCategory);
        }
        
        public System.Data.DataTable LoadDataTitle() {
            return base.Channel.LoadDataTitle();
        }
        
        public System.Data.DataTable LoadDataTitleByParameters(string titleNo, string titleName, int titleCategory) {
            return base.Channel.LoadDataTitleByParameters(titleNo, titleName, titleCategory);
        }
        
        public bool UpdateTitle(string titleID, string titleNo, string titleName, int titleCategory) {
            return base.Channel.UpdateTitle(titleID, titleNo, titleName, titleCategory);
        }
        
        public bool DeleteTitle(string titleID) {
            return base.Channel.DeleteTitle(titleID);
        }
        
        public bool AddCategory(string categoryNo, string categoryName) {
            return base.Channel.AddCategory(categoryNo, categoryName);
        }
        
        public System.Data.DataTable LoadDataCategory() {
            return base.Channel.LoadDataCategory();
        }
        
        public System.Data.DataTable LoadDataCategoryByParameters(string categoryNo, string categoryName) {
            return base.Channel.LoadDataCategoryByParameters(categoryNo, categoryName);
        }
        
        public bool UpdateCategory(string categoryID, string categoryNo, string categoryName) {
            return base.Channel.UpdateCategory(categoryID, categoryNo, categoryName);
        }
        
        public bool DeleteCategory(string categoryID) {
            return base.Channel.DeleteCategory(categoryID);
        }
        
        public bool AddQuestion(int titleID, string questionNo, string question, string A, string B, string C, string D, string answer, string status) {
            return base.Channel.AddQuestion(titleID, questionNo, question, A, B, C, D, answer, status);
        }
        
        public System.Data.DataTable LoadDataQuestion() {
            return base.Channel.LoadDataQuestion();
        }
        
        public System.Data.DataTable LoadDataQuestionByParameters(int titleID, string questionNo, string question, string status) {
            return base.Channel.LoadDataQuestionByParameters(titleID, questionNo, question, status);
        }
        
        public bool UpdateQuestion(int questionID, int titleID, string question, string A, string B, string C, string D, string answer, string status) {
            return base.Channel.UpdateQuestion(questionID, titleID, question, A, B, C, D, answer, status);
        }
        
        public bool DeleteQuestion(string questionID) {
            return base.Channel.DeleteQuestion(questionID);
        }
        
        public System.Data.DataTable LoadDataStudentByParameters(string studentNo, string studentName) {
            return base.Channel.LoadDataStudentByParameters(studentNo, studentName);
        }
        
        public System.Data.DataTable LoadDataExamByParameters(string studentID) {
            return base.Channel.LoadDataExamByParameters(studentID);
        }
        
        public System.Data.DataTable LoadDataExamLineByParameters(string examHeaderID) {
            return base.Channel.LoadDataExamLineByParameters(examHeaderID);
        }
        
        public string InsertCreateAccount(DOANCUOIKY.WCF.CreateAccount c) {
            return base.Channel.InsertCreateAccount(c);
        }
        
        public string updateAccount(DOANCUOIKY.WCF.CreateAccount uc) {
            return base.Channel.updateAccount(uc);
        }
        
        public System.Data.DataTable loadQuestion1(DOANCUOIKY.WCF.Bocauhoi q) {
            return base.Channel.loadQuestion1(q);
        }
        
        public int saveExam(DOANCUOIKY.WCF.examheader eh) {
            return base.Channel.saveExam(eh);
        }
        
        public string insertExamLine(DOANCUOIKY.WCF.examLine el) {
            return base.Channel.insertExamLine(el);
        }
    }
}
