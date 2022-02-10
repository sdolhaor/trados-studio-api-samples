using Sdl.TranslationStudioAutomation.IntegrationApi.Wizard;
using System;
using System.Drawing;

namespace Sdl.CustomWizardSteps.Sample.CustomPages
{
    public class FirstPage : AbstractWizardPage
    {
        public override string Id => "FirstPage";

        public override string Title => "First page";

        public override string Description => "First page description";

        public override Icon Icon => PluginResources.FirstIcon;

        public override string HelpId => null;

        public override Type ViewType => typeof(FirstPageView);

        public override void SetSharedData(IWizardData data)
        {
            //TODO: Implement.
        }
    }
}
