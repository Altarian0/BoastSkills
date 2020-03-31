//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoatSkills.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accessory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accessory()
        {
            this.AccToBoats = new HashSet<AccToBoats>();
            this.OrderDetails = new HashSet<OrderDetails>();
        }
    
        public int Accessory_ID { get; set; }
        public string AccName { get; set; }
        public string DescriptionOfAccessory { get; set; }
        public int Price { get; set; }
        public double VAT { get; set; }
        public Nullable<int> Inventory { get; set; }
        public Nullable<int> OrderLevel { get; set; }
        public Nullable<int> OrderBatch { get; set; }
        public int Partner_ID { get; set; }
    
        public virtual Partner Partner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccToBoats> AccToBoats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
