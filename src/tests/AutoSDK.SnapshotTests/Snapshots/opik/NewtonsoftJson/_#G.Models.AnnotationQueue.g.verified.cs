//HintName: G.Models.AnnotationQueue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of annotation queues to create
    /// </summary>
    public sealed partial class AnnotationQueue
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
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

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
        public global::G.AnnotationQueueScope Scope { get; set; } = default!;

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
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewers")]
        public global::System.Collections.Generic.IList<global::G.AnnotationQueueReviewer>? Reviewers { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScoreAverage>? FeedbackScores { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items_count")]
        public long? ItemsCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueue" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name"></param>
        /// <param name="scope"></param>
        /// <param name="id"></param>
        /// <param name="projectName">
        /// Included only in responses
        /// </param>
        /// <param name="description"></param>
        /// <param name="instructions"></param>
        /// <param name="commentsEnabled"></param>
        /// <param name="feedbackDefinitionNames"></param>
        /// <param name="reviewers">
        /// Included only in responses
        /// </param>
        /// <param name="feedbackScores">
        /// Included only in responses
        /// </param>
        /// <param name="itemsCount">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        public AnnotationQueue(
            global::System.Guid projectId,
            string name,
            global::G.AnnotationQueueScope scope,
            global::System.Guid? id,
            string? projectName,
            string? description,
            string? instructions,
            bool? commentsEnabled,
            global::System.Collections.Generic.IList<string>? feedbackDefinitionNames,
            global::System.Collections.Generic.IList<global::G.AnnotationQueueReviewer>? reviewers,
            global::System.Collections.Generic.IList<global::G.FeedbackScoreAverage>? feedbackScores,
            long? itemsCount,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? lastUpdatedAt,
            string? lastUpdatedBy)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Instructions = instructions;
            this.Scope = scope;
            this.CommentsEnabled = commentsEnabled;
            this.FeedbackDefinitionNames = feedbackDefinitionNames;
            this.Reviewers = reviewers;
            this.FeedbackScores = feedbackScores;
            this.ItemsCount = itemsCount;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueue" /> class.
        /// </summary>
        public AnnotationQueue()
        {
        }
    }
}