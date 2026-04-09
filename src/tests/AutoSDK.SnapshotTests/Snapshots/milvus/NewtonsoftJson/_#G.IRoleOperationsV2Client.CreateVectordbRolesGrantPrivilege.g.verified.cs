//HintName: G.IRoleOperationsV2Client.CreateVectordbRolesGrantPrivilege.g.cs
#nullable enable

namespace G
{
    public partial interface IRoleOperationsV2Client
    {
        /// <summary>
        /// Grant Privilege To Role<br/>
        /// This operation grants a privilege to the current role.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbRolesGrantPrivilegeAsync(

            global::G.CreateVectordbRolesGrantPrivilegeRequest request,
            int? requestTimeout = default,
            string? authorization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Grant Privilege To Role<br/>
        /// This operation grants a privilege to the current role.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="roleName">
        /// The name of the role.
        /// </param>
        /// <param name="objectType">
        ///  The type of the object to which the privilege belongs.
        /// </param>
        /// <param name="objectName">
        ///  The name of the object to which the role is granted the specified privilege.
        /// </param>
        /// <param name="privilege">
        ///  The privilege that is granted to the role.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbRolesGrantPrivilegeAsync(
            string roleName,
            string objectType,
            string objectName,
            string privilege,
            int? requestTimeout = default,
            string? authorization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}