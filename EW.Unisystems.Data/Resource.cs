//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EW.Unisystems.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Resource
    {
        public int IdResource { get; set; }
        public int IdCareer { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public int TypeResource { get; set; }
        public string Author { get; set; }
        public byte[] ResourceImage { get; set; }
    
        public virtual Career Career { get; set; }
        public virtual TypeResource TypeResource1 { get; set; }
    }
}