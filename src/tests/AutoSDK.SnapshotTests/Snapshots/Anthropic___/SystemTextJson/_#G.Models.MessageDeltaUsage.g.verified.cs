//HintName: G.Models.MessageDeltaUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Billing and rate-limit usage.<br/>
    /// Anthropic's API bills and rate-limits by token counts, as tokens represent the<br/>
    /// underlying cost to our systems.<br/>
    /// Under the hood, the API transforms requests into a format suitable for the<br/>
    /// model. The model's output then goes through a parsing stage before becoming an<br/>
    /// API response. As a result, the token counts in `usage` will not match one-to-one<br/>
    /// with the exact visible content of an API request or response.<br/>
    /// For example, `output_tokens` will be non-zero, even for an empty string response<br/>
    /// from Claude.
    /// </summary>
    public sealed partial class MessageDeltaUsage
    {
        /// <summary>
        /// The cumulative number of output tokens which were used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaUsage" /> class.
        /// </summary>
        /// <param name="outputTokens">
        /// The cumulative number of output tokens which were used.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageDeltaUsage(
            int outputTokens)
        {
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaUsage" /> class.
        /// </summary>
        public MessageDeltaUsage()
        {
        }
    }
}