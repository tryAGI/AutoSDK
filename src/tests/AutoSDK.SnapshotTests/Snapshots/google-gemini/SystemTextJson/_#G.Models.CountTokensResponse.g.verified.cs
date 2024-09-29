//HintName: G.Models.CountTokensResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A response from `CountTokens`. It returns the model's `token_count` for the `prompt`.
    /// </summary>
    public sealed partial class CountTokensResponse
    {
        /// <summary>
        /// The number of tokens that the `model` tokenizes the `prompt` into. Always non-negative.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}