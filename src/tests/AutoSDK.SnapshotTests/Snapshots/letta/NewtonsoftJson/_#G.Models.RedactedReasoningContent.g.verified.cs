//HintName: G.Models.RedactedReasoningContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sent via the Anthropic Messages API
    /// </summary>
    public sealed partial class RedactedReasoningContent
    {
        /// <summary>
        /// Indicates this is a redacted thinking step.<br/>
        /// Default Value: redacted_reasoning
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The redacted or filtered intermediate reasoning content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedReasoningContent" /> class.
        /// </summary>
        /// <param name="data">
        /// The redacted or filtered intermediate reasoning content.
        /// </param>
        /// <param name="type">
        /// Indicates this is a redacted thinking step.<br/>
        /// Default Value: redacted_reasoning
        /// </param>
        public RedactedReasoningContent(
            string data,
            string? type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RedactedReasoningContent" /> class.
        /// </summary>
        public RedactedReasoningContent()
        {
        }
    }
}