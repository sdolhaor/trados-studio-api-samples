using Sdl.CustomWizardSteps.Sample.CustomPages;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Interfaces;
using Sdl.TranslationStudioAutomation.IntegrationApi.Actions;
using Sdl.TranslationStudioAutomation.IntegrationApi.Events;
using Sdl.TranslationStudioAutomation.IntegrationApi.Wizard;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sdl.PackagesOperations.Sample
{
    public partial class PackagesControl : UserControl, IUIControl
    {
        private readonly AbstractApplication _app;
        private readonly IStudioEventAggregator _eventAggregator;

        public PackagesControl()
        {
            InitializeComponent();
            _app = new StudioApplication();
            _eventAggregator = _app.GetService<IStudioEventAggregator>();
        }

        private void openPackage(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.File.Exists(textBoxPackagePath.Text))
                {
                    var initialWizardSteps = new List<AbstractWizardPage> { new FirstPage(), new SecondPage(), new ThirdPage() };
                    var finalWizardSteps = new List<AbstractWizardPage> { new SecondToLastPage(), new LastPage() };

                    _eventAggregator.Publish(
                        new OpenProjectPackageEvent(
                            textBoxPackagePath.Text, job: null, iconPath: null, projectOrigin: null, 
                            firstPages: initialWizardSteps, lastPages: finalWizardSteps));
                    return;
                }
                _app.ExecuteAction<OpenPackageAction>();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ButtonBrowsePackagePath_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                Title = "Browse for package",
                DefaultExt = "ico",
                Filter = "SDL Trados Studio packages (*.sdlppx;*.sdlrpx,)|*.sdlppx;*.sdlrpx"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPackagePath.Text = fileDialog.FileName;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxPackagePath.Clear();
        }
    }
}
