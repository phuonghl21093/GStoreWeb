using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web365Domain;

namespace Web365Models
{
    public class VideoModel
    {
        public List<VideoItem> List { get; set; }
        public int Total { get; set; }        
    }
}
