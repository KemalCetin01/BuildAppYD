using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildAppYD.WebUI.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime createTime { get; set; }
        public bool isDeleted { get; set; }
    }
}
