//HintName: G.SecretScanningClient.SecretScanningListAlertsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class SecretScanningClient
    {
        partial void PrepareSecretScanningListAlertsForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref global::G.SecretScanningListAlertsForRepoState? state,
            ref string? secretType,
            ref string? resolution,
            ref global::G.SecretScanningListAlertsForRepoSort? sort,
            ref global::G.SecretScanningListAlertsForRepoDirection? direction,
            ref int page,
            ref int perPage,
            ref string? before,
            ref string? after,
            ref string? validity);
        partial void PrepareSecretScanningListAlertsForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.SecretScanningListAlertsForRepoState? state,
            string? secretType,
            string? resolution,
            global::G.SecretScanningListAlertsForRepoSort? sort,
            global::G.SecretScanningListAlertsForRepoDirection? direction,
            int page,
            int perPage,
            string? before,
            string? after,
            string? validity);
        partial void ProcessSecretScanningListAlertsForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecretScanningListAlertsForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List secret scanning alerts for a repository<br/>
        /// Lists secret scanning alerts for an eligible repository, from newest to oldest.<br/>
        /// The authenticated user must be an administrator for the repository or for the organization that owns the repository to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="resolution"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SecretScanningAlert>> SecretScanningListAlertsForRepoAsync(
            string owner,
            string repo,
            global::G.SecretScanningListAlertsForRepoState? state,
            string? secretType,
            string? resolution,
            global::G.SecretScanningListAlertsForRepoSort? sort,
            global::G.SecretScanningListAlertsForRepoDirection? direction,
            int page,
            int perPage,
            string? before,
            string? after,
            string? validity,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSecretScanningListAlertsForRepoArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                state: ref state,
                secretType: ref secretType,
                resolution: ref resolution,
                sort: ref sort,
                direction: ref direction,
                page: ref page,
                perPage: ref perPage,
                before: ref before,
                after: ref after,
                validity: ref validity);

            var stateValue = state switch
            {
                global::G.SecretScanningListAlertsForRepoState.Open => "open",
                global::G.SecretScanningListAlertsForRepoState.Resolved => "resolved",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.SecretScanningListAlertsForRepoSort.Created => "created",
                global::G.SecretScanningListAlertsForRepoSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.SecretScanningListAlertsForRepoDirection.Asc => "asc",
                global::G.SecretScanningListAlertsForRepoDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/secret-scanning/alerts?state={(global::System.Uri.EscapeDataString(stateValue?.ToString() ?? string.Empty))}&secret_type={secretType}&resolution={resolution}&sort={(global::System.Uri.EscapeDataString(sortValue?.ToString() ?? string.Empty))}&direction={(global::System.Uri.EscapeDataString(directionValue?.ToString() ?? string.Empty))}&page={page}&per_page={perPage}&before={before}&after={after}&validity={validity}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSecretScanningListAlertsForRepoRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                state: state,
                secretType: secretType,
                resolution: resolution,
                sort: sort,
                direction: direction,
                page: page,
                perPage: perPage,
                before: before,
                after: after,
                validity: validity);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSecretScanningListAlertsForRepoResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSecretScanningListAlertsForRepoResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.SecretScanningAlert>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}