
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildAppYD.WebUI.Models
{
    public class RoomModel:BaseModel
    {
        public string roomName { get; set; }

        public int BuildingId { get; set; }
        public BuildingModel Buildings { get; set; }
    }
}
