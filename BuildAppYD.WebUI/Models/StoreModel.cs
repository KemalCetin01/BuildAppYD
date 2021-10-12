using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildAppYD.WebUI.Models
{
    public class StoreModel:BaseModel
    {
        public string StoreName { get; set; }
        public int BuildingId { get; set; }
        public BuildingModel Buildings { get; set; }
    }
}
