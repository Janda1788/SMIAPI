//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMIDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class SMI_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SMI_User()
        {
            //this.SMI_Treasury = new HashSet<SMI_Treasury>();
        }
    
        public int ID { get; set; }
        public string UserName { get; set; }
        public byte[] Pwd { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte Sta { get; set; }
        public Nullable<System.DateTime> UserCreationDate { get; set; }
        public Nullable<System.DateTime> UserUpdateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SMI_Treasury> SMI_Treasury { get; set; }
    }
}
