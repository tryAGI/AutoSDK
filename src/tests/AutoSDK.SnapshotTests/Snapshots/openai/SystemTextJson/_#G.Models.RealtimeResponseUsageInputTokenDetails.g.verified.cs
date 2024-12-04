//HintName: G.Models.RealtimeResponseUsageInputTokenDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details about the input tokens used in the Response.
    /// </summary>
    public sealed partial class RealtimeResponseUsageInputTokenDetails
    {
        /// <summary>
        /// The number of cached tokens used in the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// The number of text tokens used in the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        public int? TextTokens { get; set; }

        /// <summary>
        /// The number of audio tokens used in the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsageInputTokenDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// The number of cached tokens used in the Response.
        /// </param>
        /// <param name="textTokens">
        /// The number of text tokens used in the Response.
        /// </param>
        /// <param name="audioTokens">
        /// The number of audio tokens used in the Response.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeResponseUsageInputTokenDetails(
            int? cachedTokens,
            int? textTokens,
            int? audioTokens)
        {
            this.CachedTokens = cachedTokens;
            this.TextTokens = textTokens;
            this.AudioTokens = audioTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsageInputTokenDetails" /> class.
        /// </summary>
        public RealtimeResponseUsageInputTokenDetails()
        {
        }
    }
}