//HintName: G.Models.UltravoxV1FirstSpeakerSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings for the initial message to get a conversation started.<br/>
    ///  Exactly one of user or agent should be set. The default is agent<br/>
    ///  (unless firstSpeaker is also set, in which case the default will<br/>
    ///  match that).
    /// </summary>
    public sealed partial class UltravoxV1FirstSpeakerSettings
    {
        /// <summary>
        /// If set, the user should speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.UltravoxV1FirstSpeakerSettingsUserGreeting? User { get; set; }

        /// <summary>
        /// If set, the agent should speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::G.UltravoxV1FirstSpeakerSettingsAgentGreeting? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FirstSpeakerSettings" /> class.
        /// </summary>
        /// <param name="user">
        /// If set, the user should speak first.
        /// </param>
        /// <param name="agent">
        /// If set, the agent should speak first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1FirstSpeakerSettings(
            global::G.UltravoxV1FirstSpeakerSettingsUserGreeting? user,
            global::G.UltravoxV1FirstSpeakerSettingsAgentGreeting? agent)
        {
            this.User = user;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FirstSpeakerSettings" /> class.
        /// </summary>
        public UltravoxV1FirstSpeakerSettings()
        {
        }
    }
}