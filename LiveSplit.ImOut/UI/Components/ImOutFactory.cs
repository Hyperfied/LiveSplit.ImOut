using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.UI.Components
{
    public class ImOutFactory : IComponentFactory
    {
        public string ComponentName => "I'm Out!";

        public string Description => "Display how quickly in or out Daymond John is with your speedrun.";

        public ComponentCategory Category => ComponentCategory.Media;

        public IComponent Create(LiveSplitState state) => new ImOutComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => UpdateURL + "";

        public string UpdateURL => "";

        public Version Version => Version.Parse("1.0.0");
    }
}
