//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FluidOne.ClientTesting.Dash.PageObjects
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAccount
    {
        public UserAccount()
        {
            this.LoginAttempts = new HashSet<LoginAttempt>();
            this.SMSCodes = new HashSet<SMSCode>();
            this.UserMachineInfoes = new HashSet<UserMachineInfo>();
        }
    
        public int UserAccountID { get; set; }
        public int AccountID { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Enabled { get; set; }
        public bool Deleted { get; set; }
        public string Phone { get; set; }
        public bool IsPrimaryUser { get; set; }
        public short FailedAttempts { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public string LastModifiedUser { get; set; }
        public bool IsMsaAdmin { get; set; }
        public string Email2Factor { get; set; }
        public string CompanyPublicPhone { get; set; }
        public Nullable<bool> PhoneIsLandline { get; set; }
        public int SecurityGroupID { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual ICollection<LoginAttempt> LoginAttempts { get; set; }
        public virtual ICollection<SMSCode> SMSCodes { get; set; }
        public virtual ICollection<UserMachineInfo> UserMachineInfoes { get; set; }
    }
}
