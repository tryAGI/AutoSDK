//HintName: G.Models.BatchedFacetDataTopicMap.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchedFacetDataTopicMap
    {
        /// <summary>
        /// The name of the topic map function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionName { get; set; }

        /// <summary>
        /// The id of the topic map function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_map_id")]
        public string? TopicMapId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_map_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TopicMapData TopicMapData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchedFacetDataTopicMap" /> class.
        /// </summary>
        /// <param name="functionName">
        /// The name of the topic map function
        /// </param>
        /// <param name="topicMapData"></param>
        /// <param name="topicMapId">
        /// The id of the topic map function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchedFacetDataTopicMap(
            string functionName,
            global::G.TopicMapData topicMapData,
            string? topicMapId)
        {
            this.FunctionName = functionName ?? throw new global::System.ArgumentNullException(nameof(functionName));
            this.TopicMapId = topicMapId;
            this.TopicMapData = topicMapData ?? throw new global::System.ArgumentNullException(nameof(topicMapData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchedFacetDataTopicMap" /> class.
        /// </summary>
        public BatchedFacetDataTopicMap()
        {
        }
    }
}