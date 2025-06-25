//HintName: G.Models.ResourceMetadataResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceMetadataResponseModel
    {
        /// <summary>
        /// The ID of the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceId { get; set; }

        /// <summary>
        /// Resource types that can be shared in the workspace. The name always need to match the collection names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WorkspaceResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WorkspaceResourceType ResourceType { get; set; }

        /// <summary>
        /// The ID of the user who created the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CreatorUserId { get; set; }

        /// <summary>
        /// A mapping of roles to group IDs. When the resource is shared with a user, the group id is the user's id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_to_group_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> RoleToGroupIds { get; set; }

        /// <summary>
        /// List of options for sharing the resource further in the workspace. These are users who don't have access to the resource yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ShareOptionResponseModel> ShareOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceMetadataResponseModel" /> class.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the resource.
        /// </param>
        /// <param name="resourceType">
        /// Resource types that can be shared in the workspace. The name always need to match the collection names
        /// </param>
        /// <param name="creatorUserId">
        /// The ID of the user who created the resource.
        /// </param>
        /// <param name="roleToGroupIds">
        /// A mapping of roles to group IDs. When the resource is shared with a user, the group id is the user's id.
        /// </param>
        /// <param name="shareOptions">
        /// List of options for sharing the resource further in the workspace. These are users who don't have access to the resource yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceMetadataResponseModel(
            string resourceId,
            global::G.WorkspaceResourceType resourceType,
            string? creatorUserId,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> roleToGroupIds,
            global::System.Collections.Generic.IList<global::G.ShareOptionResponseModel> shareOptions)
        {
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
            this.ResourceType = resourceType;
            this.CreatorUserId = creatorUserId ?? throw new global::System.ArgumentNullException(nameof(creatorUserId));
            this.RoleToGroupIds = roleToGroupIds ?? throw new global::System.ArgumentNullException(nameof(roleToGroupIds));
            this.ShareOptions = shareOptions ?? throw new global::System.ArgumentNullException(nameof(shareOptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceMetadataResponseModel" /> class.
        /// </summary>
        public ResourceMetadataResponseModel()
        {
        }
    }
}