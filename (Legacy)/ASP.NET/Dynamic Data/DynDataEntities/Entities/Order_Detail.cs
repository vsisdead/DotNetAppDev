//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynDataEntities.Entities
{

   public partial class Order_Detail
   {
      public int OrderID { get; set; }
      public int ProductID { get; set; }
      public decimal UnitPrice { get; set; }
      public short Quantity { get; set; }
      public float Discount { get; set; }

      public virtual Order Order { get; set; }
      public virtual Product Product { get; set; }
   }
}