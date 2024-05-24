//HintName: G.ReposClient.ReposGetOrgRuleSuites.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// List organization rule suites
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositoryName"></param>
        /// <param name="timePeriod"></param>
        /// <param name="actorName"></param>
        /// <param name="ruleSuiteResult"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<RuleSuites> ReposGetOrgRuleSuitesAsync(
            string org,
            int repositoryName,
            ReposGetOrgRuleSuitesTimePeriod timePeriod,
            string actorName,
            ReposGetOrgRuleSuitesRuleSuiteResult ruleSuiteResult,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var timePeriodValue = timePeriod switch
            {
                ReposGetOrgRuleSuitesTimePeriod.Hour => "hour",
                ReposGetOrgRuleSuitesTimePeriod.Day => "day",
                ReposGetOrgRuleSuitesTimePeriod.Week => "week",
                ReposGetOrgRuleSuitesTimePeriod.Month => "month",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var ruleSuiteResultValue = ruleSuiteResult switch
            {
                ReposGetOrgRuleSuitesRuleSuiteResult.Pass => "pass",
                ReposGetOrgRuleSuitesRuleSuiteResult.Fail => "fail",
                ReposGetOrgRuleSuitesRuleSuiteResult.Bypass => "bypass",
                ReposGetOrgRuleSuitesRuleSuiteResult.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/rulesets/rule-suites?repository_name={repositoryName}&time_period={timePeriodValue}&actor_name={actorName}&rule_suite_result={ruleSuiteResultValue}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<RuleSuites>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }
    }
}