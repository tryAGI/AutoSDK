//HintName: G.AnalyticsClient.GetExtensionAnalytics.g.cs

#nullable enable

namespace G
{
    public partial class AnalyticsClient
    {
        partial void PrepareGetExtensionAnalyticsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? extensionId,
            ref global::G.GetExtensionAnalyticsType? type,
            global::System.DateTime startedAt,
            global::System.DateTime endedAt,
            ref int first,
            ref string? after);
        partial void PrepareGetExtensionAnalyticsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? extensionId,
            global::G.GetExtensionAnalyticsType? type,
            global::System.DateTime startedAt,
            global::System.DateTime endedAt,
            int first,
            string? after);
        partial void ProcessGetExtensionAnalyticsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetExtensionAnalyticsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Gets an analytics report for one or more extensions.<br/>
        /// Gets an analytics report for one or more extensions. The response contains the URLs used to download the reports (CSV files). [Learn More](https://dev.twitch.tv/docs/insights)<br/>
        /// __Authorization:__<br/>
        /// Requires a [user access token](https://dev.twitch.tv/docs/authentication#user-access-tokens) that includes the **analytics:read:extensions** scope.
        /// </summary>
        /// <param name="extensionId"></param>
        /// <param name="type"></param>
        /// <param name="startedAt"></param>
        /// <param name="endedAt"></param>
        /// <param name="first"></param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetExtensionAnalyticsResponse> GetExtensionAnalyticsAsync(
            string? extensionId = default,
            global::G.GetExtensionAnalyticsType? type = default,
            global::System.DateTime startedAt = default,
            global::System.DateTime endedAt = default,
            int first = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetExtensionAnalyticsArguments(
                httpClient: _httpClient,
                extensionId: ref extensionId,
                type: ref type,
                startedAt: startedAt,
                endedAt: endedAt,
                first: ref first,
                after: ref after);

            var typeValue = type switch
            {
                global::G.GetExtensionAnalyticsType.OverviewV2 => "overview_v2",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/analytics/extensions?extension_id={extensionId}&type={(global::System.Uri.EscapeDataString(typeValue?.ToString() ?? string.Empty))}&started_at={startedAt:yyyy-MM-ddTHH:mm:ssZ}&ended_at={endedAt:yyyy-MM-ddTHH:mm:ssZ}&first={first}&after={after}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetExtensionAnalyticsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                extensionId: extensionId,
                type: type,
                startedAt: startedAt,
                endedAt: endedAt,
                first: first,
                after: after);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetExtensionAnalyticsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetExtensionAnalyticsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetExtensionAnalyticsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}