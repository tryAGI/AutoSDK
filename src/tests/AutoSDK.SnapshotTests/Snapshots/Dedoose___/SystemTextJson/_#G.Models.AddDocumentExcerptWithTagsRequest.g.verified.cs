//HintName: G.Models.AddDocumentExcerptWithTagsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddDocumentExcerptWithTagsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startIndex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endIndex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExcerptText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagApps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TagAppSimple> TagApps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDocumentExcerptWithTagsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="resourceId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <param name="excerptText"></param>
        /// <param name="tagApps"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AddDocumentExcerptWithTagsRequest(
            global::System.Guid projectId,
            global::System.Guid userId,
            global::System.Guid resourceId,
            string title,
            string description,
            int startIndex,
            int endIndex,
            string excerptText,
            global::System.Collections.Generic.IList<global::G.TagAppSimple> tagApps)
        {
            this.ProjectId = projectId;
            this.UserId = userId;
            this.ResourceId = resourceId;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.ExcerptText = excerptText ?? throw new global::System.ArgumentNullException(nameof(excerptText));
            this.TagApps = tagApps ?? throw new global::System.ArgumentNullException(nameof(tagApps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddDocumentExcerptWithTagsRequest" /> class.
        /// </summary>
        public AddDocumentExcerptWithTagsRequest()
        {
        }
    }
}