//HintName: G.DependabotClient.DependabotSetSelectedReposForOrgSecret.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        partial void PrepareDependabotSetSelectedReposForOrgSecretArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string secretName,
            global::G.DependabotSetSelectedReposForOrgSecretRequest request);
        partial void PrepareDependabotSetSelectedReposForOrgSecretRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string secretName,
            global::G.DependabotSetSelectedReposForOrgSecretRequest request);
        partial void ProcessDependabotSetSelectedReposForOrgSecretResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Set selected repositories for an organization secret<br/>
        /// Replaces all repositories for an organization secret when the `visibility`<br/>
        /// for repository access is set to `selected`. The visibility is set when you [Create<br/>
        /// or update an organization secret](https://docs.github.com/rest/dependabot/secrets#create-or-update-an-organization-secret).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DependabotSetSelectedReposForOrgSecretAsync(
            string org,
            string secretName,
            global::G.DependabotSetSelectedReposForOrgSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareDependabotSetSelectedReposForOrgSecretArguments(
                httpClient: _httpClient,
                org: ref org,
                secretName: ref secretName,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/dependabot/secrets/{secretName}/repositories", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDependabotSetSelectedReposForOrgSecretRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                secretName: secretName,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDependabotSetSelectedReposForOrgSecretResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Set selected repositories for an organization secret<br/>
        /// Replaces all repositories for an organization secret when the `visibility`<br/>
        /// for repository access is set to `selected`. The visibility is set when you [Create<br/>
        /// or update an organization secret](https://docs.github.com/rest/dependabot/secrets#create-or-update-an-organization-secret).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="secretName"></param>
        /// <param name="selectedRepositoryIds">
        /// An array of repository ids that can access the organization secret. You can only provide a list of repository ids when the `visibility` is set to `selected`. You can add and remove individual repositories using the [Set selected repositories for an organization secret](https://docs.github.com/rest/dependabot/secrets#set-selected-repositories-for-an-organization-secret) and [Remove selected repository from an organization secret](https://docs.github.com/rest/dependabot/secrets#remove-selected-repository-from-an-organization-secret) endpoints.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task DependabotSetSelectedReposForOrgSecretAsync(
            string org,
            string secretName,
            global::System.Collections.Generic.IList<int> selectedRepositoryIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.DependabotSetSelectedReposForOrgSecretRequest
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