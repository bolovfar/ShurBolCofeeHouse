//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShurBolCofeeHouse.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class VoucherProduct
    {
        public int IDVoucherProduct { get; set; }
        public int IDVoucher { get; set; }
        public int IDProduct { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Voucher Voucher { get; set; }
    }
}
