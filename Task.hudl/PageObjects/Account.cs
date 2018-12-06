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
    
    public partial class Account
    {
        public Account()
        {
            this.Accounts1 = new HashSet<Account>();
            this.Accounts11 = new HashSet<Account>();
            this.UserAccounts = new HashSet<UserAccount>();
        }
    
        public int AccountID { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public Nullable<int> ParentAccountID { get; set; }
        public int AccountTypeID { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public string LastModifiedUser { get; set; }
        public bool Deleted { get; set; }
        public bool CustomAccount { get; set; }
        public Nullable<int> HeadOfficeAccountID { get; set; }
    
        public virtual ICollection<Account> Accounts1 { get; set; }
        public virtual Account Account1 { get; set; }
        public virtual ICollection<Account> Accounts11 { get; set; }
        public virtual Account Account2 { get; set; }
        public virtual ICollection<UserAccount> UserAccounts { get; set; }
    }
}
