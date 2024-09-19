//HintName: G.CopilotClient.CopilotUsageMetricsForEnterprise.g.cs

#nullable enable

namespace G
{
    public partial class CopilotClient
    {
        partial void PrepareCopilotUsageMetricsForEnterpriseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string enterprise,
            ref string? since,
            ref string? until,
            ref int? page,
            ref int? perPage);
        partial void PrepareCopilotUsageMetricsForEnterpriseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string enterprise,
            string? since,
            string? until,
            int? page,
            int? perPage);
        partial void ProcessCopilotUsageMetricsForEnterpriseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCopilotUsageMetricsForEnterpriseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get a summary of Copilot usage for enterprise members<br/>
        /// **Note**: This endpoint is in beta and is subject to change.<br/>
        /// You can use this endpoint to see a daily breakdown of aggregated usage metrics for Copilot completions and Copilot Chat in the IDE<br/>
        /// for all users across organizations with access to Copilot within your enterprise, with a further breakdown of suggestions, acceptances,<br/>
        /// and number of active users by editor and language for each day. See the response schema tab for detailed metrics definitions.<br/>
        /// The response contains metrics for the prior 28 days. Usage metrics are processed once per day for the previous day,<br/>
        /// and the response will only include data up until yesterday. In order for an end user to be counted towards these metrics,<br/>
        /// they must have telemetry enabled in their IDE.<br/>
        /// Only the owners and billing managers of enterprises with a Copilot Business or Enterprise subscription can view Copilot usage<br/>
        /// metrics for the enterprise.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `copilot`, `manage_billing:copilot`, `admin:enterprise`, or `manage_billing:enterprise` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CopilotUsageMetrics>> CopilotUsageMetricsForEnterpriseAsync(
            string enterprise,
            string? since = default,
            string? until = default,
            int? page = 1,
            int? perPage = 28,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCopilotUsageMetricsForEnterpriseArguments(
                httpClient: _httpClient,
                enterprise: ref enterprise,
                since: ref since,
                until: ref until,
                page: ref page,
                perPage: ref perPage);

            var __pathBuilder = new PathBuilder(
                path: $"/enterprises/{enterprise}/copilot/usage",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("since", since) 
                .AddOptionalParameter("until", until) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCopilotUsageMetricsForEnterpriseRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                enterprise: enterprise,
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
            ProcessCopilotUsageMetricsForEnterpriseResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCopilotUsageMetricsForEnterpriseResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.CopilotUsageMetrics>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}