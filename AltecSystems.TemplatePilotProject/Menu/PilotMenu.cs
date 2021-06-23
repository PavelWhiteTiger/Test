using System.ComponentModel.Composition;
using AltecSystems.TemplatePilotProject.Services;
using Ascon.Pilot.SDK;
using Ascon.Pilot.SDK.Menu;
using NLog;

namespace AltecSystems.TemplatePilotProject.Menu
{
    [Export(typeof(IMenu<ObjectsViewContext>))]
    internal class PilotMenu : IMenu<ObjectsViewContext>
    {
        private readonly ILogger _loggerProvider;

        [ImportingConstructor]
        public PilotMenu(ILoggerProvider loggerProvider)
        {
            _loggerProvider = loggerProvider.GetLogger<PilotMenu>();
        }

        public void Build(IMenuBuilder builder, ObjectsViewContext context)
        {
        }

        public void OnMenuItemClick(string name, ObjectsViewContext context)
        {
            switch (name)
            {
                // logic ... 
            }
        }
    }
}