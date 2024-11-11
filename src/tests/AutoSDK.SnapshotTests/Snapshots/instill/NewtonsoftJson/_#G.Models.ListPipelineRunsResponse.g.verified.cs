//HintName: G.Models.ListPipelineRunsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListPipelineRunsResponse is the response message for ListPipelineRuns.
    /// </summary>
    public sealed partial class ListPipelineRunsResponse
    {
        /// <summary>
        /// The list of pipeline runs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipelineRuns")]
        public global::System.Collections.Generic.IList<global::G.PipelineRun>? PipelineRuns { get; set; }

        /// <summary>
        /// The total number of pipeline runs matching the request.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// The current page number.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// The number of items per page.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineRunsResponse" /> class.
        /// </summary>
        /// <param name="pipelineRuns">
        /// The list of pipeline runs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// The total number of pipeline runs matching the request.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="page">
        /// The current page number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="pageSize">
        /// The number of items per page.<br/>
        /// Included only in responses
        /// </param>
        public ListPipelineRunsResponse(
            global::System.Collections.Generic.IList<global::G.PipelineRun>? pipelineRuns,
            int? totalSize,
            int? page,
            int? pageSize)
        {
            this.PipelineRuns = pipelineRuns;
            this.TotalSize = totalSize;
            this.Page = page;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPipelineRunsResponse" /> class.
        /// </summary>
        public ListPipelineRunsResponse()
        {
        }
    }
}