//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiTrainer.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonType
    {
        public PersonType()
        {
            this.People = new HashSet<Person>();
        }
    
        public int PersonTypeID { get; set; }
        public string PersonType1 { get; set; }
    
        public virtual ICollection<Person> People { get; set; }
    }
}