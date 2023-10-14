using System.Collections.Generic;

namespace GamingQuiz.Models
{
    public static class GameGenresPointsStatic
    {
        public static Dictionary<string, (int, string)> gameGenresPoints { get; set; } =
            new Dictionary<string, (int, string)>()
            {
                {"Strategy", (0, "You love thinking etc") },
                {"First Person Shooters", (0,"You love shooting etc") },
                {"Simulators", (0,"You love working in gaming wow etc") },
                {"RPG", (0,"You love fantasy") }
            };
    }
}
