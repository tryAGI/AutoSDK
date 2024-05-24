//HintName: G.ReposClient.ReposGetRepoRuleSuites.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// List repository rule suites
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="@ref"></param>
        /// <param name="timePeriod"></param>
        /// <param name="actorName"></param>
        /// <param name="ruleSuiteResult"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RuleSuites> ReposGetRepoRuleSuitesAsync(
            string owner,
            string repo,
            string @ref,
            string timePeriod,
            string actorName,
            string ruleSuiteResult,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/rulesets/rule-suites?ref={@ref}&time_period={timePeriod}&actor_name={actorName}&rule_suite_result={ruleSuiteResult}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<RuleSuites>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}