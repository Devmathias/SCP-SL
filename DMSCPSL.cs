namespace DMSCPSL
{
    using Exiled;
    using exiledEvents = Exiled.Events;
    using eArgs = Exiled.Events.EventArgs;
    using API = Exiled.API.Features;
    using eHand = Exiled.Events.Handlers;
    using System;
    using Exiled.Events.EventArgs.Player;
    using System.Collections.Generic;
    using System.Net;

    public class Plugin : API.Plugin<Config>
    {
        // This plugin will now be recognized by the EXILED framework!
        public override void OnEnabled()
        {
            API.Log.Info("My plugin has been enabled!");
            if (Config.LogTk == true)
            {
                eHand.Player.Dying += OnDying;
            }
        }


        private void OnDying(DyingEventArgs ev)
        {
            if (ev.Attacker.LeadingTeam == ev.Player.LeadingTeam)
            {
                hook(ev.Attacker.Nickname +"  Shot  " + ev.Player.Nickname);
            }
        }

        public override void OnDisabled()
        {
            API.Log.Info("My plugin has been disabled!");
            if (Config.LogTk == true)
            {
                eHand.Player.Dying += OnDying;
            }
        }
        public void hook(string mess)
        {
                string webhook = Config.dchook;

                WebClient client = new WebClient();
                client.Headers.Add("Content-Type", "application/json");
                string payload = "{\"content\": \"" + mess + "\"}";
                client.UploadData(webhook, System.Text.Encoding.UTF8.GetBytes(payload));
        }
    }
}

