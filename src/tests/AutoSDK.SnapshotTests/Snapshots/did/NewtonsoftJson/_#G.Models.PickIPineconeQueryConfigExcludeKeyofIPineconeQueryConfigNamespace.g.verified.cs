//HintName: G.Models.PickIPineconeQueryConfigExcludeKeyofIPineconeQueryConfigNamespace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class PickIPineconeQueryConfigExcludeKeyofIPineconeQueryConfigNamespace
    {
        /// <summary>
        /// Indicates whether metadata is included in the response as well as the ids.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeMetadata")]
        public bool? IncludeMetadata { get; set; }

        /// <summary>
        /// Indicates whether vector values are included in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeValues")]
        public bool? IncludeValues { get; set; }

        /// <summary>
        /// The number of results to return for each query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topK")]
        public double? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickIPineconeQueryConfigExcludeKeyofIPineconeQueryConfigNamespace" /> class.
        /// </summary>
        /// <param name="includeMetadata">
        /// Indicates whether metadata is included in the response as well as the ids.
        /// </param>
        /// <param name="includeValues">
        /// Indicates whether vector values are included in the response.
        /// </param>
        /// <param name="topK">
        /// The number of results to return for each query.
        /// </param>
        public PickIPineconeQueryConfigExcludeKeyofIPineconeQueryConfigNamespace(
            bool? includeMetadata,
            bool? includeValues,
            double? topK)
        {
            this.IncludeMetadata = includeMetadata;
            this.IncludeValues = includeValues;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickIPineconeQueryConfigExcludeKeyofIPineconeQueryConfigNamespace" /> class.
        /// </summary>
        public PickIPineconeQueryConfigExcludeKeyofIPineconeQueryConfigNamespace()
        {
        }
    }
}