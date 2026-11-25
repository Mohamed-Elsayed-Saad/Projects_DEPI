using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Enum
{
    public enum AvailabilityStatus
    {
        Pending ,//لسه مستني المراجعة
        Approved ,//   تم التحقق والموافقة
        Rejected  ,//  تم رفض الحساب
        UnderReview // تحت المراجعه 
    }
}
