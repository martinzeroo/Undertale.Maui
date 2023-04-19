using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undertale.Maui.Models
{
    public class Monsters
    {
        public string Name { get; set; }
        public string Quote { get; set; }
        public string CharacterImage { get; set; }
        public string Description { get; set; }
        public Color AccentColorStart { get; set; }
        public Color AccentColorEnd { get; set; }
        public List<string> Images { get; set; }
    }
}
