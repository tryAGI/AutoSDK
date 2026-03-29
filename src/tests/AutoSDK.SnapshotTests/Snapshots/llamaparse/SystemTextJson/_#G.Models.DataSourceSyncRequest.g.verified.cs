//HintName: G.Models.DataSourceSyncRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for syncing pipeline data sources.<br/>
    /// Notes:<br/>
    /// - This endpoint pulls from the 3p data source and parses.<br/>
    /// - We accept pipeline_file_ids for now because callers (e.g. add_files_to_pipeline)<br/>
    ///   often have these IDs handy. Internally we map them to external IDs to filter<br/>
    ///   the reader, which enumerates by external ID.<br/>
    /// - Likely to evolve to take external IDs directly; keeping this for convenience.
    /// </summary>
    public sealed partial class DataSourceSyncRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline_file_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? PipelineFileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceSyncRequest" /> class.
        /// </summary>
        /// <param name="pipelineFileIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSourceSyncRequest(
            global::System.Collections.Generic.IList<global::System.Guid>? pipelineFileIds)
        {
            this.PipelineFileIds = pipelineFileIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceSyncRequest" /> class.
        /// </summary>
        public DataSourceSyncRequest()
        {
        }
    }
}