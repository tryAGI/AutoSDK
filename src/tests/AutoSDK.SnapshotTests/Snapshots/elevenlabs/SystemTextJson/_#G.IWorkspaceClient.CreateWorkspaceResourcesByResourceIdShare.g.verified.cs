//HintName: G.IWorkspaceClient.CreateWorkspaceResourcesByResourceIdShare.g.cs
#nullable enable

namespace G
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Share Workspace Resource<br/>
        /// Grants a role on a workspace resource to a user or a group. It overrides any existing role this user/group/workspace api key has on the resource. To target a user, pass only the user email. The user must be in your workspace. To target a group, pass only the group id. To target a workspace api key, pass the api key id. You must have admin access to the resource to share it.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the target resource.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWorkspaceResourcesByResourceIdShareAsync(
            string resourceId,
            global::G.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Share Workspace Resource<br/>
        /// Grants a role on a workspace resource to a user or a group. It overrides any existing role this user/group/workspace api key has on the resource. To target a user, pass only the user email. The user must be in your workspace. To target a group, pass only the group id. To target a workspace api key, pass the api key id. You must have admin access to the resource to share it.
        /// </summary>
        /// <param name="resourceId">
        /// The ID of the target resource.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="role">
        /// Role to update the target principal with.
        /// </param>
        /// <param name="resourceType">
        /// Resource types that can be shared in the workspace. The name always need to match the collection names
        /// </param>
        /// <param name="userEmail">
        /// The email of the user
        /// </param>
        /// <param name="groupId">
        /// The ID of the target group. To target the permissions principals have by default on this resource, use the value 'default'.
        /// </param>
        /// <param name="workspaceApiKeyId">
        /// The ID of the target workspace API key. This isn't the same as the key itself that would you pass in the header for authentication. Workspace admins can find this in the workspace settings UI.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWorkspaceResourcesByResourceIdShareAsync(
            string resourceId,
            global::G.BodyShareWorkspaceResourceV1WorkspaceResourcesResourceIdSharePostRole role,
            global::G.WorkspaceResourceType resourceType,
            string? xiApiKey = default,
            string? userEmail = default,
            string? groupId = default,
            string? workspaceApiKeyId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}