//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA43Team11ALibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookCopy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookCopy()
        {
            this.LoanTransactionLines = new HashSet<LoanTransactionLine>();
        }
    
        public int ISBN { get; set; }
        public int BookID { get; set; }
        public string IsRef { get; set; }
        public string BookStatus { get; set; }
    
        public virtual Book Book { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanTransactionLine> LoanTransactionLines { get; set; }
    }
}