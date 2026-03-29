//HintName: G.Models.RequestQueryParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestQueryParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RequestFilterNodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RequestFilterNode Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public double? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        public global::G.SortLeafRequest? Sort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCached")]
        public bool? IsCached { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeInputs")]
        public bool? IncludeInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPartOfExperiment")]
        public bool? IsPartOfExperiment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isScored")]
        public bool? IsScored { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueryParams" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="sort"></param>
        /// <param name="isCached"></param>
        /// <param name="includeInputs"></param>
        /// <param name="isPartOfExperiment"></param>
        /// <param name="isScored"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestQueryParams(
            global::G.RequestFilterNode filter,
            double? offset,
            double? limit,
            global::G.SortLeafRequest? sort,
            bool? isCached,
            bool? includeInputs,
            bool? isPartOfExperiment,
            bool? isScored)
        {
            this.Filter = filter;
            this.Offset = offset;
            this.Limit = limit;
            this.Sort = sort;
            this.IsCached = isCached;
            this.IncludeInputs = includeInputs;
            this.IsPartOfExperiment = isPartOfExperiment;
            this.IsScored = isScored;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestQueryParams" /> class.
        /// </summary>
        public RequestQueryParams()
        {
        }
    }
}