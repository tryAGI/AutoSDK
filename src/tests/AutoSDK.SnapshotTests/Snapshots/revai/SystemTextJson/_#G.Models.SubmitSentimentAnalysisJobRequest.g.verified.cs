//HintName: G.Models.SubmitSentimentAnalysisJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitSentimentAnalysisJobRequest
    {
        /// <summary>
        /// Rev.ai Transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json")]
        public global::G.Transcript? Json { get; set; }

        /// <summary>
        /// Plain text to analyze for sentiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Optional metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Optional callback URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Language of the input text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Auto-delete job after this many seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitSentimentAnalysisJobRequest" /> class.
        /// </summary>
        /// <param name="json">
        /// Rev.ai Transcript
        /// </param>
        /// <param name="text">
        /// Plain text to analyze for sentiment
        /// </param>
        /// <param name="metadata">
        /// Optional metadata
        /// </param>
        /// <param name="callbackUrl">
        /// Optional callback URL
        /// </param>
        /// <param name="language">
        /// Language of the input text
        /// </param>
        /// <param name="deleteAfterSeconds">
        /// Auto-delete job after this many seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitSentimentAnalysisJobRequest(
            global::G.Transcript? json,
            string? text,
            string? metadata,
            string? callbackUrl,
            string? language,
            int? deleteAfterSeconds)
        {
            this.Json = json;
            this.Text = text;
            this.Metadata = metadata;
            this.CallbackUrl = callbackUrl;
            this.Language = language;
            this.DeleteAfterSeconds = deleteAfterSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitSentimentAnalysisJobRequest" /> class.
        /// </summary>
        public SubmitSentimentAnalysisJobRequest()
        {
        }
    }
}