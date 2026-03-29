//HintName: G.Models.ResponseUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents token usage details including input tokens, output tokens,<br/>
    /// a breakdown of output tokens, and the total tokens used.
    /// </summary>
    public sealed partial class ResponseUsage
    {
        /// <summary>
        /// The number of input tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// A detailed breakdown of the input tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseUsageInputTokensDetails InputTokensDetails { get; set; } = default!;

        /// <summary>
        /// The number of output tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputTokens { get; set; } = default!;

        /// <summary>
        /// A detailed breakdown of the output tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseUsageOutputTokensDetails OutputTokensDetails { get; set; } = default!;

        /// <summary>
        /// The total number of tokens used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of input tokens.
        /// </param>
        /// <param name="inputTokensDetails">
        /// A detailed breakdown of the input tokens.
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens.
        /// </param>
        /// <param name="outputTokensDetails">
        /// A detailed breakdown of the output tokens.
        /// </param>
        /// <param name="totalTokens">
        /// The total number of tokens used.
        /// </param>
        public ResponseUsage(
            int inputTokens,
            global::G.ResponseUsageInputTokensDetails inputTokensDetails,
            int outputTokens,
            global::G.ResponseUsageOutputTokensDetails outputTokensDetails,
            int totalTokens)
        {
            this.InputTokens = inputTokens;
            this.InputTokensDetails = inputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(inputTokensDetails));
            this.OutputTokens = outputTokens;
            this.OutputTokensDetails = outputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(outputTokensDetails));
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsage" /> class.
        /// </summary>
        public ResponseUsage()
        {
        }
    }
}