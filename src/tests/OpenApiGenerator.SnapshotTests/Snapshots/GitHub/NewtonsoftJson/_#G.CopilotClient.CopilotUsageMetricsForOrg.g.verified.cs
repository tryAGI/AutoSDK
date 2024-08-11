//HintName: G.CopilotClient.CopilotUsageMetricsForOrg.g.cs

#nullable enable

namespace G
{
    public partial class CopilotClient
    {
        partial void PrepareCopilotUsageMetricsForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string? since,
            ref string? until,
            ref int page,
            ref int perPage);
        partial void PrepareCopilotUsageMetricsForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string? since,
            string? until,
            int page,
            int perPage);
        partial void ProcessCopilotUsageMetricsForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCopilotUsageMetricsForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get a summary of Copilot usage for organization members<br/>
        /// **Note**: This endpoint is in beta and is subject to change.<br/>
        /// You can use this endpoint to see a daily breakdown of aggregated usage metrics for Copilot completions and Copilot Chat in the IDE<br/>
        /// across an organization, with a further breakdown of suggestions, acceptances, and number of active users by editor and language for each day.<br/>
        /// See the response schema tab for detailed metrics definitions.<br/>
        /// The response contains metrics for the prior 28 days. Usage metrics are processed once per day for the previous day,<br/>
        /// and the response will only include data up until yesterday. In order for an end user to be counted towards these metrics,<br/>
        /// they must have telemetry enabled in their IDE.<br/>
        /// Copilot Business or Copilot Enterprise organization owners, and owners and billing managers of their parent enterprises, can view<br/>
        /// Copilot usage metrics.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `copilot`, `manage_billing:copilot`, `admin:org`, `admin:enterprise`, or `manage_billing:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 28
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CopilotUsageMetrics>> CopilotUsageMetricsForOrgAsync(
            string org,
            string? since,
            string? until,
            int page,
            int perPage,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCopilotUsageMetricsForOrgArguments(
                httpClient: _httpClient,
                org: ref org,
                since: ref since,
                until: ref until,
                page: ref page,
                perPage: ref perPage);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/copilot/usage?since={since}&until={until}&page={page}&per_page={perPage}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCopilotUsageMetricsForOrgRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                since: since,
                until: until,
                page: page,
                perPage: perPage);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCopilotUsageMetricsForOrgResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCopilotUsageMetricsForOrgResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.CopilotUsageMetrics>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}