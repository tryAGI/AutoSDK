//HintName: G.ReposClient.ReposUpdateOrgRuleset.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Update an organization repository ruleset
        /// </summary>
        /// <param name="org"></param>
        /// <param name="rulesetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RepositoryRuleset> ReposUpdateOrgRulesetAsync(
            string org,
            int rulesetId,
            ReposUpdateOrgRulesetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/rulesets/{rulesetId}", global::System.UriKind.RelativeOrAbsolute));
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
        /// Update an organization repository ruleset
        /// </summary>
        /// <param name="org"></param>
        /// <param name="rulesetId"></param>
        /// <param name="name"></param>
        /// <param name="target"></param>
        /// <param name="enforcement"></param>
        /// <param name="bypassActors"></param>
        /// <param name="conditions"></param>
        /// <param name="rules"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RepositoryRuleset> ReposUpdateOrgRulesetAsync(
            string org,
            int rulesetId,
            string? name = default,
            ReposUpdateOrgRulesetRequestTarget? target = default,
            ReposUpdateOrgRulesetRequestEnforcement? enforcement = default,
            global::System.Collections.Generic.IList<RepositoryRulesetBypassActor>? bypassActors = default,
            OrgRulesetConditions? conditions = default,
            global::System.Collections.Generic.IList<RepositoryRule>? rules = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposUpdateOrgRulesetRequest
            {
                Name = name,
                Target = target,
                Enforcement = enforcement,
                BypassActors = bypassActors,
                Conditions = conditions,
                Rules = rules,
            };

            return await ReposUpdateOrgRulesetAsync(
                org: org,
                rulesetId: rulesetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}