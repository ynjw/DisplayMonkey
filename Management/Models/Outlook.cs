//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DisplayMonkey.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Outlook : Frame
    {
        public OutlookModes Mode { get; set; }
        public string Name { get; set; }
        public string Mailbox { get; set; }
        public int ShowEvents { get; set; }
        public int AccountId { get; set; }
        public OutlookPrivacy Privacy { get; set; }
        public bool AllowReserve { get; set; }
        public int ShowAsFlags { get; set; }
    
        public virtual ExchangeAccount ExchangeAccount { get; set; }
    }
}
