//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormulaServiceSample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class YearResult
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public int RacerId { get; set; }
        public Nullable<int> Place { get; set; }
        public Nullable<decimal> Points { get; set; }
    
        public virtual Racer Racer { get; set; }
    }
}
