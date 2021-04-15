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
    
    public partial class Notification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Notification()
        {
            this.NotificationDeliveries = new HashSet<NotificationDelivery>();
        }
    
        public int ID { get; set; }
        public string UserID { get; set; }
        public Nullable<int> ContractID { get; set; }
        public Nullable<int> MessageID { get; set; }
        public Nullable<int> TaskID { get; set; }
        public string SenderUserID { get; set; }
        public Nullable<bool> Viewed { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string Subject { get; set; }
        public string Abstract { get; set; }
        public string Body { get; set; }
        public string EmailBody { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Message Message { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationDelivery> NotificationDeliveries { get; set; }
        public virtual Task Task { get; set; }
    }
}
