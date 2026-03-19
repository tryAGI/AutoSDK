//HintName: G.Models.UsageDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage statistics for a response.
    /// </summary>
    public sealed partial class UsageDetails
    {
        /// <summary>
        /// The total number of tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// The number of input tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// The number of output tokens used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageDetails" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// The total number of tokens used.
        /// </param>
        /// <param name="inputTokens">
        /// The number of input tokens used.
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageDetails(
            int? totalTokens,
            int? inputTokens,
            int? outputTokens)
        {
            this.TotalTokens = totalTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageDetails" /> class.
        /// </summary>
        public UsageDetails()
        {
        }
    }
}