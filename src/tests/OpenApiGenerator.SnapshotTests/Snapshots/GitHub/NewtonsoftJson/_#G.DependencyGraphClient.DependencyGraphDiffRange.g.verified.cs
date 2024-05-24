//HintName: G.DependencyGraphClient.DependencyGraphDiffRange.g.cs

#nullable enable

namespace G
{
    public partial class DependencyGraphClient
    {
        /// <summary>
        /// Get a diff of the dependencies between commits
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="basehead"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<DependencyGraphDiff> DependencyGraphDiffRangeAsync(
            string owner,
            string repo,
            string basehead,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/dependency-graph/compare/{basehead}?name={name}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<DependencyGraphDiff>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}