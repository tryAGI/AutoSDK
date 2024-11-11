//HintName: G.Models.TopicSearchResultItemRelatedItemTopicRelation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicSearchResultItemRelatedItemTopicRelation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topic_id")]
        public int? TopicId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("relation_type")]
        public string? RelationType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSearchResultItemRelatedItemTopicRelation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="topicId"></param>
        /// <param name="relationType"></param>
        public TopicSearchResultItemRelatedItemTopicRelation(
            int? id,
            string? name,
            int? topicId,
            string? relationType)
        {
            this.Id = id;
            this.Name = name;
            this.TopicId = topicId;
            this.RelationType = relationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSearchResultItemRelatedItemTopicRelation" /> class.
        /// </summary>
        public TopicSearchResultItemRelatedItemTopicRelation()
        {
        }
    }
}