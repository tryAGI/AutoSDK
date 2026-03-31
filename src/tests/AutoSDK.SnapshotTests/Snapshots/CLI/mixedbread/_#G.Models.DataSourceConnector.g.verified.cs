//HintName: G.Models.DataSourceConnector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Service-level representation of a connector.
    /// </summary>
    public sealed partial class DataSourceConnector
    {
        /// <summary>
        /// The ID of the connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The creation time of the connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The last update time of the connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The ID of the store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StoreId { get; set; }

        /// <summary>
        /// The ID of the data source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DataSourceId { get; set; }

        /// <summary>
        /// The name of the connector<br/>
        /// Default Value: New Connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The metadata of the connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The polling interval of the connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polling_interval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PollingInterval { get; set; }

        /// <summary>
        /// The start time of the connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The finish time of the connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// The last sync time of the connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_synced_at")]
        public global::System.DateTime? LastSyncedAt { get; set; }

        /// <summary>
        /// The sync status of the connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SyncStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SyncStatus Status { get; set; }

        /// <summary>
        /// The sync error of the connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// The type of the object<br/>
        /// Default Value: data_source.connector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceConnector" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the connector
        /// </param>
        /// <param name="createdAt">
        /// The creation time of the connector
        /// </param>
        /// <param name="updatedAt">
        /// The last update time of the connector
        /// </param>
        /// <param name="storeId">
        /// The ID of the store
        /// </param>
        /// <param name="dataSourceId">
        /// The ID of the data source
        /// </param>
        /// <param name="pollingInterval">
        /// The polling interval of the connector
        /// </param>
        /// <param name="status">
        /// The sync status of the connector
        /// </param>
        /// <param name="name">
        /// The name of the connector<br/>
        /// Default Value: New Connector
        /// </param>
        /// <param name="metadata">
        /// The metadata of the connector
        /// </param>
        /// <param name="startedAt">
        /// The start time of the connector
        /// </param>
        /// <param name="finishedAt">
        /// The finish time of the connector
        /// </param>
        /// <param name="lastSyncedAt">
        /// The last sync time of the connector
        /// </param>
        /// <param name="error">
        /// The sync error of the connector
        /// </param>
        /// <param name="object">
        /// The type of the object<br/>
        /// Default Value: data_source.connector
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSourceConnector(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string storeId,
            string dataSourceId,
            string pollingInterval,
            global::G.SyncStatus status,
            string? name,
            object? metadata,
            global::System.DateTime? startedAt,
            global::System.DateTime? finishedAt,
            global::System.DateTime? lastSyncedAt,
            object? error,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.DataSourceId = dataSourceId ?? throw new global::System.ArgumentNullException(nameof(dataSourceId));
            this.Name = name;
            this.Metadata = metadata;
            this.PollingInterval = pollingInterval ?? throw new global::System.ArgumentNullException(nameof(pollingInterval));
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.LastSyncedAt = lastSyncedAt;
            this.Status = status;
            this.Error = error;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceConnector" /> class.
        /// </summary>
        public DataSourceConnector()
        {
        }
    }
}