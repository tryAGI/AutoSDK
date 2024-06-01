//HintName: G.ReposClient.ReposUpdateRepoRuleset.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Update a repository ruleset
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RepositoryRuleset> ReposUpdateRepoRulesetAsync(
            string owner,
            string repo,
            int rulesetId,
            ReposUpdateRepoRulesetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/rulesets/{rulesetId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<RepositoryRuleset?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a repository ruleset
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="name"></param>
        /// <param name="target"></param>
        /// <param name="enforcement"></param>
        /// <param name="bypassActors"></param>
        /// <param name="conditions"></param>
        /// <param name="rules"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RepositoryRuleset> ReposUpdateRepoRulesetAsync(
            string owner,
            string repo,
            int rulesetId,
            string? name = default,
            ReposUpdateRepoRulesetRequestTarget? target = default,
            ReposUpdateRepoRulesetRequestEnforcement? enforcement = default,
            global::System.Collections.Generic.IList<RepositoryRulesetBypassActor>? bypassActors = default,
            RepositoryRulesetConditions? conditions = default,
            global::System.Collections.Generic.IList<RepositoryRule>? rules = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposUpdateRepoRulesetRequest
            {
                Name = name,
                Target = target,
                Enforcement = enforcement,
                BypassActors = bypassActors,
                Conditions = conditions,
                Rules = rules,
            };

            return await ReposUpdateRepoRulesetAsync(
                owner: owner,
                repo: repo,
                rulesetId: rulesetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}