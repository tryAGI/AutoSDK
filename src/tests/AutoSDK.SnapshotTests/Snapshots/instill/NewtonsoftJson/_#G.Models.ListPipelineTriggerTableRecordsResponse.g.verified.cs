//HintName: G.Models.ListPipelineTriggerTableRecordsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListPipelineTriggerTableRecordsResponse contains the pipeline metrics.
    /// </summary>
    public sealed partial class ListPipelineTriggerTableRecordsResponse
    {
        /// <summary>
        /// A list of pipeline trigger tables.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineTriggerTableRecords")]
        public global::System.Collections.Generic.IList<global::G.PipelineTriggerTableRecord>? PipelineTriggerTableRecords { get; set; }

        /// <summary>
        /// Next page token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}