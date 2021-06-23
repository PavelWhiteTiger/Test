using System.ComponentModel.Composition;
using AltecSystems.TemplatePilotProject.Services;
using Ascon.Pilot.SDK;
using Ascon.Pilot.SDK.Toolbar;
using NLog;

namespace AltecSystems.TemplatePilotProject.ToolBars
{
    [Export(typeof(IToolbar<ObjectsViewContext>))]
    internal class Toolbar : IToolbar<ObjectsViewContext>
    {
        private readonly ILogger _loggerProvider;

        [ImportingConstructor]
        public Toolbar(ILoggerProvider loggerProvider)
        {
            _loggerProvider = loggerProvider.GetLogger<Toolbar>();
        }

        public void Build(IToolbarBuilder builder, ObjectsViewContext context)
        {

        }

        public void OnToolbarItemClick(string name, ObjectsViewContext context)
        {
            switch (name)
            {
                // logic ... 
            }
        }
    }
}