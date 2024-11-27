//HintName: G.Models.AddExcerptTagApplicationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddExcerptTagApplicationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ExcerptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddExcerptTagApplicationRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="tagId"></param>
        /// <param name="weight"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AddExcerptTagApplicationRequest(
            global::System.Guid userId,
            global::System.Guid projectId,
            global::System.Guid resourceId,
            global::System.Guid excerptId,
            global::System.Guid tagId,
            double? weight)
        {
            this.UserId = userId;
            this.ProjectId = projectId;
            this.ResourceId = resourceId;
            this.ExcerptId = excerptId;
            this.TagId = tagId;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddExcerptTagApplicationRequest" /> class.
        /// </summary>
        public AddExcerptTagApplicationRequest()
        {
        }
    }
}