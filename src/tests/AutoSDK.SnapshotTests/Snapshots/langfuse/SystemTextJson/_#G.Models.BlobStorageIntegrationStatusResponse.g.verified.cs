//HintName: G.Models.BlobStorageIntegrationStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlobStorageIntegrationStatusResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Sync status of the blob storage integration:<br/>
        /// - `disabled` — integration is not enabled<br/>
        /// - `error` — last export failed (see `lastError` for details)<br/>
        /// - `idle` — enabled but has never exported yet<br/>
        /// - `queued` — next export is overdue (`nextSyncAt` is in the past) and waiting to be picked up by the worker<br/>
        /// - `up_to_date` — all available data has been exported; next export is scheduled for the future<br/>
        /// **ETL usage**: poll this endpoint and check for `up_to_date` status. Compare `lastSyncAt` against your<br/>
        /// ETL bookmark to determine if new data is available. Note that exports run with a 30-minute lag buffer,<br/>
        /// so `lastSyncAt` will always be at least 30 minutes behind real-time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syncStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BlobStorageSyncStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BlobStorageSyncStatus SyncStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// End of the last successfully exported time window. Compare against your ETL bookmark to determine if new data is available. Null if the integration has never synced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSyncAt")]
        public global::System.DateTime? LastSyncAt { get; set; }

        /// <summary>
        /// When the next export is scheduled. Null if no sync has occurred yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextSyncAt")]
        public global::System.DateTime? NextSyncAt { get; set; }

        /// <summary>
        /// Raw error message from the storage provider (S3/Azure/GCS) if the last export failed. Cleared on successful export.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastError")]
        public string? LastError { get; set; }

        /// <summary>
        /// When the last error occurred. Cleared on successful export.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastErrorAt")]
        public global::System.DateTime? LastErrorAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlobStorageIntegrationStatusResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="syncStatus">
        /// Sync status of the blob storage integration:<br/>
        /// - `disabled` — integration is not enabled<br/>
        /// - `error` — last export failed (see `lastError` for details)<br/>
        /// - `idle` — enabled but has never exported yet<br/>
        /// - `queued` — next export is overdue (`nextSyncAt` is in the past) and waiting to be picked up by the worker<br/>
        /// - `up_to_date` — all available data has been exported; next export is scheduled for the future<br/>
        /// **ETL usage**: poll this endpoint and check for `up_to_date` status. Compare `lastSyncAt` against your<br/>
        /// ETL bookmark to determine if new data is available. Note that exports run with a 30-minute lag buffer,<br/>
        /// so `lastSyncAt` will always be at least 30 minutes behind real-time.
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="lastSyncAt">
        /// End of the last successfully exported time window. Compare against your ETL bookmark to determine if new data is available. Null if the integration has never synced.
        /// </param>
        /// <param name="nextSyncAt">
        /// When the next export is scheduled. Null if no sync has occurred yet.
        /// </param>
        /// <param name="lastError">
        /// Raw error message from the storage provider (S3/Azure/GCS) if the last export failed. Cleared on successful export.
        /// </param>
        /// <param name="lastErrorAt">
        /// When the last error occurred. Cleared on successful export.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlobStorageIntegrationStatusResponse(
            string id,
            string projectId,
            global::G.BlobStorageSyncStatus syncStatus,
            bool enabled,
            global::System.DateTime? lastSyncAt,
            global::System.DateTime? nextSyncAt,
            string? lastError,
            global::System.DateTime? lastErrorAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.SyncStatus = syncStatus;
            this.Enabled = enabled;
            this.LastSyncAt = lastSyncAt;
            this.NextSyncAt = nextSyncAt;
            this.LastError = lastError;
            this.LastErrorAt = lastErrorAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlobStorageIntegrationStatusResponse" /> class.
        /// </summary>
        public BlobStorageIntegrationStatusResponse()
        {
        }
    }
}