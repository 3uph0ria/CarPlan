//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace vcids.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Adverts
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Article { get; set; }
        public Nullable<int> Cost { get; set; }
        public string Phone { get; set; }
    
        public virtual Users Users { get; set; }
    }
}