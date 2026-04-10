//HintName: G.IScimClient.ScimListUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IScimClient
    {
        /// <summary>
        /// List users in the organization (requires organization-scoped API key)
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="startIndex"></param>
        /// <param name="count"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ScimUsersListResponse> ScimListUsersAsync(
            string? filter = default,
            int? startIndex = default,
            int? count = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}