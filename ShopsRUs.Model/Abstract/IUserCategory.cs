using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Model.Abstract
{
    /// <summary>
    /// employee, affiliate, over 2 years ,groceries ,For every $100
    /// </summary>
    public interface IUserCategory
    {
        public int UserCategoryID { get; set; }
        public string UserCategoryName { get; set; }
    }
}
