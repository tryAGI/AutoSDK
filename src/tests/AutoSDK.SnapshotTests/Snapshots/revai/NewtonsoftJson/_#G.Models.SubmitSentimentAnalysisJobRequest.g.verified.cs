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
        [global::Newtonsoft.Json.JsonProperty("json")]
        public global::G.Transcript? Json { get; set; }

        /// <summary>
        /// Plain text to analyze for sentiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Optional metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Optional callback URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Language of the input text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Auto-delete job after this many seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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