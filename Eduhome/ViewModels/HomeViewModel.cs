using Eduhome.Models;
using System.Collections.Generic;

namespace Eduhome.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<Feature> Features { get; set; }
        public Setting Setting { get; set; }
        public List<Course> Courses { get; set; }
        public List<Event> Events { get; set; }
        public List<Teacher> Teachers { get; set; }

    }
}
