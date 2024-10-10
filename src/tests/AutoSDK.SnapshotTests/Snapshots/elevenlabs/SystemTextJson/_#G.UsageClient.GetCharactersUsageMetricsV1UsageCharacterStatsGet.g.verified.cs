//HintName: G.UsageClient.GetCharactersUsageMetricsV1UsageCharacterStatsGet.g.cs

#nullable enable

namespace G
{
    public partial class UsageClient
    {
        partial void PrepareGetCharactersUsageMetricsV1UsageCharacterStatsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTimeOffset startUnix,
            ref global::System.DateTimeOffset endUnix,
            ref bool? includeWorkspaceMetrics,
            ref global::G.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType? breakdownType,
            ref string? xiApiKey);
        partial void PrepareGetCharactersUsageMetricsV1UsageCharacterStatsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics,
            global::G.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType? breakdownType,
            string? xiApiKey);
        partial void ProcessGetCharactersUsageMetricsV1UsageCharacterStatsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetCharactersUsageMetricsV1UsageCharacterStatsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Characters Usage Metrics<br/>
        /// Returns the credit usage metrics for the current user or the entire workspace they are part of. The response will return a time axis with unix timestamps for each day and daily usage along that axis. The usage will be broken down by the specified breakdown type. For example, breakdown type "voice" will return the usage of each voice along the time axis.
        /// </summary>
        /// <param name="startUnix">
        /// UTC Unix timestamp for the start of the usage window, in milliseconds. To include the first day of the window, the timestamp should be at 00:00:00 of that day.
        /// </param>
        /// <param name="endUnix">
        /// UTC Unix timestamp for the end of the usage window, in milliseconds. To include the last day of the window, the timestamp should be at 23:59:59 of that day.
        /// </param>
        /// <param name="includeWorkspaceMetrics">
        /// Whether or not to include the statistics of the entire workspace.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="breakdownType">
        /// How to break down the information. Cannot be "user" if include_workspace_metrics is False.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UsageCharactersResponseModel> GetCharactersUsageMetricsV1UsageCharacterStatsGetAsync(
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics = false,
            global::G.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType? breakdownType = global::G.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.None,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetCharactersUsageMetricsV1UsageCharacterStatsGetArguments(
                httpClient: _httpClient,
                startUnix: ref startUnix,
                endUnix: ref endUnix,
                includeWorkspaceMetrics: ref includeWorkspaceMetrics,
                breakdownType: ref breakdownType,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: "/v1/usage/character-stats",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("start_unix", startUnix.ToString()) 
                .AddRequiredParameter("end_unix", endUnix.ToString()) 
                .AddOptionalParameter("include_workspace_metrics", includeWorkspaceMetrics?.ToString()) 
                .AddOptionalParameter("breakdown_type", breakdownType?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetCharactersUsageMetricsV1UsageCharacterStatsGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                startUnix: startUnix,
                endUnix: endUnix,
                includeWorkspaceMetrics: includeWorkspaceMetrics,
                breakdownType: breakdownType,
                xiApiKey: xiApiKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetCharactersUsageMetricsV1UsageCharacterStatsGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetCharactersUsageMetricsV1UsageCharacterStatsGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.UsageCharactersResponseModel?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}