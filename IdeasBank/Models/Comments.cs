//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdeasBank.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public int Id { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> IdeaId { get; set; }
        public string Text { get; set; }
        public string ImplementationInfo { get; set; }
    }
}