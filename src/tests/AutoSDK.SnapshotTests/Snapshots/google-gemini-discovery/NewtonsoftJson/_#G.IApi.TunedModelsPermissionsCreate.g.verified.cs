//HintName: G.IApi.TunedModelsPermissionsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Permission> TunedModelsPermissionsCreateAsync(
            string tunedModelsId,

            global::G.Permission request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a permission to a specific resource.
        /// </summary>
        /// <param name="tunedModelsId"></param>
        /// <param name="granteeType">
        /// Optional. Immutable. The type of the grantee.
        /// </param>
        /// <param name="emailAddress">
        /// Optional. Immutable. The email address of the user of group which this permission refers. Field is not set when permission's grantee type is EVERYONE.
        /// </param>
        /// <param name="role">
        /// Required. The role granted by this permission.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Permission> TunedModelsPermissionsCreateAsync(
            string tunedModelsId,
            global::G.PermissionGranteeType? granteeType = default,
            string? emailAddress = default,
            global::G.PermissionRole? role = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}