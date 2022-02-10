using Sdl.TranslationStudioAutomation.IntegrationApi.Wizard;
using System;
using System.Drawing;

namespace Sdl.CustomWizardSteps.Sample.CustomPages
{
    public class ThirdPage : AbstractWizardPage
    {
        public override string Id => "ThirdPage";

        public override string Title => "Third page";

        public override string Description => "Third page description";

        public override Icon Icon => PluginResources.ThirdIcon;

        public override string HelpId => null;

        public override Type ViewType => typeof(ThirdPageView);

        public override void SetSharedData(IWizardData data)
        {
            //TODO: Implement.
        }
    }
}
