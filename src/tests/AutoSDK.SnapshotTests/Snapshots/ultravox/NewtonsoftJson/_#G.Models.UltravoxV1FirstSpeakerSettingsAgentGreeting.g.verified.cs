//HintName: G.Models.UltravoxV1FirstSpeakerSettingsAgentGreeting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional properties for when the agent speaks first.
    /// </summary>
    public sealed partial class UltravoxV1FirstSpeakerSettingsAgentGreeting
    {
        /// <summary>
        /// Whether the user should be prevented from interrupting the agent's first message.<br/>
        ///  Defaults to false (meaning the agent is interruptible as usual).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uninterruptible")]
        public bool? Uninterruptible { get; set; }

        /// <summary>
        /// What the agent should say. If unset, the model will generate a greeting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// If set, the agent will wait this long before starting its greeting. This may be useful<br/>
        ///  for ensuring the user is ready.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delay")]
        public string? Delay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FirstSpeakerSettingsAgentGreeting" /> class.
        /// </summary>
        /// <param name="uninterruptible">
        /// Whether the user should be prevented from interrupting the agent's first message.<br/>
        ///  Defaults to false (meaning the agent is interruptible as usual).
        /// </param>
        /// <param name="text">
        /// What the agent should say. If unset, the model will generate a greeting.
        /// </param>
        /// <param name="delay">
        /// If set, the agent will wait this long before starting its greeting. This may be useful<br/>
        ///  for ensuring the user is ready.
        /// </param>
        public UltravoxV1FirstSpeakerSettingsAgentGreeting(
            bool? uninterruptible,
            string? text,
            string? delay)
        {
            this.Uninterruptible = uninterruptible;
            this.Text = text;
            this.Delay = delay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FirstSpeakerSettingsAgentGreeting" /> class.
        /// </summary>
        public UltravoxV1FirstSpeakerSettingsAgentGreeting()
        {
        }
    }
}