//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMIDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class SMI_TreasuryDetail
    {
        public int IdTreasury { get; set; }
        public decimal TenPercent { get; set; }
        public decimal TenPercentLocal { get; set; }
        public decimal FirstFruits { get; set; }
        public decimal FirstFruitsLocal { get; set; }
        public decimal SabbathSchool { get; set; }
        public decimal SabbathSchoolLocal { get; set; }
        public decimal SpecialSabbathSchool { get; set; }
        public decimal SpecialSabbathSchoolLocal { get; set; }
        public decimal AssociationOffering { get; set; }
        public decimal AssociationOfferingLocal { get; set; }
        public decimal EmergencyFund { get; set; }
        public decimal EmergencyFundLocal { get; set; }
        public decimal ChurchTenPercent { get; set; }
        public decimal ChurchTenPercentLocal { get; set; }
        public decimal WeekOfPrayer { get; set; }
        public decimal WeekOfPrayerLocal { get; set; }
        public decimal Others { get; set; }
        public decimal OthersLocal { get; set; }
        public decimal MonetaryReductions { get; set; }
        public decimal MonetaryReductionsLocal { get; set; }
        public Nullable<System.DateTime> TreasuryDetailDate { get; set; }
    
        public virtual SMI_Treasury SMI_Treasury { get; set; }
    }
}
