//HintName: G.Models.TopProviderInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about the top provider for this model
    /// </summary>
    public sealed partial class TopProviderInfo
    {
        /// <summary>
        /// Context length from the top provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        public double? ContextLength { get; set; }

        /// <summary>
        /// Maximum completion tokens from the top provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public double? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Whether the top provider moderates content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_moderated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsModerated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopProviderInfo" /> class.
        /// </summary>
        /// <param name="isModerated">
        /// Whether the top provider moderates content
        /// </param>
        /// <param name="contextLength">
        /// Context length from the top provider
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum completion tokens from the top provider
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopProviderInfo(
            bool isModerated,
            double? contextLength,
            double? maxCompletionTokens)
        {
            this.ContextLength = contextLength;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.IsModerated = isModerated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopProviderInfo" /> class.
        /// </summary>
        public TopProviderInfo()
        {
        }
    }
}