using System.Collections.Generic;

namespace GamingQuiz.Models
{
    public static class GameGenresPointsStatic
    {
        public static Dictionary<string, int> gameGenresPoints { get; set; } =
            new Dictionary<string, int>()
            {
                {"Strategy", 0 },
                {"First Person Shooters", 0 },
                {"Simulators", 0 }
            };
    }
}
