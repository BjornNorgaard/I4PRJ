
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ModelFirstSmartPool
{

using System;
    using System.Collections.Generic;
    
public partial class Residence
{

    public int AddressId { get; set; }

    public string Country { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }

    public string Address { get; set; }

    public int UserUserId { get; set; }



    public virtual User User { get; set; }

    public virtual ValueConstraints ValueConstraint { get; set; }

}

}
