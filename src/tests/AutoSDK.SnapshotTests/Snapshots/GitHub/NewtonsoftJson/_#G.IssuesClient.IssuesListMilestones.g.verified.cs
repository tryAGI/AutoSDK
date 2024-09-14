//HintName: G.IssuesClient.IssuesListMilestones.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        partial void PrepareIssuesListMilestonesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref global::G.IssuesListMilestonesState? state,
            ref global::G.IssuesListMilestonesSort? sort,
            ref global::G.IssuesListMilestonesDirection? direction,
            ref int perPage,
            ref int page);
        partial void PrepareIssuesListMilestonesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.IssuesListMilestonesState? state,
            global::G.IssuesListMilestonesSort? sort,
            global::G.IssuesListMilestonesDirection? direction,
            int perPage,
            int page);
        partial void ProcessIssuesListMilestonesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIssuesListMilestonesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List milestones<br/>
        /// Lists milestones for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state">
        /// Default Value: open
        /// </param>
        /// <param name="sort">
        /// Default Value: due_on
        /// </param>
        /// <param name="direction">
        /// Default Value: asc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Milestone>> IssuesListMilestonesAsync(
            string owner,
            string repo,
            global::G.IssuesListMilestonesState? state = global::G.IssuesListMilestonesState.Open,
            global::G.IssuesListMilestonesSort? sort = global::G.IssuesListMilestonesSort.DueOn,
            global::G.IssuesListMilestonesDirection? direction = global::G.IssuesListMilestonesDirection.Asc,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareIssuesListMilestonesArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                state: ref state,
                sort: ref sort,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page);

            var stateValue = state switch
            {
                global::G.IssuesListMilestonesState.Open => "open",
                global::G.IssuesListMilestonesState.Closed => "closed",
                global::G.IssuesListMilestonesState.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.IssuesListMilestonesSort.DueOn => "due_on",
                global::G.IssuesListMilestonesSort.Completeness => "completeness",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.IssuesListMilestonesDirection.Asc => "asc",
                global::G.IssuesListMilestonesDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/milestones?state={(global::System.Uri.EscapeDataString(stateValue?.ToString() ?? string.Empty))}&sort={(global::System.Uri.EscapeDataString(sortValue?.ToString() ?? string.Empty))}&direction={(global::System.Uri.EscapeDataString(directionValue?.ToString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareIssuesListMilestonesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                state: state,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessIssuesListMilestonesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessIssuesListMilestonesResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Milestone>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}