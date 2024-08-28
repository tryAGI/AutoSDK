//HintName: G.ReposClient.ListRepos.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareListReposArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int limit,
            ref int offset,
            ref global::System.AnyOf<string, object>? tenantHandle,
            ref global::System.AnyOf<string, object>? tenantId,
            ref global::System.AnyOf<string, object>? query,
            ref global::System.AnyOf<bool?, object>? hasCommits,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tags,
            ref global::System.AnyOf<global::G.ListReposApiV1ReposGetIsArchived2?, object>? isArchived,
            ref global::System.AnyOf<global::G.ListReposApiV1ReposGetIsPublic2?, object>? isPublic,
            ref global::System.AnyOf<string, object>? upstreamRepoOwner,
            ref global::System.AnyOf<string, object>? upstreamRepoHandle,
            ref global::System.AnyOf<bool?, object>? matchPrefix,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId,
            ref global::System.AnyOf<string, object>? sortField,
            ref global::System.AnyOf<global::G.ListReposApiV1ReposGetSortDirectionVariant1?, global::G.ListReposApiV1ReposGetSortDirectionVariant2?, object>? sortDirection);
        partial void PrepareListReposRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int limit,
            int offset,
            global::System.AnyOf<string, object>? tenantHandle,
            global::System.AnyOf<string, object>? tenantId,
            global::System.AnyOf<string, object>? query,
            global::System.AnyOf<bool?, object>? hasCommits,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tags,
            global::System.AnyOf<global::G.ListReposApiV1ReposGetIsArchived2?, object>? isArchived,
            global::System.AnyOf<global::G.ListReposApiV1ReposGetIsPublic2?, object>? isPublic,
            global::System.AnyOf<string, object>? upstreamRepoOwner,
            global::System.AnyOf<string, object>? upstreamRepoHandle,
            global::System.AnyOf<bool?, object>? matchPrefix,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId,
            global::System.AnyOf<string, object>? sortField,
            global::System.AnyOf<global::G.ListReposApiV1ReposGetSortDirectionVariant1?, global::G.ListReposApiV1ReposGetSortDirectionVariant2?, object>? sortDirection);
        partial void ProcessListReposResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListReposResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Repos<br/>
        /// Get all repos.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="tenantHandle"></param>
        /// <param name="tenantId"></param>
        /// <param name="query"></param>
        /// <param name="hasCommits"></param>
        /// <param name="tags"></param>
        /// <param name="isArchived"></param>
        /// <param name="isPublic"></param>
        /// <param name="upstreamRepoOwner"></param>
        /// <param name="upstreamRepoHandle"></param>
        /// <param name="matchPrefix">
        /// Default Value: false
        /// </param>
        /// <param name="tagValueId"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListReposResponse> ListReposAsync(
            int limit,
            int offset,
            global::System.AnyOf<string, object>? tenantHandle,
            global::System.AnyOf<string, object>? tenantId,
            global::System.AnyOf<string, object>? query,
            global::System.AnyOf<bool?, object>? hasCommits,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tags,
            global::System.AnyOf<global::G.ListReposApiV1ReposGetIsArchived2?, object>? isArchived,
            global::System.AnyOf<global::G.ListReposApiV1ReposGetIsPublic2?, object>? isPublic,
            global::System.AnyOf<string, object>? upstreamRepoOwner,
            global::System.AnyOf<string, object>? upstreamRepoHandle,
            global::System.AnyOf<bool?, object>? matchPrefix,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId,
            global::System.AnyOf<string, object>? sortField,
            global::System.AnyOf<global::G.ListReposApiV1ReposGetSortDirectionVariant1?, global::G.ListReposApiV1ReposGetSortDirectionVariant2?, object>? sortDirection,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListReposArguments(
                httpClient: _httpClient,
                limit: ref limit,
                offset: ref offset,
                tenantHandle: ref tenantHandle,
                tenantId: ref tenantId,
                query: ref query,
                hasCommits: ref hasCommits,
                tags: ref tags,
                isArchived: ref isArchived,
                isPublic: ref isPublic,
                upstreamRepoOwner: ref upstreamRepoOwner,
                upstreamRepoHandle: ref upstreamRepoHandle,
                matchPrefix: ref matchPrefix,
                tagValueId: ref tagValueId,
                sortField: ref sortField,
                sortDirection: ref sortDirection);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/repos?limit={limit}&offset={offset}&tenant_handle={tenantHandle}&tenant_id={tenantId}&query={query}&has_commits={hasCommits}&tags={tags}&is_archived={isArchived}&is_public={isPublic}&upstream_repo_owner={upstreamRepoOwner}&upstream_repo_handle={upstreamRepoHandle}&match_prefix={matchPrefix}&tag_value_id={tagValueId}&sort_field={sortField}&sort_direction={sortDirection}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListReposRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                limit: limit,
                offset: offset,
                tenantHandle: tenantHandle,
                tenantId: tenantId,
                query: query,
                hasCommits: hasCommits,
                tags: tags,
                isArchived: isArchived,
                isPublic: isPublic,
                upstreamRepoOwner: upstreamRepoOwner,
                upstreamRepoHandle: upstreamRepoHandle,
                matchPrefix: matchPrefix,
                tagValueId: tagValueId,
                sortField: sortField,
                sortDirection: sortDirection);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListReposResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListReposResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListReposResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}