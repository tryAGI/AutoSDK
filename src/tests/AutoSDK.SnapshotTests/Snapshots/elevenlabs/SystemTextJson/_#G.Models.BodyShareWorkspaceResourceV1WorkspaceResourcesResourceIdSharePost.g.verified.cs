//HintName: G.Models.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost
    {
        /// <summary>
        /// Role to update the target principal with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole Role { get; set; }

        /// <summary>
        /// Resource type of the target resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WorkspaceResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WorkspaceResourceType ResourceType { get; set; }

        /// <summary>
        /// The email of the user or service account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// The ID of the target group. To target the permissions principals have by default on this resource, use the value 'default'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? GroupId { get; set; }

        /// <summary>
        /// The ID of the target workspace API key. This isn't the same as the key itself that would you pass in the header for authentication. Workspace admins can find this in the workspace settings UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_api_key_id")]
        public string? WorkspaceApiKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost" /> class.
        /// </summary>
        /// <param name="role">
        /// Role to update the target principal with.
        /// </param>
        /// <param name="resourceType">
        /// Resource type of the target resource.
        /// </param>
        /// <param name="userEmail">
        /// The email of the user or service account.
        /// </param>
        /// <param name="groupId">
        /// The ID of the target group. To target the permissions principals have by default on this resource, use the value 'default'.
        /// </param>
        /// <param name="workspaceApiKeyId">
        /// The ID of the target workspace API key. This isn't the same as the key itself that would you pass in the header for authentication. Workspace admins can find this in the workspace settings UI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost(
            global::G.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole role,
            global::G.WorkspaceResourceType resourceType,
            string? userEmail,
            string? groupId,
            string? workspaceApiKeyId)
        {
            this.Role = role;
            this.ResourceType = resourceType;
            this.UserEmail = userEmail;
            this.GroupId = groupId;
            this.WorkspaceApiKeyId = workspaceApiKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost" /> class.
        /// </summary>
        public BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost()
        {
        }
    }
}