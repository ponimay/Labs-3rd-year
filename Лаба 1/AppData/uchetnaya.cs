//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Лаба_1.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class uchetnaya
    {
        public int id_zapisi { get; set; }
        public int id_litsscheta { get; set; }
        public string month_of_payment { get; set; }
        public int tarif { get; set; }
        public int quantity_of_kvatt { get; set; }
    
        public virtual spravochniki spravochniki { get; set; }
    }
}
