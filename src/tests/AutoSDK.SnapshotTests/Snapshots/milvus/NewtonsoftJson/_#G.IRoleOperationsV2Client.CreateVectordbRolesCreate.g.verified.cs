//HintName: G.IRoleOperationsV2Client.CreateVectordbRolesCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IRoleOperationsV2Client
    {
        /// <summary>
        /// Create Role<br/>
        /// This operation creates the current role. 
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbRolesCreateAsync(

            global::G.RoleName request,
            int? requestTimeout = default,
            string? authorization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Role<br/>
        /// This operation creates the current role. 
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="authorization"></param>
        /// <param name="roleName1">
        /// The name of the role.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateVectordbRolesCreateAsync(
            string roleName1,
            int? requestTimeout = default,
            string? authorization = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}