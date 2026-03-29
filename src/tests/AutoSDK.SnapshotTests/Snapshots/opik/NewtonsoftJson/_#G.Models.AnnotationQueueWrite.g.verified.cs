//HintName: G.Models.AnnotationQueueWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of annotation queues to create
    /// </summary>
    public sealed partial class AnnotationQueueWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scope", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnnotationQueueWriteScope Scope { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments_enabled")]
        public bool? CommentsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_definition_names")]
        public global::System.Collections.Generic.IList<string>? FeedbackDefinitionNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueWrite" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="scope"></param>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="instructions"></param>
        /// <param name="commentsEnabled"></param>
        /// <param name="feedbackDefinitionNames"></param>
        public AnnotationQueueWrite(
            global::System.Guid projectId,
            string name,
            global::G.AnnotationQueueWriteScope scope,
            global::System.Guid? id,
            string? description,
            string? instructions,
            bool? commentsEnabled,
            global::System.Collections.Generic.IList<string>? feedbackDefinitionNames)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Instructions = instructions;
            this.Scope = scope;
            this.CommentsEnabled = commentsEnabled;
            this.FeedbackDefinitionNames = feedbackDefinitionNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueWrite" /> class.
        /// </summary>
        public AnnotationQueueWrite()
        {
        }
    }
}