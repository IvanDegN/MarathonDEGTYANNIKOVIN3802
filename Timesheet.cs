//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarathonDEGTYANNIKOVIN3802
{
    using System;
    using System.Collections.Generic;
    
    public partial class Timesheet
    {
        public int TimesheetId { get; set; }
        public int StaffId { get; set; }
        public System.DateTime StarDateTime { get; set; }
        public System.DateTime EndDateTime { get; set; }
        public double PayAmount { get; set; }
    
        public virtual Staff Staff { get; set; }
    }
}