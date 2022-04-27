using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Model.Abstract
{
    public interface IUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string SurUserName { get; set; }
        public DateTime CreateDate { get; set; }
        public IEnumerable<IUserCategory> UserCategories { get; set; }
    }
}
