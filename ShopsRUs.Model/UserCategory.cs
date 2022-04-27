using ShopsRUs.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopsRUs.Model
{
    public class UserCategory: IUserCategory
    {
        public int UserCategoryID { get; set; }
        public string UserCategoryName { get; set; }
    }
}
