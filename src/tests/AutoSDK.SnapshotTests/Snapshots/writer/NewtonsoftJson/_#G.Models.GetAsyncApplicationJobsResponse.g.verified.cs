//HintName: G.Models.GetAsyncApplicationJobsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAsyncApplicationJobsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetAsyncApplicationJobResponse> Result { get; set; } = default!;

        /// <summary>
        /// The total number of jobs associated with the application.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalCount")]
        public long? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination")]
        public global::G.GetAsyncApplicationJobsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAsyncApplicationJobsResponse" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="totalCount">
        /// The total number of jobs associated with the application.
        /// </param>
        /// <param name="pagination"></param>
        public GetAsyncApplicationJobsResponse(
            global::System.Collections.Generic.IList<global::G.GetAsyncApplicationJobResponse> result,
            long? totalCount,
            global::G.GetAsyncApplicationJobsResponsePagination? pagination)
        {
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.TotalCount = totalCount;
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAsyncApplicationJobsResponse" /> class.
        /// </summary>
        public GetAsyncApplicationJobsResponse()
        {
        }
    }
}