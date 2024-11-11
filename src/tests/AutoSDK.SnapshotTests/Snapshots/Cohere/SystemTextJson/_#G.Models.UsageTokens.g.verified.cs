//HintName: G.Models.UsageTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageTokens
    {
        /// <summary>
        /// The number of tokens used as input to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public double? InputTokens { get; set; }

        /// <summary>
        /// The number of tokens produced by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public double? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTokens" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of tokens used as input to the model.
        /// </param>
        /// <param name="outputTokens">
        /// The number of tokens produced by the model.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UsageTokens(
            double? inputTokens,
            double? outputTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTokens" /> class.
        /// </summary>
        public UsageTokens()
        {
        }
    }
}