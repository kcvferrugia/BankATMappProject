//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankATMapp.Services
{
    using System;
    using System.Collections.Generic;
    
    public partial class Withdrawls
    {
        public int WithdrawalID { get; set; }
        public int TransactionID { get; set; }
        public decimal Amount { get; set; }
    
        public virtual Transactions Transactions { get; set; }
    }
}
