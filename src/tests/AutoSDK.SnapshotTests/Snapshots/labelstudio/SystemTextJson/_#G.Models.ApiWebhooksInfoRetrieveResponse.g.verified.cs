//HintName: G.Models.ApiWebhooksInfoRetrieveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiWebhooksInfoRetrieveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ANNOTATIONS_CREATED")]
        public global::G.ApiWebhooksInfoRetrieveResponseAnnotationsCreated? AnnotationsCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ANNOTATIONS_DELETED")]
        public global::G.ApiWebhooksInfoRetrieveResponseAnnotationsDeleted? AnnotationsDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ANNOTATION_CREATED")]
        public global::G.ApiWebhooksInfoRetrieveResponseAnnotationCreated? AnnotationCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ANNOTATION_UPDATED")]
        public global::G.ApiWebhooksInfoRetrieveResponseAnnotationUpdated? AnnotationUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LABEL_LINK_CREATED")]
        public global::G.ApiWebhooksInfoRetrieveResponseLabelLinkCreated? LabelLinkCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LABEL_LINK_DELETED")]
        public global::G.ApiWebhooksInfoRetrieveResponseLabelLinkDeleted? LabelLinkDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LABEL_LINK_UPDATED")]
        public global::G.ApiWebhooksInfoRetrieveResponseLabelLinkUpdated? LabelLinkUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROJECT_CREATED")]
        public global::G.ApiWebhooksInfoRetrieveResponseProjectCreated? ProjectCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROJECT_DELETED")]
        public global::G.ApiWebhooksInfoRetrieveResponseProjectDeleted? ProjectDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("PROJECT_UPDATED")]
        public global::G.ApiWebhooksInfoRetrieveResponseProjectUpdated? ProjectUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("REVIEWS_DELETED")]
        public global::G.ApiWebhooksInfoRetrieveResponseReviewsDeleted? ReviewsDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("REVIEW_CREATED")]
        public global::G.ApiWebhooksInfoRetrieveResponseReviewCreated? ReviewCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("REVIEW_UPDATED")]
        public global::G.ApiWebhooksInfoRetrieveResponseReviewUpdated? ReviewUpdated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TASKS_CREATED")]
        public global::G.ApiWebhooksInfoRetrieveResponseTasksCreated? TasksCreated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TASKS_DELETED")]
        public global::G.ApiWebhooksInfoRetrieveResponseTasksDeleted? TasksDeleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiWebhooksInfoRetrieveResponse" /> class.
        /// </summary>
        /// <param name="annotationsCreated"></param>
        /// <param name="annotationsDeleted"></param>
        /// <param name="annotationCreated"></param>
        /// <param name="annotationUpdated"></param>
        /// <param name="labelLinkCreated"></param>
        /// <param name="labelLinkDeleted"></param>
        /// <param name="labelLinkUpdated"></param>
        /// <param name="projectCreated"></param>
        /// <param name="projectDeleted"></param>
        /// <param name="projectUpdated"></param>
        /// <param name="reviewsDeleted"></param>
        /// <param name="reviewCreated"></param>
        /// <param name="reviewUpdated"></param>
        /// <param name="tasksCreated"></param>
        /// <param name="tasksDeleted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiWebhooksInfoRetrieveResponse(
            global::G.ApiWebhooksInfoRetrieveResponseAnnotationsCreated? annotationsCreated,
            global::G.ApiWebhooksInfoRetrieveResponseAnnotationsDeleted? annotationsDeleted,
            global::G.ApiWebhooksInfoRetrieveResponseAnnotationCreated? annotationCreated,
            global::G.ApiWebhooksInfoRetrieveResponseAnnotationUpdated? annotationUpdated,
            global::G.ApiWebhooksInfoRetrieveResponseLabelLinkCreated? labelLinkCreated,
            global::G.ApiWebhooksInfoRetrieveResponseLabelLinkDeleted? labelLinkDeleted,
            global::G.ApiWebhooksInfoRetrieveResponseLabelLinkUpdated? labelLinkUpdated,
            global::G.ApiWebhooksInfoRetrieveResponseProjectCreated? projectCreated,
            global::G.ApiWebhooksInfoRetrieveResponseProjectDeleted? projectDeleted,
            global::G.ApiWebhooksInfoRetrieveResponseProjectUpdated? projectUpdated,
            global::G.ApiWebhooksInfoRetrieveResponseReviewsDeleted? reviewsDeleted,
            global::G.ApiWebhooksInfoRetrieveResponseReviewCreated? reviewCreated,
            global::G.ApiWebhooksInfoRetrieveResponseReviewUpdated? reviewUpdated,
            global::G.ApiWebhooksInfoRetrieveResponseTasksCreated? tasksCreated,
            global::G.ApiWebhooksInfoRetrieveResponseTasksDeleted? tasksDeleted)
        {
            this.AnnotationsCreated = annotationsCreated;
            this.AnnotationsDeleted = annotationsDeleted;
            this.AnnotationCreated = annotationCreated;
            this.AnnotationUpdated = annotationUpdated;
            this.LabelLinkCreated = labelLinkCreated;
            this.LabelLinkDeleted = labelLinkDeleted;
            this.LabelLinkUpdated = labelLinkUpdated;
            this.ProjectCreated = projectCreated;
            this.ProjectDeleted = projectDeleted;
            this.ProjectUpdated = projectUpdated;
            this.ReviewsDeleted = reviewsDeleted;
            this.ReviewCreated = reviewCreated;
            this.ReviewUpdated = reviewUpdated;
            this.TasksCreated = tasksCreated;
            this.TasksDeleted = tasksDeleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiWebhooksInfoRetrieveResponse" /> class.
        /// </summary>
        public ApiWebhooksInfoRetrieveResponse()
        {
        }
    }
}