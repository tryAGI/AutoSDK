//HintName: G.Models.PerRequestLimits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Per-request token limits
    /// </summary>
    public sealed partial class PerRequestLimits
    {
        /// <summary>
        /// Maximum prompt tokens per request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// Maximum completion tokens per request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerRequestLimits" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Maximum prompt tokens per request
        /// </param>
        /// <param name="completionTokens">
        /// Maximum completion tokens per request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PerRequestLimits(
            double promptTokens,
            double completionTokens)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerRequestLimits" /> class.
        /// </summary>
        public PerRequestLimits()
        {
        }
    }
}