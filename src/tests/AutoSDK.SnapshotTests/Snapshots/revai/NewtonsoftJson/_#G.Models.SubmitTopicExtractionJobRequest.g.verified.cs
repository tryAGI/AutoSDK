//HintName: G.Models.SubmitTopicExtractionJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitTopicExtractionJobRequest
    {
        /// <summary>
        /// Rev.ai Transcript
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json")]
        public global::G.Transcript? Json { get; set; }

        /// <summary>
        /// Plain text to extract topics from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitTopicExtractionJobRequest" /> class.
        /// </summary>
        /// <param name="json">
        /// Rev.ai Transcript
        /// </param>
        /// <param name="text">
        /// Plain text to extract topics from
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="language"></param>
        /// <param name="deleteAfterSeconds"></param>
        public SubmitTopicExtractionJobRequest(
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
        /// Initializes a new instance of the <see cref="SubmitTopicExtractionJobRequest" /> class.
        /// </summary>
        public SubmitTopicExtractionJobRequest()
        {
        }
    }
}