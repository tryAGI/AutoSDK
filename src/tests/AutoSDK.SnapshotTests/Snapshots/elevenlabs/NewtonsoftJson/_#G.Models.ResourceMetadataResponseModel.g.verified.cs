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
        [global::Newtonsoft.Json.JsonProperty("resource_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResourceId { get; set; } = default!;

        /// <summary>
        /// Resource types that can be shared in the workspace. The name always need to match the collection names
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WorkspaceResourceType ResourceType { get; set; } = default!;

        /// <summary>
        /// The ID of the user who created the resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator_user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string? CreatorUserId { get; set; } = default!;

        /// <summary>
        /// A mapping of roles to group IDs. When the resource is shared with a user, the group id is the user's id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role_to_group_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> RoleToGroupIds { get; set; } = default!;

        /// <summary>
        /// List of options for sharing the resource further in the workspace. These are users who don't have access to the resource yet.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("share_options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ShareOptionResponseModel> ShareOptions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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