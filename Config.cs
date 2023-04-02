namespace DMSCPSL
{

    using Exiled.API.Interfaces;
    using System.ComponentModel;
    public class Config : IConfig
    {

        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether or not the plugin send tkinfo to discord webhook.")]
        public bool LogTk {get; set;} = true;

        [Description("Discord Token")] 
        public string dctoken {get; set;} = "token";




        public bool Debug { get; set; }


    }
}
