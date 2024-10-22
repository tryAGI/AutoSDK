//HintName: G.ReposClient.ReposGetRepoRuleSuites.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposGetRepoRuleSuitesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string? @ref,
            ref global::G.ReposGetRepoRuleSuitesTimePeriod? timePeriod,
            ref string? actorName,
            ref global::G.ReposGetRepoRuleSuitesRuleSuiteResult? ruleSuiteResult,
            ref int? perPage,
            ref int? page);
        partial void PrepareReposGetRepoRuleSuitesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string? @ref,
            global::G.ReposGetRepoRuleSuitesTimePeriod? timePeriod,
            string? actorName,
            global::G.ReposGetRepoRuleSuitesRuleSuiteResult? ruleSuiteResult,
            int? perPage,
            int? page);
        partial void ProcessReposGetRepoRuleSuitesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposGetRepoRuleSuitesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repository rule suites<br/>
        /// Lists suites of rule evaluations at the repository level.<br/>
        /// For more information, see "[Managing rulesets for a repository](https://docs.github.com/repositories/configuring-branches-and-merges-in-your-repository/managing-rulesets/managing-rulesets-for-a-repository#viewing-insights-for-rulesets)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="timePeriod">
        /// Default Value: day
        /// </param>
        /// <param name="actorName"></param>
        /// <param name="ruleSuiteResult">
        /// Default Value: all
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RuleSuite>> ReposGetRepoRuleSuitesAsync(
            string owner,
            string repo,
            string? @ref = default,
            global::G.ReposGetRepoRuleSuitesTimePeriod? timePeriod = global::G.ReposGetRepoRuleSuitesTimePeriod.Day,
            string? actorName = default,
            global::G.ReposGetRepoRuleSuitesRuleSuiteResult? ruleSuiteResult = global::G.ReposGetRepoRuleSuitesRuleSuiteResult.All,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReposGetRepoRuleSuitesArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                @ref: ref @ref,
                timePeriod: ref timePeriod,
                actorName: ref actorName,
                ruleSuiteResult: ref ruleSuiteResult,
                perPage: ref perPage,
                page: ref page);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/rulesets/rule-suites",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("ref", @ref) 
                .AddOptionalParameter("time_period", timePeriod?.ToValueString()) 
                .AddOptionalParameter("actor_name", actorName) 
                .AddOptionalParameter("rule_suite_result", ruleSuiteResult?.ToValueString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareReposGetRepoRuleSuitesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                @ref: @ref,
                timePeriod: timePeriod,
                actorName: actorName,
                ruleSuiteResult: ruleSuiteResult,
                perPage: perPage,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessReposGetRepoRuleSuitesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposGetRepoRuleSuitesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.RuleSuite>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}