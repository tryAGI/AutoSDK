//HintName: G.Models.ManagedIngestionStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManagedIngestionStatusResponse
    {
        /// <summary>
        /// ID of the latest job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public global::System.Guid? JobId { get; set; }

        /// <summary>
        /// Date of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_date")]
        public global::System.DateTime? DeploymentDate { get; set; }

        /// <summary>
        /// Status of the ingestion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ManagedIngestionStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ManagedIngestionStatus Status { get; set; }

        /// <summary>
        /// List of errors that occurred during ingestion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::System.Collections.Generic.IList<global::G.IngestionErrorResponse>? Error { get; set; }

        /// <summary>
        /// When the status is effective
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_at")]
        public global::System.DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedIngestionStatusResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Status of the ingestion.
        /// </param>
        /// <param name="jobId">
        /// ID of the latest job.
        /// </param>
        /// <param name="deploymentDate">
        /// Date of the deployment.
        /// </param>
        /// <param name="error">
        /// List of errors that occurred during ingestion.
        /// </param>
        /// <param name="effectiveAt">
        /// When the status is effective
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedIngestionStatusResponse(
            global::G.ManagedIngestionStatus status,
            global::System.Guid? jobId,
            global::System.DateTime? deploymentDate,
            global::System.Collections.Generic.IList<global::G.IngestionErrorResponse>? error,
            global::System.DateTime? effectiveAt)
        {
            this.JobId = jobId;
            this.DeploymentDate = deploymentDate;
            this.Status = status;
            this.Error = error;
            this.EffectiveAt = effectiveAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedIngestionStatusResponse" /> class.
        /// </summary>
        public ManagedIngestionStatusResponse()
        {
        }
    }
}