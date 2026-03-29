//HintName: G.Models.PipelineDataSourceUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for updating an association between a data source and a pipeline.
    /// </summary>
    public sealed partial class PipelineDataSourceUpdate
    {
        /// <summary>
        /// The interval at which the data source should be synced.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sync_interval")]
        public double? SyncInterval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineDataSourceUpdate" /> class.
        /// </summary>
        /// <param name="syncInterval">
        /// The interval at which the data source should be synced.
        /// </param>
        public PipelineDataSourceUpdate(
            double? syncInterval)
        {
            this.SyncInterval = syncInterval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineDataSourceUpdate" /> class.
        /// </summary>
        public PipelineDataSourceUpdate()
        {
        }
    }
}