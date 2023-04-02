namespace DMSCPSL
{

    using Exiled.API.Interfaces;
    using System.ComponentModel;
    public class Config : IConfig
    {

        [Description("Whether or not the plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether or not the plugin send tk info to discord webhook.")]
        public bool LogTk {get; set;} = true;
        [Description("Whether or not the plugin send leaving info of scps to discord webhook.")]
        public bool LogSCPLeave {get; set;} = true;
        [Description("Whether or not the plugin send Ban info to discord webhook.")]
        public bool LogBan {get; set;} = true;

        [Description("HookURL")] 
        public string dchook {get; set;} = "HOOk";




        public bool Debug { get; set; }


    }
}
