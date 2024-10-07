using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;

[assembly: ComponentFactory(typeof(RandomSoundFactory))]

namespace LiveSplit.UI.Components;
public class RandomSoundFactory : IComponentFactory
{
    public string ComponentName => "Random Sound Effects";

    public string Description => "Plays random sound effects for different situations.";

    public ComponentCategory Category => ComponentCategory.Media;

    public IComponent Create(LiveSplitState state)
    {
        return new RandomSoundComponent(state);
    }

    public string UpdateName => ComponentName;

    public string XMLURL => "http://livesplit.org/update/Components/update.LiveSplit.RandomSound.xml";

    public string UpdateURL => "http://livesplit.org/update/";

    public Version Version => Version.Parse("1.8.29");
}
