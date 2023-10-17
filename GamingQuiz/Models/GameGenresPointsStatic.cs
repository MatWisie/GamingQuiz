using System.Collections.Generic;

namespace GamingQuiz.Models
{
    public static class GameGenresPointsStatic
    {
        public static Dictionary<string, (int, string, string)> gameGenresPoints { get; set; } =
            new Dictionary<string, (int, string, string)>()
            {
                {"Action", (0, "You thrive on adrenaline and enjoy fast-paced gameplay, where quick thinking and reflexes are your greatest assets.", "https://staticg.sportskeeda.com/editor/2019/03/cedbb-15534102082658-800.jpg") },
                {"Adventure", (0,"You're a seeker of mystery and love getting lost in rich, narrative-driven environments filled with puzzles and choices.", "https://images.prismic.io/fanatical/0b6ea972-b842-4748-85aa-de780f0b7468_ss_adca43bf058172c358202d6cba1d8671fcd155cf.1920x1080.jpg?auto=compress,format&rect=0,0,1920,1080&w=1280&h=720") },
                {"Fighting", (0,"You have a competitive spirit, seeking one-on-one battles and mastering various combat techniques and special moves.", $"https://www.gamespot.com/a/uploads/screen_kubrick/1601/16018044/4027937-fighting-games.jpg") },
                {"Platformers", (0,"Precision and problem-solving are your strong suits, as you navigate tricky jumps and challenging puzzles in dynamic worlds.", "https://us.v-cdn.net/6036147/uploads/LTSDCAP8RUOH/l-17-5-1200x675.jpg") },
                {"Puzzle", (0,"Your mind is your greatest weapon, and you delight in solving intricate puzzles that require logical thinking and creativity", "https://cdn.nivoli.com/adventuregamers/images/screenshots/16495/8404.jpg") },
                {"Racing", (0,"The need for speed drives you, and you relish the thrill of racing to victory in various vehicles and on diverse tracks", "https://img.redbull.com/images/c_limit,w_1500,h_1000,f_auto,q_auto/redbullcom/2020/6/18/jnhtjx1nozaocxki9ekx/ios-racers-lead-asphalt-9") },
                {"Role-Playing", (0,"You have a vivid imagination and love creating and developing characters, immersing yourself in epic adventures and complex stories.", "https://cdn.mos.cms.futurecdn.net/w844TWsyvV7jNksWB6ma9J.jpg") },
                {"Shooter", (0,"You have a sharp eye and a taste for intense action, preferring games that involve combat, shooting, and strategic thinking.", "https://i.ytimg.com/vi/nE4jIOUAYBQ/maxresdefault.jpg") },
                {"Simulation", (0,"You enjoy stepping into different roles and experiencing life in a virtual world, managing resources, and making impactful decisions.", "https://i.pcmag.com/imagery/roundups/05jeQF8mdJPdJduVAxQDIGb-1..v1620155938.jpg") },
                {"Strategy", (0,"You are a master planner and strategist, finding joy in building and managing complex worlds or leading armies to victory through careful planning and tactics.", "https://www.wargamer.com/wp-content/sites/wargamer/2023/06/best-grand-strategy-games-guide-europa-universalis-4-large-world-map.jpg") },
            };
    }
}