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
        [global::Newtonsoft.Json.JsonProperty("job_id")]
        public global::System.Guid? JobId { get; set; }

        /// <summary>
        /// Date of the deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_date")]
        public global::System.DateTime? DeploymentDate { get; set; }

        /// <summary>
        /// Status of the ingestion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ManagedIngestionStatusJsonConverter))]
        public global::G.ManagedIngestionStatus Status { get; set; } = default!;

        /// <summary>
        /// List of errors that occurred during ingestion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public global::System.Collections.Generic.IList<global::G.IngestionErrorResponse>? Error { get; set; }

        /// <summary>
        /// When the status is effective
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effective_at")]
        public global::System.DateTime? EffectiveAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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