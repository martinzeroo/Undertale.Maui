using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undertale.Maui.Models;


namespace Undertale.Maui.Services
{
    internal class BossMonsterServices
    {
        private static List<BossMonsters> bossmonsters = new()
        {
            new()
            {
                BossName = "Sans",
                BossQuote = "i'm sans.sans the skeleton.",
                CharacterImage = "Sans.png",
                Description = "The easiest enemy. Can only deal 1 damage.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
                Images = new()
                {
                  "https://img.joomcdn.net/27c3a014ebdaa2fa334f077c79336650dd4fe550_original.jpeg"
                }
            },

            new()
            {
                BossName = "Papyrus",
                BossQuote = "I WILL BE THE ONE! I MUST BE THE ONE! I WILL CAPTURE A HUMAN! THEN, I, THE GREAT PAPYRUS... WILL GET ALL THE THINGS I UTTERLY DESERVE!",
                CharacterImage = "Papyrus.png",
                Description = "He likes to say: Nyeh heh heh!",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
                Images = new()
                {
                    "https://img.joomcdn.net/f10ed7ac9b40d815dc9880a36621131e5cfd13f0_original.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"
                }
            },

            new()
            {
                BossName = "Undyne",
                BossQuote = "SCREW IT! WHY SHOULD I TELL THAT STORY WHEN YOU'RE ABOUT TO DIE!?! NGAAAAAHHHHHHHHHHHHHHHH!",
                CharacterImage = "Undyne.png",
                Description = "The heroine that NEVER gives up.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/debatesjungle/images/a/a0/Undyne.png/revision/latest/scale-to-width-down/400?cb=20181213233656"
                }
            },

            new()
            {
                BossName = "Asgore",
                BossQuote = "Human... It was nice to meet you. Goodbye.",
                CharacterImage = "Asgore.png",
                Description = "The king of the underground.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/p__/images/5/59/Asgore-Dreemurr.png/revision/latest?cb=20180602030516&path-prefix=protagonist"
                }
            },

            new()
            {
                BossName = "Toriel",
                BossQuote = "I am TORIEL, caretaker of the RUINS.",
                CharacterImage = "Toriel.png",
                Description = "Knows best for you.",
                AccentColorStart = Color.FromArgb("#000000"),
                AccentColorEnd = Color.FromArgb("#000000"),
                Images = new()
                {
                    "https://static.wikia.nocookie.net/debatesjungle/images/0/01/Toriel.png/revision/latest?cb=20181214002725"
                }
            },

        };
    }
}
