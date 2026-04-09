//HintName: G.Models.TopicMapData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicMapData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TopicMapDataTypeJsonConverter))]
        public global::G.TopicMapDataType Type { get; set; }

        /// <summary>
        /// The facet field name to use as input for classification
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_facet", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceFacet { get; set; } = default!;

        /// <summary>
        /// The embedding model to use for embedding facet values
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_model", Required = global::Newtonsoft.Json.Required.Always)]
        public string EmbeddingModel { get; set; } = default!;

        /// <summary>
        /// Key of the topic map bundle in code_bundles bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bundle_key")]
        public string? BundleKey { get; set; }

        /// <summary>
        /// Key of the clustering report in code_bundles bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("report_key")]
        public string? ReportKey { get; set; }

        /// <summary>
        /// Mapping from topic_id to topic name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topic_names")]
        public global::System.Collections.Generic.Dictionary<string, string>? TopicNames { get; set; }

        /// <summary>
        /// Maximum distance to nearest centroid. If exceeded, returns no_match.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("distance_threshold")]
        public double? DistanceThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicMapData" /> class.
        /// </summary>
        /// <param name="sourceFacet">
        /// The facet field name to use as input for classification
        /// </param>
        /// <param name="embeddingModel">
        /// The embedding model to use for embedding facet values
        /// </param>
        /// <param name="type"></param>
        /// <param name="bundleKey">
        /// Key of the topic map bundle in code_bundles bucket
        /// </param>
        /// <param name="reportKey">
        /// Key of the clustering report in code_bundles bucket
        /// </param>
        /// <param name="topicNames">
        /// Mapping from topic_id to topic name
        /// </param>
        /// <param name="distanceThreshold">
        /// Maximum distance to nearest centroid. If exceeded, returns no_match.
        /// </param>
        public TopicMapData(
            string sourceFacet,
            string embeddingModel,
            global::G.TopicMapDataType type,
            string? bundleKey,
            string? reportKey,
            global::System.Collections.Generic.Dictionary<string, string>? topicNames,
            double? distanceThreshold)
        {
            this.Type = type;
            this.SourceFacet = sourceFacet ?? throw new global::System.ArgumentNullException(nameof(sourceFacet));
            this.EmbeddingModel = embeddingModel ?? throw new global::System.ArgumentNullException(nameof(embeddingModel));
            this.BundleKey = bundleKey;
            this.ReportKey = reportKey;
            this.TopicNames = topicNames;
            this.DistanceThreshold = distanceThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicMapData" /> class.
        /// </summary>
        public TopicMapData()
        {
        }
    }
}