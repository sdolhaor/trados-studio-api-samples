using Sdl.TranslationStudioAutomation.IntegrationApi.Wizard;
using System;
using System.Drawing;

namespace Sdl.CustomWizardSteps.Sample.CustomPages
{
    public class SecondToLastPage : AbstractWizardPage
    {
        public override string Id => "SecondToLastPage";

        public override string Title => "Second-to-last page";

        public override string Description => "Second-to-last page description";

        public override Icon Icon => PluginResources.SecondToLastIcon;

        public override string HelpId => null;

        public override Type ViewType => typeof(SecondToLastPageView);

        public override void SetSharedData(IWizardData data)
        {
            //TODO: Implement.
        }
    }
}
