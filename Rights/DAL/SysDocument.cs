//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Langben.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SysDocument
    {
        public SysDocument()
        {
            this.SysDocumentTalk = new HashSet<SysDocumentTalk>();
            this.SysDepartment = new HashSet<SysDepartment>();
            this.SysPerson = new HashSet<SysPerson>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string FullPath { get; set; }
        public string Suffix { get; set; }
        public Nullable<int> Size { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Download { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreatePerson { get; set; }
    
        public virtual ICollection<SysDocumentTalk> SysDocumentTalk { get; set; }
        public virtual ICollection<SysDepartment> SysDepartment { get; set; }
        public virtual ICollection<SysPerson> SysPerson { get; set; }
    }
}
