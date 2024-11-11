//HintName: G.Models.ListClusterJobsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListClusterJobsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("jobs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetClusterJobResponse> Jobs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListClusterJobsResponse" /> class.
        /// </summary>
        /// <param name="jobs"></param>
        /// <param name="totalCount"></param>
        /// <param name="meta"></param>
        public ListClusterJobsResponse(
            global::System.Collections.Generic.IList<global::G.GetClusterJobResponse> jobs,
            int? totalCount,
            global::G.ApiMeta? meta)
        {
            this.Jobs = jobs ?? throw new global::System.ArgumentNullException(nameof(jobs));
            this.TotalCount = totalCount;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListClusterJobsResponse" /> class.
        /// </summary>
        public ListClusterJobsResponse()
        {
        }
    }
}