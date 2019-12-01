using System;

namespace Shop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreateDte { get; set; }
        string CreateBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }
        string MetaKeyWord { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }

    }
}