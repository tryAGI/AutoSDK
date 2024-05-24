//HintName: G.CodespacesClient.CodespacesPreFlightWithRepoForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class CodespacesClient
    {
        /// <summary>
        /// Get default attributes for a codespace
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="@ref"></param>
        /// <param name="clientIp"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CodespacesPreFlightWithRepoForAuthenticatedUserAsync(
            string owner,
            string repo,
            string @ref,
            string clientIp,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/codespaces/new?ref={@ref}&client_ip={clientIp}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}