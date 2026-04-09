//HintName: G.IApi.CorporaPermissionsPatch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Updates the permission.
        /// </summary>
        /// <param name="permissionsId"></param>
        /// <param name="corporaId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Permission> CorporaPermissionsPatchAsync(
            string permissionsId,
            string corporaId,

            global::G.Permission request,
            string? updateMask = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates the permission.
        /// </summary>
        /// <param name="permissionsId"></param>
        /// <param name="corporaId"></param>
        /// <param name="updateMask"></param>
        /// <param name="granteeType">
        /// Optional. Immutable. The type of the grantee.
        /// </param>
        /// <param name="emailAddress">
        /// Optional. Immutable. The email address of the user of group which this permission refers. Field is not set when permission's grantee type is EVERYONE.
        /// </param>
        /// <param name="role">
        /// Required. The role granted by this permission.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Permission> CorporaPermissionsPatchAsync(
            string permissionsId,
            string corporaId,
            string? updateMask = default,
            global::G.PermissionGranteeType? granteeType = default,
            string? emailAddress = default,
            global::G.PermissionRole? role = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}