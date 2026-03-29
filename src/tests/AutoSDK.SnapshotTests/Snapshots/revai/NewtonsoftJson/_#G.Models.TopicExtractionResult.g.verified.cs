//HintName: G.Models.TopicExtractionResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Topic Extraction Result
    /// </summary>
    public sealed partial class TopicExtractionResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("topics")]
        public global::System.Collections.Generic.IList<global::G.Topic>? Topics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicExtractionResult" /> class.
        /// </summary>
        /// <param name="topics"></param>
        public TopicExtractionResult(
            global::System.Collections.Generic.IList<global::G.Topic>? topics)
        {
            this.Topics = topics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicExtractionResult" /> class.
        /// </summary>
        public TopicExtractionResult()
        {
        }
    }
}