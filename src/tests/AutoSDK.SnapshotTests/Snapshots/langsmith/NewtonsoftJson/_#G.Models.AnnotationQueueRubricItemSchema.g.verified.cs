//HintName: G.Models.AnnotationQueueRubricItemSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationQueueRubricItemSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string FeedbackKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value_descriptions")]
        public global::System.Collections.Generic.Dictionary<string, string>? ValueDescriptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_descriptions")]
        public global::System.Collections.Generic.Dictionary<string, string>? ScoreDescriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueRubricItemSchema" /> class.
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="description"></param>
        /// <param name="valueDescriptions"></param>
        /// <param name="scoreDescriptions"></param>
        public AnnotationQueueRubricItemSchema(
            string feedbackKey,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? valueDescriptions,
            global::System.Collections.Generic.Dictionary<string, string>? scoreDescriptions)
        {
            this.FeedbackKey = feedbackKey ?? throw new global::System.ArgumentNullException(nameof(feedbackKey));
            this.Description = description;
            this.ValueDescriptions = valueDescriptions;
            this.ScoreDescriptions = scoreDescriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueRubricItemSchema" /> class.
        /// </summary>
        public AnnotationQueueRubricItemSchema()
        {
        }
    }
}