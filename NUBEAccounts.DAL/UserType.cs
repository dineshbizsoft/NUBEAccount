//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NUBEAccounts.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserType()
        {
            this.UserAccounts = new HashSet<UserAccount>();
            this.UserTypeDetails = new HashSet<UserTypeDetail>();
        }
    
        public int Id { get; set; }
        public string TypeOfUser { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
    
        public virtual CompanyDetail CompanyDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAccount> UserAccounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserTypeDetail> UserTypeDetails { get; set; }
    }
}
