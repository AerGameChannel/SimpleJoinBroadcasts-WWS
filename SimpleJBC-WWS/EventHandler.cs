using WW_SYSTEM.EventHandlers;
using WW_SYSTEM.Events;

namespace SimpleJBC
{
    public class EventHandler : IEventHandlerPlayerJoin
    {
        public SimpleJBC plugin;
        public EventHandler(SimpleJBC plugin)
        {
            this.plugin = plugin;
        }
        public void OnPlayerJoin(PlayerJoinEvent ev)
        {
            ev.Player.PersonalBroadcast(SimpleJBC.bcmsg, SimpleJBC.bctime, false);
        }
    }
}