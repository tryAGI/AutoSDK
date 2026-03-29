//HintName: G.Models.ListingStatusDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListingStatusDetails
    {
        /// <summary>
        /// Status of the listing process<br/>
        /// Default Value: pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ListingStatusDetailsStatusJsonConverter))]
        public global::G.ListingStatusDetailsStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_at")]
        public global::System.DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// The job record ID associated with this status, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_record_id")]
        public string? JobRecordId { get; set; }

        /// <summary>
        /// Error message for the latest job attempt, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListingStatusDetails" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the listing process<br/>
        /// Default Value: pending
        /// </param>
        /// <param name="effectiveAt"></param>
        /// <param name="jobRecordId">
        /// The job record ID associated with this status, if any.
        /// </param>
        /// <param name="errorMessage">
        /// Error message for the latest job attempt, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListingStatusDetails(
            global::G.ListingStatusDetailsStatus? status,
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
        /// Initializes a new instance of the <see cref="ListingStatusDetails" /> class.
        /// </summary>
        public ListingStatusDetails()
        {
        }
    }
}