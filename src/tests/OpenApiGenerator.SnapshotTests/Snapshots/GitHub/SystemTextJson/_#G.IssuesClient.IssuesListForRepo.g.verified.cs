//HintName: G.IssuesClient.IssuesListForRepo.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        /// <summary>
        /// List repository issues
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="milestone"></param>
        /// <param name="state"></param>
        /// <param name="assignee"></param>
        /// <param name="creator"></param>
        /// <param name="mentioned"></param>
        /// <param name="labels"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="since"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task IssuesListForRepoAsync(
            string owner,
            string repo,
            string milestone,
            string state,
            string assignee,
            string creator,
            string mentioned,
            string labels,
            string sort,
            string direction,
            global::System.DateTime since,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/issues?milestone={milestone}&state={state}&assignee={assignee}&creator={creator}&mentioned={mentioned}&labels={labels}&sort={sort}&direction={direction}&since={since}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}