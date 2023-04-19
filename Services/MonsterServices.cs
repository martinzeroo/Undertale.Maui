using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undertale.Maui.Models;

namespace Undertale.Maui.Services
{
    internal class MonsterServices
    {
        public static List<Monsters> monsters = new()
        {
            new()
            {
                Name = "Froggit",
                Quote = "Ribbit, ribbit.",
                CharacterImage = "Froggit.png",
                Description = "Life is difficult for this enemy.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
                Images = new()
                {
                    "https://art.pixilart.com/07ac2ccbd10ccf1.png"
                }
            },

            new()
            {
               Name = "Whimsun",
                Quote = "Forgive me...",
                CharacterImage = "Whimsun.png",
                Description = "This monster is too sensitive to fight...",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/topstrongest/images/c/c4/Whimsalot_Sprite.png/revision/latest?cb=20210909180226"
                }
            },

            new()
            {
                Name = "Moldsmal",
                Quote = "*Sexy wiggle*",
                CharacterImage = "Moldsmal.png",
                Description = "Stereotypical: Curvaceously attractive, but no brains...",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/deltatraveler/images/f/f6/Moldsmal.png/revision/latest?cb=20230107010958"
                }
            },

            new()
            {
               Name = "Loox",
                Quote = "Please don't pick on me...",
                CharacterImage = "Loox.png",
                Description = "Don't pick on him. Family name: Eyewalker.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/topstrongest/images/d/d6/Loox_Sprite.png/revision/latest?cb=20210909095051"
                }
            },

            new()
            {
               Name = "Vegetoid",
                Quote = "Farmed Locally, Very Locally",
                CharacterImage = "Vegetoid.png",
                Description = "Serving Size: 1 Monster. Not monitored by the USDA.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/undertale/images/4/48/Vegetoid_artwork_Squashy.png/revision/latest?cb=20210319063914"
                }
            },

        };

    }
}
