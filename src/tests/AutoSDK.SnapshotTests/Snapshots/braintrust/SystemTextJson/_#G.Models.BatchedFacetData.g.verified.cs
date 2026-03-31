//HintName: G.Models.BatchedFacetData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchedFacetData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BatchedFacetDataTypeJsonConverter))]
        public global::G.BatchedFacetDataType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preprocessor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.NullableSavedFunctionId?, object>))]
        public global::G.AllOf<global::G.NullableSavedFunctionId?, object>? Preprocessor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BatchedFacetDataFacet> Facets { get; set; }

        /// <summary>
        /// Topic maps that depend on facets in this batch, keyed by source facet name. Each source facet can have multiple topic maps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_maps")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.BatchedFacetDataTopicMap>>? TopicMaps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchedFacetData" /> class.
        /// </summary>
        /// <param name="facets"></param>
        /// <param name="type"></param>
        /// <param name="preprocessor"></param>
        /// <param name="topicMaps">
        /// Topic maps that depend on facets in this batch, keyed by source facet name. Each source facet can have multiple topic maps.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchedFacetData(
            global::System.Collections.Generic.IList<global::G.BatchedFacetDataFacet> facets,
            global::G.BatchedFacetDataType type,
            global::G.AllOf<global::G.NullableSavedFunctionId?, object>? preprocessor,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::G.BatchedFacetDataTopicMap>>? topicMaps)
        {
            this.Type = type;
            this.Preprocessor = preprocessor;
            this.Facets = facets ?? throw new global::System.ArgumentNullException(nameof(facets));
            this.TopicMaps = topicMaps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchedFacetData" /> class.
        /// </summary>
        public BatchedFacetData()
        {
        }
    }
}