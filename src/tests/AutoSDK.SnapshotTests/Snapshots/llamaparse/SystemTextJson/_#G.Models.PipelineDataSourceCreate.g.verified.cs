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
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DataSourceId { get; set; }

        /// <summary>
        /// The interval at which the data source should be synced. Valid values are: 21600, 43200, 86400
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sync_interval")]
        public double? SyncInterval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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