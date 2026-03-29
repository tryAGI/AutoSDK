//HintName: G.Models.ListJobsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListJobsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.JobStatus> Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ListJobsResponsePagination Pagination { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListJobsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="pagination"></param>
        public ListJobsResponse(
            global::System.Collections.Generic.IList<global::G.JobStatus> data,
            global::G.ListJobsResponsePagination pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListJobsResponse" /> class.
        /// </summary>
        public ListJobsResponse()
        {
        }
    }
}