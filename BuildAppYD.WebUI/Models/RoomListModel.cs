using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildAppYD.WebUI.Models
{
    public class RoomListModel
    {
        public List<RoomModel> Rooms { get; set; }
        public string buildingName { get; set; }
    }
}
