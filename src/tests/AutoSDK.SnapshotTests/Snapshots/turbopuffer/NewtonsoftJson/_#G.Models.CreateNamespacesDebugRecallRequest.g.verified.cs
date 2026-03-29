//HintName: G.Models.CreateNamespacesDebugRecallRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateNamespacesDebugRecallRequest
    {
        /// <summary>
        /// The number of searches to run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num")]
        public int? Num { get; set; }

        /// <summary>
        /// Search for `top_k` nearest neighbors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Filter by attributes. Same syntax as the query endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public object? Filters { get; set; }

        /// <summary>
        /// Include ground truth data (query vectors and true nearest neighbors) in the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_ground_truth")]
        public bool? IncludeGroundTruth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesDebugRecallRequest" /> class.
        /// </summary>
        /// <param name="num">
        /// The number of searches to run.
        /// </param>
        /// <param name="topK">
        /// Search for `top_k` nearest neighbors.
        /// </param>
        /// <param name="filters">
        /// Filter by attributes. Same syntax as the query endpoint.
        /// </param>
        /// <param name="includeGroundTruth">
        /// Include ground truth data (query vectors and true nearest neighbors) in the response.<br/>
        /// Default Value: false
        /// </param>
        public CreateNamespacesDebugRecallRequest(
            int? num,
            int? topK,
            object? filters,
            bool? includeGroundTruth)
        {
            this.Num = num;
            this.TopK = topK;
            this.Filters = filters;
            this.IncludeGroundTruth = includeGroundTruth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNamespacesDebugRecallRequest" /> class.
        /// </summary>
        public CreateNamespacesDebugRecallRequest()
        {
        }
    }
}