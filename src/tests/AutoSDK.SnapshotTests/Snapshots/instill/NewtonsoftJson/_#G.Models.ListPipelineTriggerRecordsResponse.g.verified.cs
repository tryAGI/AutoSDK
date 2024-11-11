//HintName: G.Models.ListPipelineTriggerRecordsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListPipelineTriggerRecordsResponse contains a list of pipeline triggers.
    /// </summary>
    public sealed partial class ListPipelineTriggerRecordsResponse
    {
        /// <summary>
        /// A list of pipeline triggers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineTriggerRecords")]
        public global::System.Collections.Generic.IList<global::G.PipelineTriggerRecord>? PipelineTriggerRecords { get; set; }

        /// <summary>
        /// Next page token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Total number of pipeline triggers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineTriggerRecordsResponse" /> class.
        /// </summary>
        /// <param name="pipelineTriggerRecords">
        /// A list of pipeline triggers.
        /// </param>
        /// <param name="nextPageToken">
        /// Next page token.
        /// </param>
        /// <param name="totalSize">
        /// Total number of pipeline triggers.
        /// </param>
        public ListPipelineTriggerRecordsResponse(
            global::System.Collections.Generic.IList<global::G.PipelineTriggerRecord>? pipelineTriggerRecords,
            string? nextPageToken,
            int? totalSize)
        {
            this.PipelineTriggerRecords = pipelineTriggerRecords;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineTriggerRecordsResponse" /> class.
        /// </summary>
        public ListPipelineTriggerRecordsResponse()
        {
        }
    }
}