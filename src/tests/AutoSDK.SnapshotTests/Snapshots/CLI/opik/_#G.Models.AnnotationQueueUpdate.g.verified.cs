//HintName: G.Models.AnnotationQueueUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationQueueUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_enabled")]
        public bool? CommentsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_definition_names")]
        public global::System.Collections.Generic.IList<string>? FeedbackDefinitionNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="instructions"></param>
        /// <param name="commentsEnabled"></param>
        /// <param name="feedbackDefinitionNames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueUpdate(
            string? name,
            string? description,
            string? instructions,
            bool? commentsEnabled,
            global::System.Collections.Generic.IList<string>? feedbackDefinitionNames)
        {
            this.Name = name;
            this.Description = description;
            this.Instructions = instructions;
            this.CommentsEnabled = commentsEnabled;
            this.FeedbackDefinitionNames = feedbackDefinitionNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueUpdate" /> class.
        /// </summary>
        public AnnotationQueueUpdate()
        {
        }
    }
}