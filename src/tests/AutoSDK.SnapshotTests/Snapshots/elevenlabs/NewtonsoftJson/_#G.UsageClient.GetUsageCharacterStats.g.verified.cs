//HintName: G.UsageClient.GetUsageCharacterStats.g.cs

#nullable enable

namespace G
{
    public partial class UsageClient
    {
        partial void PrepareGetUsageCharacterStatsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTimeOffset startUnix,
            ref global::System.DateTimeOffset endUnix,
            ref bool? includeWorkspaceMetrics,
            ref global::G.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType? breakdownType,
            ref string? xiApiKey);
        partial void PrepareGetUsageCharacterStatsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics,
            global::G.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType? breakdownType,
            string? xiApiKey);
        partial void ProcessGetUsageCharacterStatsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetUsageCharacterStatsResponseContent(
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
        public async global::System.Threading.Tasks.Task<global::G.UsageCharactersResponseModel> GetUsageCharacterStatsAsync(
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics = default,
            global::G.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType? breakdownType = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetUsageCharacterStatsArguments(
                httpClient: HttpClient,
                startUnix: ref startUnix,
                endUnix: ref endUnix,
                includeWorkspaceMetrics: ref includeWorkspaceMetrics,
                breakdownType: ref breakdownType,
                xiApiKey: ref xiApiKey);

            var breakdownTypeValue = breakdownType switch
            {
                global::G.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.None => "none",
                global::G.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.Voice => "voice",
                global::G.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.User => "user",
                global::G.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.ApiKeys => "api_keys",
                global::G.GetCharactersUsageMetricsV1UsageCharacterStatsGetBreakdownType.ProductType => "product_type",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/v1/usage/character-stats",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("start_unix", startUnix.ToString()) 
                .AddRequiredParameter("end_unix", endUnix.ToString()) 
                .AddOptionalParameter("include_workspace_metrics", includeWorkspaceMetrics?.ToString()) 
                .AddOptionalParameter("breakdown_type", breakdownTypeValue?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetUsageCharacterStatsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                startUnix: startUnix,
                endUnix: endUnix,
                includeWorkspaceMetrics: includeWorkspaceMetrics,
                breakdownType: breakdownType,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetUsageCharacterStatsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetUsageCharacterStatsResponseContent(
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
                global::G.UsageCharactersResponseModel.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}