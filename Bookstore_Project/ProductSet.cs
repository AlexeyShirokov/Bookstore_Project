//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookstore_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductSet()
        {
            this.ProductTraking = new HashSet<ProductTraking>();
        }
    
        public int Id { get; set; }
        public string Books { get; set; }
        public string TadleGames { get; set; }
        public string OfficeSupplies { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public string GameName { get; set; }
        public string NameOfficeSupply { get; set; }
        public Nullable<int> Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductTraking> ProductTraking { get; set; }
    }
}