//HintName: G.Models.TopicSearchResultItemRelatedItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicSearchResultItemRelatedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topic_relation")]
        public global::G.TopicSearchResultItemRelatedItemTopicRelation? TopicRelation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSearchResultItemRelatedItem" /> class.
        /// </summary>
        /// <param name="topicRelation"></param>
        public TopicSearchResultItemRelatedItem(
            global::G.TopicSearchResultItemRelatedItemTopicRelation? topicRelation)
        {
            this.TopicRelation = topicRelation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSearchResultItemRelatedItem" /> class.
        /// </summary>
        public TopicSearchResultItemRelatedItem()
        {
        }
    }
}