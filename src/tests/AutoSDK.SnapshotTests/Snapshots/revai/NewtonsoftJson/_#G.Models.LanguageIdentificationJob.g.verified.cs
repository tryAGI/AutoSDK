//HintName: G.Models.LanguageIdentificationJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rev.ai Language Identification Job
    /// </summary>
    public sealed partial class LanguageIdentificationJob
    {
        /// <summary>
        /// Job ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Current status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.LanguageIdentificationJobStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_on")]
        public global::System.DateTime? CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_on")]
        public global::System.DateTime? CompletedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_url")]
        public string? MediaUrl { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("failure")]
        public string? Failure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure_detail")]
        public string? FailureDetail { get; set; }

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
        /// Initializes a new instance of the <see cref="LanguageIdentificationJob" /> class.
        /// </summary>
        /// <param name="id">
        /// Job ID
        /// </param>
        /// <param name="status">
        /// Current status
        /// </param>
        /// <param name="type"></param>
        /// <param name="createdOn"></param>
        /// <param name="completedOn"></param>
        /// <param name="mediaUrl"></param>
        /// <param name="metadata"></param>
        /// <param name="callbackUrl"></param>
        /// <param name="failure"></param>
        /// <param name="failureDetail"></param>
        /// <param name="deleteAfterSeconds"></param>
        public LanguageIdentificationJob(
            string? id,
            global::G.LanguageIdentificationJobStatus? status,
            string? type,
            global::System.DateTime? createdOn,
            global::System.DateTime? completedOn,
            string? mediaUrl,
            string? metadata,
            string? callbackUrl,
            string? failure,
            string? failureDetail,
            int? deleteAfterSeconds)
        {
            this.Id = id;
            this.Status = status;
            this.Type = type;
            this.CreatedOn = createdOn;
            this.CompletedOn = completedOn;
            this.MediaUrl = mediaUrl;
            this.Metadata = metadata;
            this.CallbackUrl = callbackUrl;
            this.Failure = failure;
            this.FailureDetail = failureDetail;
            this.DeleteAfterSeconds = deleteAfterSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageIdentificationJob" /> class.
        /// </summary>
        public LanguageIdentificationJob()
        {
        }
    }
}