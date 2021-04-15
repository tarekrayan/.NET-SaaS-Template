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
    
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            this.CompaniesUsers = new HashSet<CompaniesUser>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Profile { get; set; }
        public string Website { get; set; }
        public Nullable<int> NumberOfEmployees { get; set; }
        public Nullable<int> CompanyCategoryID { get; set; }
        public Nullable<int> CompanySubcategoryID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public Nullable<bool> Private { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompaniesUser> CompaniesUsers { get; set; }
    }
}