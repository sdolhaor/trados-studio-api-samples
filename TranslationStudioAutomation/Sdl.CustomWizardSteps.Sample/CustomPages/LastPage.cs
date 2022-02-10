using Sdl.TranslationStudioAutomation.IntegrationApi.Wizard;
using System;
using System.Drawing;

namespace Sdl.CustomWizardSteps.Sample.CustomPages
{
    public class LastPage : AbstractWizardPage
    {
        public override string Id => "LastPage";

        public override string Title => "Last page";

        public override string Description => "Last page description";

        public override Icon Icon => PluginResources.LastIcon;

        public override string HelpId => null;

        public override Type ViewType => typeof(LastPageView);

        public override void SetSharedData(IWizardData data)
        {
            //TODO: Implement.
        }
    }
}
