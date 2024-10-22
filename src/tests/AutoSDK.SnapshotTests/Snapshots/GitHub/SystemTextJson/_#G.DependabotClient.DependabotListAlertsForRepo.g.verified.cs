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
            ref int? page,
            ref int? perPage,
            ref string? before,
            ref string? after,
            ref int? first,
            ref int? last);
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
            int? page,
            int? perPage,
            string? before,
            string? after,
            int? first,
            int? last);
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
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            string? manifest = default,
            global::G.DependabotListAlertsForRepoScope? scope = default,
            global::G.DependabotListAlertsForRepoSort? sort = global::G.DependabotListAlertsForRepoSort.Created,
            global::G.DependabotListAlertsForRepoDirection? direction = global::G.DependabotListAlertsForRepoDirection.Desc,
            int? page = 1,
            int? perPage = 30,
            string? before = default,
            string? after = default,
            int? first = 30,
            int? last = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDependabotListAlertsForRepoArguments(
                httpClient: HttpClient,
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

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/dependabot/alerts",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("state", state) 
                .AddOptionalParameter("severity", severity) 
                .AddOptionalParameter("ecosystem", ecosystem) 
                .AddOptionalParameter("package", package) 
                .AddOptionalParameter("manifest", manifest) 
                .AddOptionalParameter("scope", scope?.ToValueString()) 
                .AddOptionalParameter("sort", sort?.ToValueString()) 
                .AddOptionalParameter("direction", direction?.ToValueString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("before", before) 
                .AddOptionalParameter("after", after) 
                .AddOptionalParameter("first", first?.ToString()) 
                .AddOptionalParameter("last", last?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDependabotListAlertsForRepoRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDependabotListAlertsForRepoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessDependabotListAlertsForRepoResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.DependabotAlert>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}