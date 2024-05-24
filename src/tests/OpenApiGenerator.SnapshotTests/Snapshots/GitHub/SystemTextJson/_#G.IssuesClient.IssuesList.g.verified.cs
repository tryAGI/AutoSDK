//HintName: G.IssuesClient.IssuesList.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        /// <summary>
        /// List issues assigned to the authenticated user
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="state"></param>
        /// <param name="labels"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="since"></param>
        /// <param name="collab"></param>
        /// <param name="orgs"></param>
        /// <param name="owned"></param>
        /// <param name="pulls"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task IssuesListAsync(
            string filter,
            string state,
            string labels,
            string sort,
            string direction,
            global::System.DateTime since,
            bool collab,
            bool orgs,
            bool owned,
            bool pulls,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/issues?filter={filter}&state={state}&labels={labels}&sort={sort}&direction={direction}&since={since}&collab={collab}&orgs={orgs}&owned={owned}&pulls={pulls}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}