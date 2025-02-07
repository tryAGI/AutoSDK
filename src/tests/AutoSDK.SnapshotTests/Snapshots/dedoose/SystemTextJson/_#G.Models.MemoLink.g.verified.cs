//HintName: G.Models.MemoLink.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoLink
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectIdKey")]
        public string? ProjectIdKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoId")]
        public global::System.Guid? MemoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        public global::System.Guid? ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptId")]
        public global::System.Guid? ExcerptId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptorId")]
        public global::System.Guid? DescriptorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagId")]
        public global::System.Guid? TagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createStamp")]
        public global::System.DateTime? CreateStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createUserId")]
        public global::System.Guid? CreateUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoLink" /> class.
        /// </summary>
        /// <param name="projectIdKey"></param>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="memoId"></param>
        /// <param name="resourceId"></param>
        /// <param name="excerptId"></param>
        /// <param name="descriptorId"></param>
        /// <param name="tagId"></param>
        /// <param name="createStamp"></param>
        /// <param name="createUserId"></param>
        /// <param name="position"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoLink(
            string? projectIdKey,
            global::System.Guid? id,
            global::System.Guid? projectId,
            global::System.Guid? memoId,
            global::System.Guid? resourceId,
            global::System.Guid? excerptId,
            global::System.Guid? descriptorId,
            global::System.Guid? tagId,
            global::System.DateTime? createStamp,
            global::System.Guid? createUserId,
            int? position)
        {
            this.ProjectIdKey = projectIdKey;
            this.Id = id;
            this.ProjectId = projectId;
            this.MemoId = memoId;
            this.ResourceId = resourceId;
            this.ExcerptId = excerptId;
            this.DescriptorId = descriptorId;
            this.TagId = tagId;
            this.CreateStamp = createStamp;
            this.CreateUserId = createUserId;
            this.Position = position;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoLink" /> class.
        /// </summary>
        public MemoLink()
        {
        }
    }
}