//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KpopZtation
{
    using System;
    using System.Collections.Generic;
    
    public partial class msAlbum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public msAlbum()
        {
            this.msCarts = new HashSet<msCart>();
            this.msTransactionDetails = new HashSet<msTransactionDetail>();
        }
    
        public int AlbumID { get; set; }
        public int ArtistID { get; set; }
        public string AlbumName { get; set; }
        public string AlbumImage { get; set; }
        public int AlbumPrice { get; set; }
        public int AlbumStock { get; set; }
        public string AlbumDescription { get; set; }
    
        public virtual msArtist msArtist { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<msCart> msCarts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<msTransactionDetail> msTransactionDetails { get; set; }
    }
}