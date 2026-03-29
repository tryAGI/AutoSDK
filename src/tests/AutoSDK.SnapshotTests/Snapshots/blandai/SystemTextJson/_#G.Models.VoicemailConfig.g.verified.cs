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
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Action to take on voicemail detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoicemailConfigActionJsonConverter))]
        public global::G.VoicemailConfigAction? Action { get; set; }

        /// <summary>
        /// Optional SMS message to send
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sms")]
        public string? Sms { get; set; }

        /// <summary>
        /// Mark message as containing sensitive content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensitive")]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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