//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyData
{
    using System;
    using System.Collections.Generic;
    
    public partial class vw_Messages
    {
        public int ID { get; set; }
        public string RecipientUserID { get; set; }
        public string SenderUserID { get; set; }
        public Nullable<int> ContractID { get; set; }
        public string Message { get; set; }
        public Nullable<bool> RecipientViewed { get; set; }
        public Nullable<bool> SenderDeleted { get; set; }
        public Nullable<bool> RecipientDeleted { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string SenderFirstName { get; set; }
        public string SenderLastName { get; set; }
        public string RecipientFirstName { get; set; }
        public string RecipientLastName { get; set; }
    }
}
