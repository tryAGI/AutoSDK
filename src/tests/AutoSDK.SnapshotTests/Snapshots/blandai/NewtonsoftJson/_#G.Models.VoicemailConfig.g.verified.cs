//HintName: G.Models.VoicemailConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicemailConfig
    {
        /// <summary>
        /// Voicemail message to leave
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Action to take on voicemail detection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action")]
        public global::G.VoicemailConfigAction? Action { get; set; }

        /// <summary>
        /// Optional SMS message to send
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sms")]
        public string? Sms { get; set; }

        /// <summary>
        /// Mark message as containing sensitive content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sensitive")]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailConfig" /> class.
        /// </summary>
        /// <param name="message">
        /// Voicemail message to leave
        /// </param>
        /// <param name="action">
        /// Action to take on voicemail detection
        /// </param>
        /// <param name="sms">
        /// Optional SMS message to send
        /// </param>
        /// <param name="sensitive">
        /// Mark message as containing sensitive content
        /// </param>
        public VoicemailConfig(
            string? message,
            global::G.VoicemailConfigAction? action,
            string? sms,
            bool? sensitive)
        {
            this.Message = message;
            this.Action = action;
            this.Sms = sms;
            this.Sensitive = sensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicemailConfig" /> class.
        /// </summary>
        public VoicemailConfig()
        {
        }
    }
}