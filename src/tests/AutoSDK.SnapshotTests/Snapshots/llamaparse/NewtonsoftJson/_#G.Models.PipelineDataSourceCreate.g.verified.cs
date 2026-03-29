//HintName: G.Models.PipelineDataSourceCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for creating an association between a data source and a pipeline.
    /// </summary>
    public sealed partial class PipelineDataSourceCreate
    {
        /// <summary>
        /// The ID of the data source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data_source_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DataSourceId { get; set; } = default!;

        /// <summary>
        /// The interval at which the data source should be synced. Valid values are: 21600, 43200, 86400
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sync_interval")]
        public double? SyncInterval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineDataSourceCreate" /> class.
        /// </summary>
        /// <param name="dataSourceId">
        /// The ID of the data source.
        /// </param>
        /// <param name="syncInterval">
        /// The interval at which the data source should be synced. Valid values are: 21600, 43200, 86400
        /// </param>
        public PipelineDataSourceCreate(
            global::System.Guid dataSourceId,
            double? syncInterval)
        {
            this.DataSourceId = dataSourceId;
            this.SyncInterval = syncInterval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineDataSourceCreate" /> class.
        /// </summary>
        public PipelineDataSourceCreate()
        {
        }
    }
}