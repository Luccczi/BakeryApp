//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BakeryApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItemOrder
    {
        public int id { get; set; }
        public int idOrder { get; set; }
        public int idItem { get; set; }
        public int quantity { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
