//HintName: G.Models.CreateCollectionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCollectionsRequest
    {
        /// <summary>
        /// ID or slug of the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Name of the collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ID or slug of the parent collection (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_collection_id")]
        public string? ParentCollectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the collection
        /// </param>
        /// <param name="workspaceId">
        /// ID or slug of the workspace
        /// </param>
        /// <param name="parentCollectionId">
        /// ID or slug of the parent collection (optional)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionsRequest(
            string name,
            string? workspaceId,
            string? parentCollectionId)
        {
            this.WorkspaceId = workspaceId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ParentCollectionId = parentCollectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionsRequest" /> class.
        /// </summary>
        public CreateCollectionsRequest()
        {
        }
    }
}