using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Game_Menager.DataAccess.Data
{
    public class Role
    {
        private DateTime _createdDateTime;
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateTime
        {
            get { return DateTime.Now; }
            set { _createdDateTime = value; }
        }
    }
}
