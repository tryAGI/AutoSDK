//HintName: G.Models.AddTagLinkRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTagLinkRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("tag1Id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Tag1Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag2Id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Tag2Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isParentChildLink")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsParentChildLink { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTagLinkRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tag1Id"></param>
        /// <param name="tag2Id"></param>
        /// <param name="isParentChildLink"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddTagLinkRequest(
            global::System.Guid projectId,
            global::System.Guid tag1Id,
            global::System.Guid tag2Id,
            bool isParentChildLink)
        {
            this.ProjectId = projectId;
            this.Tag1Id = tag1Id;
            this.Tag2Id = tag2Id;
            this.IsParentChildLink = isParentChildLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTagLinkRequest" /> class.
        /// </summary>
        public AddTagLinkRequest()
        {
        }
    }
}