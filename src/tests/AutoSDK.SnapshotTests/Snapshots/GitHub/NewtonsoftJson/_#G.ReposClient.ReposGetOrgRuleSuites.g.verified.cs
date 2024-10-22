//HintName: G.ReposClient.ReposGetOrgRuleSuites.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposGetOrgRuleSuitesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string? @ref,
            ref int? repositoryName,
            ref global::G.ReposGetOrgRuleSuitesTimePeriod? timePeriod,
            ref string? actorName,
            ref global::G.ReposGetOrgRuleSuitesRuleSuiteResult? ruleSuiteResult,
            ref int? perPage,
            ref int? page);
        partial void PrepareReposGetOrgRuleSuitesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string? @ref,
            int? repositoryName,
            global::G.ReposGetOrgRuleSuitesTimePeriod? timePeriod,
            string? actorName,
            global::G.ReposGetOrgRuleSuitesRuleSuiteResult? ruleSuiteResult,
            int? perPage,
            int? page);
        partial void ProcessReposGetOrgRuleSuitesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposGetOrgRuleSuitesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List organization rule suites<br/>
        /// Lists suites of rule evaluations at the organization level.<br/>
        /// For more information, see "[Managing rulesets for repositories in your organization](https://docs.github.com/organizations/managing-organization-settings/managing-rulesets-for-repositories-in-your-organization#viewing-insights-for-rulesets)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="ref"></param>
        /// <param name="repositoryName"></param>
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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RuleSuite>> ReposGetOrgRuleSuitesAsync(
            string org,
            string? @ref = default,
            int? repositoryName = default,
            global::G.ReposGetOrgRuleSuitesTimePeriod? timePeriod = global::G.ReposGetOrgRuleSuitesTimePeriod.Day,
            string? actorName = default,
            global::G.ReposGetOrgRuleSuitesRuleSuiteResult? ruleSuiteResult = global::G.ReposGetOrgRuleSuitesRuleSuiteResult.All,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareReposGetOrgRuleSuitesArguments(
                httpClient: HttpClient,
                org: ref org,
                @ref: ref @ref,
                repositoryName: ref repositoryName,
                timePeriod: ref timePeriod,
                actorName: ref actorName,
                ruleSuiteResult: ref ruleSuiteResult,
                perPage: ref perPage,
                page: ref page);

            var timePeriodValue = timePeriod switch
            {
                global::G.ReposGetOrgRuleSuitesTimePeriod.Hour => "hour",
                global::G.ReposGetOrgRuleSuitesTimePeriod.Day => "day",
                global::G.ReposGetOrgRuleSuitesTimePeriod.Week => "week",
                global::G.ReposGetOrgRuleSuitesTimePeriod.Month => "month",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var ruleSuiteResultValue = ruleSuiteResult switch
            {
                global::G.ReposGetOrgRuleSuitesRuleSuiteResult.Pass => "pass",
                global::G.ReposGetOrgRuleSuitesRuleSuiteResult.Fail => "fail",
                global::G.ReposGetOrgRuleSuitesRuleSuiteResult.Bypass => "bypass",
                global::G.ReposGetOrgRuleSuitesRuleSuiteResult.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/rulesets/rule-suites",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("ref", @ref) 
                .AddOptionalParameter("repository_name", repositoryName?.ToString()) 
                .AddOptionalParameter("time_period", timePeriodValue?.ToString()) 
                .AddOptionalParameter("actor_name", actorName) 
                .AddOptionalParameter("rule_suite_result", ruleSuiteResultValue?.ToString()) 
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
            PrepareReposGetOrgRuleSuitesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                @ref: @ref,
                repositoryName: repositoryName,
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
            ProcessReposGetOrgRuleSuitesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessReposGetOrgRuleSuitesResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.RuleSuite>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}