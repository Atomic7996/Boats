//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoatsProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fits
    {
        public int FitId { get; set; }
        public int AccessoryId { get; set; }
        public int BoatId { get; set; }
    
        public virtual Accessuars Accessuars { get; set; }
        public virtual Boats Boats { get; set; }
    }
}
