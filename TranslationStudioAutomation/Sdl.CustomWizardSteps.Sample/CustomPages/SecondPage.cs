using Sdl.TranslationStudioAutomation.IntegrationApi.Wizard;
using System;
using System.Drawing;

namespace Sdl.CustomWizardSteps.Sample.CustomPages
{
    public class SecondPage : AbstractWizardPage
    {
        public override string Id => "SecondPage";

        public override string Title => "Second page";

        public override string Description => "Second page description";

        public override Icon Icon => PluginResources.SecondIcon;

        public override string HelpId => null;

        public override Type ViewType => typeof(SecondPageView);

        public override void SetSharedData(IWizardData data)
        {
            //TODO: Implement.
        }
    }
}
