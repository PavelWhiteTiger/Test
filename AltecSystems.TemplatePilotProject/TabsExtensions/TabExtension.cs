using System;
using System.ComponentModel.Composition;
using AltecSystems.TemplatePilotProject.Services;
using Ascon.Pilot.SDK.Tabs;
using NLog;

namespace AltecSystems.TemplatePilotProject.TabsExtensions
{
    [Export(typeof(ITabsExtension<DocumentExplorerDetailsTabsContext>))]
    internal class TabExtension : ITabsExtension<DocumentExplorerDetailsTabsContext>
    {
        private readonly ILogger _loggerProvider;

        public TabExtension(ILoggerProvider loggerProvider)
        {
            _loggerProvider = loggerProvider.GetLogger<TabExtension>();
        }

        public void BuildTabs(ITabsBuilder builder, DocumentExplorerDetailsTabsContext context)
        {

        }

        public void OnIsActiveChanged(Guid tabId, bool isActive)
        {
            switch (tabId)
            {
                // logic ... 
            }
        }

        public void OnDisposed(Guid tabId)
        {
        }
    }
}