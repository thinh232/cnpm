﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace cheNgonNhatTheGioi.Module.BusinessObjects.classChe
{
    [DefaultClassOptions]
    [DefaultProperty("tenkh")]
    public partial class KhachHang
    {
        public KhachHang(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
