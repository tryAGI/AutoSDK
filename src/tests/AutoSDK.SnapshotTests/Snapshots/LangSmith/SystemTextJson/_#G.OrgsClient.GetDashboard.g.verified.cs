//HintName: G.OrgsClient.GetDashboard.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareGetDashboardArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.OrganizationDashboardType type,
            ref global::G.AnyOf<global::G.OrganizationDashboardColorScheme?, object> colorScheme);
        partial void PrepareGetDashboardRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.OrganizationDashboardType type,
            global::G.AnyOf<global::G.OrganizationDashboardColorScheme?, object> colorScheme);
        partial void ProcessGetDashboardResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDashboardResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <param name="type">
        /// Enum for acceptable types of dashboards.
        /// </param>
        /// <param name="colorScheme"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OrganizationDashboardSchema> GetDashboardAsync(
            global::G.OrganizationDashboardType type,
            global::G.AnyOf<global::G.OrganizationDashboardColorScheme?, object> colorScheme,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetDashboardArguments(
                httpClient: _httpClient,
                type: ref type,
                colorScheme: ref colorScheme);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/orgs/current/dashboard?type={(global::System.Uri.EscapeDataString(type.ToValueString() ?? string.Empty))}&color_scheme={colorScheme}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetDashboardRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                type: type,
                colorScheme: colorScheme);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetDashboardResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetDashboardResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.OrganizationDashboardSchema?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}