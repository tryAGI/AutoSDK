//HintName: G.Models.UltravoxV1FirstSpeakerSettingsUserGreeting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional properties for when the user speaks first.
    /// </summary>
    public sealed partial class UltravoxV1FirstSpeakerSettingsUserGreeting
    {
        /// <summary>
        /// If set, the agent will start the conversation itself if the user doesn't start<br/>
        ///  speaking within the given delay.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallback")]
        public global::G.UltravoxV1FallbackAgentGreeting? Fallback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FirstSpeakerSettingsUserGreeting" /> class.
        /// </summary>
        /// <param name="fallback">
        /// If set, the agent will start the conversation itself if the user doesn't start<br/>
        ///  speaking within the given delay.
        /// </param>
        public UltravoxV1FirstSpeakerSettingsUserGreeting(
            global::G.UltravoxV1FallbackAgentGreeting? fallback)
        {
            this.Fallback = fallback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FirstSpeakerSettingsUserGreeting" /> class.
        /// </summary>
        public UltravoxV1FirstSpeakerSettingsUserGreeting()
        {
        }
    }
}