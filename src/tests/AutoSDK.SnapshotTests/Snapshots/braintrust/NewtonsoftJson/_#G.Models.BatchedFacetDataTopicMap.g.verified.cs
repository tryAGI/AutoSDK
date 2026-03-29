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
        [global::Newtonsoft.Json.JsonProperty("function_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FunctionName { get; set; } = default!;

        /// <summary>
        /// The id of the topic map function
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topic_map_id")]
        public string? TopicMapId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topic_map_data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TopicMapData TopicMapData { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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