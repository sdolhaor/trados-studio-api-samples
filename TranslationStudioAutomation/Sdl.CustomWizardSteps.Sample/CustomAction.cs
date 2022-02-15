using Sdl.CustomWizardSteps.Sample.CustomPages;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.Desktop.IntegrationApi.Interfaces;
using Sdl.TranslationStudioAutomation.IntegrationApi.Actions;
using Sdl.TranslationStudioAutomation.IntegrationApi.Events;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation.DefaultLocations;
using Sdl.TranslationStudioAutomation.IntegrationApi.Wizard;
using System;
using System.Collections.Generic;
using System.Windows;

namespace Sdl.PackagesOperations.Sample
{
    [Action(
        Id = "CustomAction",
        Name = "Custom Open Package",
        Description = "Starts the customized open package wizard",
        Icon = "CustomActionIcon"
    )]
    [ActionLayout(typeof(MySampleRibbonGroup), 10, DisplayType.Large)]
    public class MyCustomAction : AbstractAction
    {
        private readonly AbstractApplication _app;
        private readonly IStudioEventAggregator _eventAggregator;

        public MyCustomAction()
        {
            _app = new StudioApplication();
            _eventAggregator = _app.GetService<IStudioEventAggregator>();
        }

        protected override void Execute()
        {
            try
            {
                var initialWizardSteps = new List<AbstractWizardPage> { new FirstPage(), new SecondPage(), new ThirdPage() };
                var finalWizardSteps = new List<AbstractWizardPage> { new SecondToLastPage(), new LastPage() };

                _eventAggregator.Publish(
                    new OpenProjectPackageEvent(
                        packageFilePath: null, job: null, iconPath: null, projectOrigin: null,
                        firstPages: initialWizardSteps, lastPages: finalWizardSteps));
                _app.ExecuteAction<OpenPackageAction>();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }

    [RibbonGroup("MySampleRibbonGroup")]
    [RibbonGroupLayout(LocationByType = typeof(TranslationStudioDefaultRibbonTabs.HomeRibbonTabLocation))]
    class MySampleRibbonGroup : AbstractRibbonGroup
    {
    }
}
