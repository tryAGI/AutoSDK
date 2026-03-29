//HintName: G.Models.SubmitLanguageIdentificationJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitLanguageIdentificationJobRequest
    {
        /// <summary>
        /// Direct download URL for the audio file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_url")]
        public string? MediaUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_after_seconds")]
        public int? DeleteAfterSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitLanguageIdentificationJobRequest" /> class.
        /// </summary>
        /// <param name="mediaUrl">
        /// Direct download URL for the audio file
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="deleteAfterSeconds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitLanguageIdentificationJobRequest(
            string? mediaUrl,
            string? metadata,
            string? callbackUrl,
            int? deleteAfterSeconds)
        {
            this.MediaUrl = mediaUrl;
            this.Metadata = metadata;
            this.CallbackUrl = callbackUrl;
            this.DeleteAfterSeconds = deleteAfterSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitLanguageIdentificationJobRequest" /> class.
        /// </summary>
        public SubmitLanguageIdentificationJobRequest()
        {
        }
    }
}