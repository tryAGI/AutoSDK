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
        /// The number of tokens that the `Model` tokenizes the `prompt` into. Always non-negative.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Number of tokens in the cached part of the prompt (the cached content).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedContentTokenCount")]
        public int? CachedContentTokenCount { get; set; }

        /// <summary>
        /// Output only. List of modalities that were processed in the request input.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokensDetails")]
        public global::System.Collections.Generic.IList<global::G.ModalityTokenCount>? PromptTokensDetails { get; set; }

        /// <summary>
        /// Output only. List of modalities that were processed in the cached content.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheTokensDetails")]
        public global::System.Collections.Generic.IList<global::G.ModalityTokenCount>? CacheTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CountTokensResponse" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// The number of tokens that the `Model` tokenizes the `prompt` into. Always non-negative.
        /// </param>
        /// <param name="cachedContentTokenCount">
        /// Number of tokens in the cached part of the prompt (the cached content).
        /// </param>
        /// <param name="promptTokensDetails">
        /// Output only. List of modalities that were processed in the request input.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cacheTokensDetails">
        /// Output only. List of modalities that were processed in the cached content.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CountTokensResponse(
            int? totalTokens,
            int? cachedContentTokenCount,
            global::System.Collections.Generic.IList<global::G.ModalityTokenCount>? promptTokensDetails,
            global::System.Collections.Generic.IList<global::G.ModalityTokenCount>? cacheTokensDetails)
        {
            this.TotalTokens = totalTokens;
            this.CachedContentTokenCount = cachedContentTokenCount;
            this.PromptTokensDetails = promptTokensDetails;
            this.CacheTokensDetails = cacheTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CountTokensResponse" /> class.
        /// </summary>
        public CountTokensResponse()
        {
        }
    }
}