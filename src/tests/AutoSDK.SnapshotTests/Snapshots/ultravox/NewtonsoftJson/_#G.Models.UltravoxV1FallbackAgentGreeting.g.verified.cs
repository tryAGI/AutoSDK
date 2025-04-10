//HintName: G.Models.UltravoxV1FallbackAgentGreeting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A fallback for the case when the user is expected to speak first but doesn't.
    /// </summary>
    public sealed partial class UltravoxV1FallbackAgentGreeting
    {
        /// <summary>
        /// How long the agent should wait before starting the conversation itself.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delay")]
        public string? Delay { get; set; }

        /// <summary>
        /// What the agent should say. If unset, the model will generate a greeting.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FallbackAgentGreeting" /> class.
        /// </summary>
        /// <param name="delay">
        /// How long the agent should wait before starting the conversation itself.
        /// </param>
        /// <param name="text">
        /// What the agent should say. If unset, the model will generate a greeting.
        /// </param>
        public UltravoxV1FallbackAgentGreeting(
            string? delay,
            string? text)
        {
            this.Delay = delay;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FallbackAgentGreeting" /> class.
        /// </summary>
        public UltravoxV1FallbackAgentGreeting()
        {
        }
    }
}