//HintName: G.ReposClient.ReposUpdateRepoRuleset.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposUpdateRepoRulesetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int rulesetId,
            global::G.ReposUpdateRepoRulesetRequest request);
        partial void PrepareReposUpdateRepoRulesetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int rulesetId,
            global::G.ReposUpdateRepoRulesetRequest request);
        partial void ProcessReposUpdateRepoRulesetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposUpdateRepoRulesetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a repository ruleset<br/>
        /// Update a ruleset for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RepositoryRuleset> ReposUpdateRepoRulesetAsync(
            string owner,
            string repo,
            int rulesetId,
            global::G.ReposUpdateRepoRulesetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposUpdateRepoRulesetArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                rulesetId: ref rulesetId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/rulesets/{rulesetId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposUpdateRepoRulesetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                rulesetId: rulesetId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposUpdateRepoRulesetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposUpdateRepoRulesetResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.RepositoryRuleset?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a repository ruleset<br/>
        /// Update a ruleset for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="name">
        /// The name of the ruleset.
        /// </param>
        /// <param name="target">
        /// The target of the ruleset<br/>
        /// **Note**: The `push` target is in beta and is subject to change.
        /// </param>
        /// <param name="enforcement">
        /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
        /// </param>
        /// <param name="bypassActors">
        /// The actors that can bypass the rules in this ruleset
        /// </param>
        /// <param name="conditions">
        /// Parameters for a repository ruleset ref name condition
        /// </param>
        /// <param name="rules">
        /// An array of rules within the ruleset.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RepositoryRuleset> ReposUpdateRepoRulesetAsync(
            string owner,
            string repo,
            int rulesetId,
            string? name = default,
            global::G.ReposUpdateRepoRulesetRequestTarget? target = default,
            global::G.RepositoryRuleEnforcement? enforcement = default,
            global::System.Collections.Generic.IList<global::G.RepositoryRulesetBypassActor>? bypassActors = default,
            global::G.RepositoryRulesetConditions? conditions = default,
            global::System.Collections.Generic.IList<global::G.RepositoryRule>? rules = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposUpdateRepoRulesetRequest
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