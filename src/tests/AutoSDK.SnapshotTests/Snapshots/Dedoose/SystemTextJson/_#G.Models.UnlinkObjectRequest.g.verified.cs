//HintName: G.Models.UnlinkObjectRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnlinkObjectRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("memoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MemoId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DescriptorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TagId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlinkObjectRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="tagId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UnlinkObjectRequest(
            global::System.Guid projectId,
            global::System.Guid memoId,
            global::System.Guid resourceId,
            global::System.Guid excerptId,
            global::System.Guid descriptorId,
            global::System.Guid tagId)
        {
            this.ProjectId = projectId;
            this.MemoId = memoId;
            this.ResourceId = resourceId;
            this.ExcerptId = excerptId;
            this.DescriptorId = descriptorId;
            this.TagId = tagId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlinkObjectRequest" /> class.
        /// </summary>
        public UnlinkObjectRequest()
        {
        }
    }
}