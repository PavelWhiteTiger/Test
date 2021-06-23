using System.ComponentModel.Composition;
using AltecSystems.TemplatePilotProject.Services;
using Ascon.Pilot.SDK;
using NLog;

namespace AltecSystems.TemplatePilotProject.TabsPage
{
    [Export(typeof(INewTabPage))]
    internal class Tab : INewTabPage
    {
        private readonly ILogger _loggerProvider;


        [ImportingConstructor]
        public Tab(ILoggerProvider loggerProvider)
        {
            _loggerProvider = loggerProvider.GetLogger<Tab>();
        }

        public void BuildNewTabPage(INewTabPageHost host)
        {

        }

        public void OnButtonClick(string name)
        {
            switch (name)
            {
                // logic ... 
            }
        }
    }
}