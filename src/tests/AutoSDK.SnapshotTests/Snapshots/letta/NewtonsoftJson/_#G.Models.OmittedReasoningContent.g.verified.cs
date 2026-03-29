//HintName: G.Models.OmittedReasoningContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A placeholder for reasoning content we know is present, but isn't returned by the provider (e.g. OpenAI GPT-5 on ChatCompletions)
    /// </summary>
    public sealed partial class OmittedReasoningContent
    {
        /// <summary>
        /// Indicates this is an omitted reasoning step.<br/>
        /// Default Value: omitted_reasoning
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A unique identifier for this reasoning step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OmittedReasoningContent" /> class.
        /// </summary>
        /// <param name="type">
        /// Indicates this is an omitted reasoning step.<br/>
        /// Default Value: omitted_reasoning
        /// </param>
        /// <param name="signature">
        /// A unique identifier for this reasoning step.
        /// </param>
        public OmittedReasoningContent(
            string? type,
            string? signature)
        {
            this.Type = type;
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmittedReasoningContent" /> class.
        /// </summary>
        public OmittedReasoningContent()
        {
        }
    }
}