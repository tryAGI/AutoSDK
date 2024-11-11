//HintName: G.Models.PaginatedScalingConfigGetWithPipelineCount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for a paginated set of a given resource.
    /// </summary>
    public sealed partial class PaginatedScalingConfigGetWithPipelineCount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("skip", Required = global::Newtonsoft.Json.Required.Always)]
        public int Skip { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ScalingConfigGetWithPipelineCount> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedScalingConfigGetWithPipelineCount" /> class.
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="limit"></param>
        /// <param name="total"></param>
        /// <param name="data"></param>
        public PaginatedScalingConfigGetWithPipelineCount(
            int skip,
            int limit,
            int total,
            global::System.Collections.Generic.IList<global::G.ScalingConfigGetWithPipelineCount> data)
        {
            this.Skip = skip;
            this.Limit = limit;
            this.Total = total;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedScalingConfigGetWithPipelineCount" /> class.
        /// </summary>
        public PaginatedScalingConfigGetWithPipelineCount()
        {
        }
    }
}