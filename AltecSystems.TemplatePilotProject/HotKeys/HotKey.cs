using System.ComponentModel.Composition;
using AltecSystems.TemplatePilotProject.Services;
using Ascon.Pilot.SDK;
using Ascon.Pilot.SDK.HotKey;
using NLog;

namespace AltecSystems.TemplatePilotProject.HotKeys
{
    [Export(typeof(IHotKey<ObjectsViewContext>))]
    internal class HotKey : IHotKey<ObjectsViewContext>
    {
        private readonly ILogger _loggerProvider;

        [ImportingConstructor]
        public HotKey(ILoggerProvider loggerProvider)
        {
            _loggerProvider = loggerProvider.GetLogger<HotKey>();
        }

        public void AssignHotKeys(IHotKeyCollection hotKeyCollection)
        {

        }

        public void OnHotKeyPressed(string commandId, ObjectsViewContext context)
        {
            switch (commandId)
            {
                // logic ... 
            }
        }
    }
}