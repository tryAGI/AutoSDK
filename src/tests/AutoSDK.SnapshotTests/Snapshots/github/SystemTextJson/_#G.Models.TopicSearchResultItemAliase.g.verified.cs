//HintName: G.Models.TopicSearchResultItemAliase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicSearchResultItemAliase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_relation")]
        public global::G.TopicSearchResultItemAliaseTopicRelation? TopicRelation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSearchResultItemAliase" /> class.
        /// </summary>
        /// <param name="topicRelation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicSearchResultItemAliase(
            global::G.TopicSearchResultItemAliaseTopicRelation? topicRelation)
        {
            this.TopicRelation = topicRelation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSearchResultItemAliase" /> class.
        /// </summary>
        public TopicSearchResultItemAliase()
        {
        }
    }
}