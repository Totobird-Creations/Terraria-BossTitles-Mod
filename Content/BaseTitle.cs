using Microsoft.Xna.Framework;
using boss_titles.Util;


namespace boss_titles.Content {
    public abstract class BaseTitle {

        internal bool was_active = false;

        public abstract string    Subtitle {get;}
        public abstract string    Title    {get;}

        public abstract RGBA GetSubtitleColour(GameTime GameTime);
        public abstract RGBA GetTitleColour(GameTime GameTime);

        public abstract bool IsActive();

    }
}