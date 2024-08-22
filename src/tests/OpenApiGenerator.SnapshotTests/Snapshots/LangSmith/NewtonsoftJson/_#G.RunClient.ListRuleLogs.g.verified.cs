//HintName: G.RunClient.ListRuleLogs.g.cs

#nullable enable

namespace G
{
    public partial class RunClient
    {
        partial void PrepareListRuleLogsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string ruleId,
            ref int limit,
            ref int offset,
            ref global::System.AnyOf<global::System.DateTime?, object>? startTime,
            ref global::System.AnyOf<global::System.DateTime?, object>? endTime);
        partial void PrepareListRuleLogsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string ruleId,
            int limit,
            int offset,
            global::System.AnyOf<global::System.DateTime?, object>? startTime,
            global::System.AnyOf<global::System.DateTime?, object>? endTime);
        partial void ProcessListRuleLogsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListRuleLogsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Rule Logs<br/>
        /// List logs for a particular rule
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="limit">
        /// Default Value: 720
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.RuleLogSchema>> ListRuleLogsAsync(
            string ruleId,
            int limit,
            int offset,
            global::System.AnyOf<global::System.DateTime?, object>? startTime,
            global::System.AnyOf<global::System.DateTime?, object>? endTime,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListRuleLogsArguments(
                httpClient: _httpClient,
                ruleId: ref ruleId,
                limit: ref limit,
                offset: ref offset,
                startTime: ref startTime,
                endTime: ref endTime);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/runs/rules/{ruleId}/logs?limit={limit}&offset={offset}&start_time={startTime}&end_time={endTime}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListRuleLogsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                ruleId: ruleId,
                limit: limit,
                offset: offset,
                startTime: startTime,
                endTime: endTime);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListRuleLogsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListRuleLogsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.RuleLogSchema>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}