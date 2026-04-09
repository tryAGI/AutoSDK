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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The creation time of the connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The last update time of the connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The ID of the store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// The ID of the data source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_source_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DataSourceId { get; set; } = default!;

        /// <summary>
        /// The name of the connector<br/>
        /// Default Value: New Connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The metadata of the connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The polling interval of the connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("polling_interval", Required = global::Newtonsoft.Json.Required.Always)]
        public string PollingInterval { get; set; } = default!;

        /// <summary>
        /// The start time of the connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// The finish time of the connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// The last sync time of the connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_synced_at")]
        public global::System.DateTime? LastSyncedAt { get; set; }

        /// <summary>
        /// The sync status of the connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SyncStatusJsonConverter))]
        public global::G.SyncStatus Status { get; set; } = default!;

        /// <summary>
        /// The sync error of the connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public object? Error { get; set; }

        /// <summary>
        /// The type of the object<br/>
        /// Default Value: data_source.connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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