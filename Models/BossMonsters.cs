using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undertale.Maui.Models
{
    internal class BossMonsters
    {
        public string BossName { get; set; }
        public string BossQuote { get; set; }
        public string CharacterImage { get; set; }
        public string Description { get; set; }
        public Color AccentColorStart { get; set; }
        public Color AccentColorEnd { get; set; }
        public List<string> Images { get; set; }
    }
}
