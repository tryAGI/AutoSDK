//HintName: G.IApi.CorporaPermissionsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deletes the permission.
        /// </summary>
        /// <param name="permissionsId"></param>
        /// <param name="corporaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Empty> CorporaPermissionsDeleteAsync(
            string permissionsId,
            string corporaId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}