//HintName: G.CodespacesClient.CodespacesDeleteFromOrganization.g.cs

#nullable enable

namespace G
{
    public partial class CodespacesClient
    {
        /// <summary>
        /// Delete a codespace from the organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="username"></param>
        /// <param name="codespaceName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CodespacesDeleteFromOrganizationAsync(
            string org,
            string username,
            string codespaceName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/members/{username}/codespaces/{codespaceName}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}