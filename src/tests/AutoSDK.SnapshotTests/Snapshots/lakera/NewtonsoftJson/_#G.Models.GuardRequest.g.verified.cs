//HintName: G.Models.GuardRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardRequest
    {
        /// <summary>
        /// Array of chat messages to screen. Follows the OpenAI chat format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GuardMessage> Messages { get; set; } = default!;

        /// <summary>
        /// Inline policy configuration that specifies which detectors to run and their thresholds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("policy")]
        public global::G.Policy? Policy { get; set; }

        /// <summary>
        /// If true, returns per-message breakdown in the results.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("breakdown")]
        public bool? Breakdown { get; set; }

        /// <summary>
        /// Optional metadata to attach to this screening request for logging/tracking.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardRequest" /> class.
        /// </summary>
        /// <param name="messages">
        /// Array of chat messages to screen. Follows the OpenAI chat format.
        /// </param>
        /// <param name="policy">
        /// Inline policy configuration that specifies which detectors to run and their thresholds.
        /// </param>
        /// <param name="breakdown">
        /// If true, returns per-message breakdown in the results.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="metadata">
        /// Optional metadata to attach to this screening request for logging/tracking.
        /// </param>
        public GuardRequest(
            global::System.Collections.Generic.IList<global::G.GuardMessage> messages,
            global::G.Policy? policy,
            bool? breakdown,
            object? metadata)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Policy = policy;
            this.Breakdown = breakdown;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardRequest" /> class.
        /// </summary>
        public GuardRequest()
        {
        }
    }
}