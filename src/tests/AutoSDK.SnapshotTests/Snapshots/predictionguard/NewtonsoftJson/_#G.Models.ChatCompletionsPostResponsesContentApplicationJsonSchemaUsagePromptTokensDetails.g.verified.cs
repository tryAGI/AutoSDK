//HintName: G.Models.ChatCompletionsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Further information about the amount of tokens used in the request prompt.
    /// </summary>
    public sealed partial class ChatCompletionsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails
    {
        /// <summary>
        /// The amount of audio tokens from any input audio files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// The amount of cached tokens used in the request prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails" /> class.
        /// </summary>
        /// <param name="audioTokens">
        /// The amount of audio tokens from any input audio files.
        /// </param>
        /// <param name="cachedTokens">
        /// The amount of cached tokens used in the request prompt.
        /// </param>
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails(
            int? audioTokens,
            int? cachedTokens)
        {
            this.AudioTokens = audioTokens;
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails" /> class.
        /// </summary>
        public ChatCompletionsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails()
        {
        }
    }
}