//HintName: G.Models.DataSourceConnectorCreateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating a connector.
    /// </summary>
    public sealed partial class DataSourceConnectorCreateParams
    {
        /// <summary>
        /// The ID of the store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("store_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// The name of the connector<br/>
        /// Default Value: New Connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the connector should be synced after creation<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger_sync")]
        public bool? TriggerSync { get; set; }

        /// <summary>
        /// The metadata of the connector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Polling interval for the connector. Defaults to 30 minutes if not specified. Can be provided as:<br/>
        /// - int: Number of seconds (e.g., 1800 for 30 minutes)<br/>
        /// - str: Duration string (e.g., '30m', '1h', '2d') or ISO 8601 format (e.g., 'PT30M', 'P1D')<br/>
        /// Valid range: 15 seconds to 30 days
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("polling_interval")]
        public global::G.AnyOf<int?, string, object>? PollingInterval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceConnectorCreateParams" /> class.
        /// </summary>
        /// <param name="storeId">
        /// The ID of the store
        /// </param>
        /// <param name="name">
        /// The name of the connector<br/>
        /// Default Value: New Connector
        /// </param>
        /// <param name="triggerSync">
        /// Whether the connector should be synced after creation<br/>
        /// Default Value: true
        /// </param>
        /// <param name="metadata">
        /// The metadata of the connector
        /// </param>
        /// <param name="pollingInterval">
        /// Polling interval for the connector. Defaults to 30 minutes if not specified. Can be provided as:<br/>
        /// - int: Number of seconds (e.g., 1800 for 30 minutes)<br/>
        /// - str: Duration string (e.g., '30m', '1h', '2d') or ISO 8601 format (e.g., 'PT30M', 'P1D')<br/>
        /// Valid range: 15 seconds to 30 days
        /// </param>
        public DataSourceConnectorCreateParams(
            string storeId,
            string? name,
            bool? triggerSync,
            object? metadata,
            global::G.AnyOf<int?, string, object>? pollingInterval)
        {
            this.StoreId = storeId ?? throw new global::System.ArgumentNullException(nameof(storeId));
            this.Name = name;
            this.TriggerSync = triggerSync;
            this.Metadata = metadata;
            this.PollingInterval = pollingInterval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceConnectorCreateParams" /> class.
        /// </summary>
        public DataSourceConnectorCreateParams()
        {
        }
    }
}