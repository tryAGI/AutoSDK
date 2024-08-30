//HintName: G.DependabotClient.DependabotListAlertsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class DependabotClient
    {
        partial void PrepareDependabotListAlertsForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string? state,
            ref string? severity,
            ref string? ecosystem,
            ref string? package,
            ref string? manifest,
            ref global::G.DependabotListAlertsForRepoScope? scope,
            ref global::G.DependabotListAlertsForRepoSort? sort,
            ref global::G.DependabotListAlertsForRepoDirection? direction,
            ref int page,
            ref int perPage,
            ref string? before,
            ref string? after,
            ref int first,
            ref int last);
        partial void PrepareDependabotListAlertsForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string? state,
            string? severity,
            string? ecosystem,
            string? package,
            string? manifest,
            global::G.DependabotListAlertsForRepoScope? scope,
            global::G.DependabotListAlertsForRepoSort? sort,
            global::G.DependabotListAlertsForRepoDirection? direction,
            int page,
            int perPage,
            string? before,
            string? after,
            int first,
            int last);
        partial void ProcessDependabotListAlertsForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDependabotListAlertsForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Dependabot alerts for a repository<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="manifest"></param>
        /// <param name="scope"></param>
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
        /// <param name="first">
        /// Default Value: 30
        /// </param>
        /// <param name="last"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DependabotAlert>> DependabotListAlertsForRepoAsync(
            string owner,
            string repo,
            string? state,
            string? severity,
            string? ecosystem,
            string? package,
            string? manifest,
            global::G.DependabotListAlertsForRepoScope? scope,
            global::G.DependabotListAlertsForRepoSort? sort,
            global::G.DependabotListAlertsForRepoDirection? direction,
            int page,
            int perPage,
            string? before,
            string? after,
            int first,
            int last,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDependabotListAlertsForRepoArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                state: ref state,
                severity: ref severity,
                ecosystem: ref ecosystem,
                package: ref package,
                manifest: ref manifest,
                scope: ref scope,
                sort: ref sort,
                direction: ref direction,
                page: ref page,
                perPage: ref perPage,
                before: ref before,
                after: ref after,
                first: ref first,
                last: ref last);

            var scopeValue = scope switch
            {
                global::G.DependabotListAlertsForRepoScope.Development => "development",
                global::G.DependabotListAlertsForRepoScope.Runtime => "runtime",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.DependabotListAlertsForRepoSort.Created => "created",
                global::G.DependabotListAlertsForRepoSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.DependabotListAlertsForRepoDirection.Asc => "asc",
                global::G.DependabotListAlertsForRepoDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/dependabot/alerts?state={state}&severity={severity}&ecosystem={ecosystem}&package={package}&manifest={manifest}&scope={(global::System.Uri.EscapeDataString(scopeValue?.ToString() ?? string.Empty))}&sort={(global::System.Uri.EscapeDataString(sortValue?.ToString() ?? string.Empty))}&direction={(global::System.Uri.EscapeDataString(directionValue?.ToString() ?? string.Empty))}&page={page}&per_page={perPage}&before={before}&after={after}&first={first}&last={last}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDependabotListAlertsForRepoRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                state: state,
                severity: severity,
                ecosystem: ecosystem,
                package: package,
                manifest: manifest,
                scope: scope,
                sort: sort,
                direction: direction,
                page: page,
                perPage: perPage,
                before: before,
                after: after,
                first: first,
                last: last);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDependabotListAlertsForRepoResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDependabotListAlertsForRepoResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.DependabotAlert>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}