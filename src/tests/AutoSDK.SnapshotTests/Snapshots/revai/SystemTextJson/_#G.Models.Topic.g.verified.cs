//HintName: G.Models.Topic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Topic
    {
        /// <summary>
        /// Name of the extracted topic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic_name")]
        public string? TopicName { get; set; }

        /// <summary>
        /// Relevance score of the topic (0.0 to 1.0)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Text segments that mention this topic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("informants")]
        public global::System.Collections.Generic.IList<global::G.TopicInformant>? Informants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Topic" /> class.
        /// </summary>
        /// <param name="topicName">
        /// Name of the extracted topic
        /// </param>
        /// <param name="score">
        /// Relevance score of the topic (0.0 to 1.0)
        /// </param>
        /// <param name="informants">
        /// Text segments that mention this topic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Topic(
            string? topicName,
            double? score,
            global::System.Collections.Generic.IList<global::G.TopicInformant>? informants)
        {
            this.TopicName = topicName;
            this.Score = score;
            this.Informants = informants;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Topic" /> class.
        /// </summary>
        public Topic()
        {
        }
    }
}