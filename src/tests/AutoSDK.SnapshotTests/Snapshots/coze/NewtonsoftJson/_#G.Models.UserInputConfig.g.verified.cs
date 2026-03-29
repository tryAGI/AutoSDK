//HintName: G.Models.UserInputConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserInputConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_input_mode")]
        public int? DefaultInputMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("send_voice_mode")]
        public int? SendVoiceMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInputConfig" /> class.
        /// </summary>
        /// <param name="defaultInputMode"></param>
        /// <param name="sendVoiceMode"></param>
        public UserInputConfig(
            int? defaultInputMode,
            int? sendVoiceMode)
        {
            this.DefaultInputMode = defaultInputMode;
            this.SendVoiceMode = sendVoiceMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInputConfig" /> class.
        /// </summary>
        public UserInputConfig()
        {
        }
    }
}