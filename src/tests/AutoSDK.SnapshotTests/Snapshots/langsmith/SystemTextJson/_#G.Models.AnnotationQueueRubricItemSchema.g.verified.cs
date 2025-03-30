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
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeedbackKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_descriptions")]
        public global::System.Collections.Generic.Dictionary<string, string>? ValueDescriptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_descriptions")]
        public global::System.Collections.Generic.Dictionary<string, string>? ScoreDescriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueRubricItemSchema" /> class.
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="description"></param>
        /// <param name="valueDescriptions"></param>
        /// <param name="scoreDescriptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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