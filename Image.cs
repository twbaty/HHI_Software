//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HHI_InspectionSoftware
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Web;

    public partial class Image
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DisplayName("Upload File")]

        public string FilePath { get; set; }
        public Nullable<int> CommentID { get; set; }
        public Nullable<int> InspectionReportID { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual InspectionReport InspectionReport { get; set; }
    }
}
