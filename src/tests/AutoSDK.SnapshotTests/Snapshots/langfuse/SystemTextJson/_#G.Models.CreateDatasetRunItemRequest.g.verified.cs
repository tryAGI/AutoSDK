//HintName: G.Models.CreateDatasetRunItemRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetRunItemRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunName { get; set; }

        /// <summary>
        /// Description of the run. If run exists, description will be updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runDescription")]
        public string? RunDescription { get; set; }

        /// <summary>
        /// Metadata of the dataset run, updates run if run already exists
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetItemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observationId")]
        public string? ObservationId { get; set; }

        /// <summary>
        /// traceId should always be provided. For compatibility with older SDK versions it can also be inferred from the provided observationId.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        public string? TraceId { get; set; }

        /// <summary>
        /// ISO 8601 timestamp (RFC 3339, Section 5.6) in UTC (e.g., "2026-01-21T14:35:42Z").<br/>
        /// Specifies the dataset version to use for this experiment run. <br/>
        /// If provided, the experiment will use dataset items as they existed at or before this timestamp.<br/>
        /// If not provided, uses the latest version of dataset items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetVersion")]
        public global::System.DateTime? DatasetVersion { get; set; }

        /// <summary>
        /// Optional timestamp to set the createdAt field of the dataset run item. If not provided or null, defaults to current timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetRunItemRequest" /> class.
        /// </summary>
        /// <param name="runName"></param>
        /// <param name="datasetItemId"></param>
        /// <param name="runDescription">
        /// Description of the run. If run exists, description will be updated.
        /// </param>
        /// <param name="metadata">
        /// Metadata of the dataset run, updates run if run already exists
        /// </param>
        /// <param name="observationId"></param>
        /// <param name="traceId">
        /// traceId should always be provided. For compatibility with older SDK versions it can also be inferred from the provided observationId.
        /// </param>
        /// <param name="datasetVersion">
        /// ISO 8601 timestamp (RFC 3339, Section 5.6) in UTC (e.g., "2026-01-21T14:35:42Z").<br/>
        /// Specifies the dataset version to use for this experiment run. <br/>
        /// If provided, the experiment will use dataset items as they existed at or before this timestamp.<br/>
        /// If not provided, uses the latest version of dataset items.
        /// </param>
        /// <param name="createdAt">
        /// Optional timestamp to set the createdAt field of the dataset run item. If not provided or null, defaults to current timestamp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetRunItemRequest(
            string runName,
            string datasetItemId,
            string? runDescription,
            object? metadata,
            string? observationId,
            string? traceId,
            global::System.DateTime? datasetVersion,
            global::System.DateTime? createdAt)
        {
            this.RunName = runName ?? throw new global::System.ArgumentNullException(nameof(runName));
            this.RunDescription = runDescription;
            this.Metadata = metadata;
            this.DatasetItemId = datasetItemId ?? throw new global::System.ArgumentNullException(nameof(datasetItemId));
            this.ObservationId = observationId;
            this.TraceId = traceId;
            this.DatasetVersion = datasetVersion;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetRunItemRequest" /> class.
        /// </summary>
        public CreateDatasetRunItemRequest()
        {
        }
    }
}