using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildAppYD.WebUI.Models
{
    public class BuildingModel:BaseModel
    {
        public string buildingName { get; set; }
        public string buildingNo { get; set; }
        public string fullAddress { get; set; }
        public long squareMeter { get; set; }

        public List<RoomModel> Rooms { get; set; }
        public List<StoreModel> Stores { get; set; }
    }
}
