//HintName: G.DependabotClient.DependabotSetSelectedReposForOrgSecret.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        /// <summary>
        /// Set selected repositories for an organization secret
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DependabotSetSelectedReposForOrgSecretAsync(
            string org,
            string secretName,
            DependabotSetSelectedReposForOrgSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/dependabot/secrets/{secretName}/repositories", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Set selected repositories for an organization secret
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="selectedRepositoryIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DependabotSetSelectedReposForOrgSecretAsync(
            string org,
            string secretName,
            global::System.Collections.Generic.IList<int> selectedRepositoryIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new DependabotSetSelectedReposForOrgSecretRequest
            {
                SelectedRepositoryIds = selectedRepositoryIds,
            };

            await DependabotSetSelectedReposForOrgSecretAsync(
                org: org,
                secretName: secretName,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}