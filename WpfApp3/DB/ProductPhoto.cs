//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp3.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPhoto
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string PhotoPath { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
