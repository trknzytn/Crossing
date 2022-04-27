using ShopsRUs.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopsRUs.Model
{
    public class User : IUser
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string SurUserName { get; set; }

        public DateTime CreateDate { get; set; }
        public IEnumerable<IUserCategory> UserCategories { get; set; }
    }
}
