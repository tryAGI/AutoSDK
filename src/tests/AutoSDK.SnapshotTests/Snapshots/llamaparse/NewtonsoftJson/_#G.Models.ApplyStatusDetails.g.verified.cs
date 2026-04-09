//HintName: G.Models.ApplyStatusDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApplyStatusDetails
    {
        /// <summary>
        /// Status of the apply process (file updates and deletions)<br/>
        /// Default Value: pending
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApplyStatusDetailsStatusJsonConverter))]
        public global::G.ApplyStatusDetailsStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effective_at")]
        public global::System.DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// The job record ID associated with this status, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_record_id")]
        public string? JobRecordId { get; set; }

        /// <summary>
        /// Error message for the latest job attempt, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyStatusDetails" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the apply process (file updates and deletions)<br/>
        /// Default Value: pending
        /// </param>
        /// <param name="effectiveAt"></param>
        /// <param name="jobRecordId">
        /// The job record ID associated with this status, if any.
        /// </param>
        /// <param name="errorMessage">
        /// Error message for the latest job attempt, if any.
        /// </param>
        public ApplyStatusDetails(
            global::G.ApplyStatusDetailsStatus? status,
            global::System.DateTime? effectiveAt,
            string? jobRecordId,
            string? errorMessage)
        {
            this.Status = status;
            this.EffectiveAt = effectiveAt;
            this.JobRecordId = jobRecordId;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyStatusDetails" /> class.
        /// </summary>
        public ApplyStatusDetails()
        {
        }
    }
}