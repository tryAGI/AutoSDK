//HintName: G.OrganizationClient.ListOrganizations.g.cs

#nullable enable

namespace G
{
    public partial class OrganizationClient
    {
        partial void PrepareListOrganizationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int pageSize,
            ref string? pageToken,
            ref global::G.ListOrganizationsView? view,
            ref string? filter);
        partial void PrepareListOrganizationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int pageSize,
            string? pageToken,
            global::G.ListOrganizationsView? view,
            string? filter);
        partial void ProcessListOrganizationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListOrganizationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List organizations<br/>
        /// Returns a paginated list of organizations.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="view"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListOrganizationsResponse> ListOrganizationsAsync(
            int pageSize = default,
            string? pageToken = default,
            global::G.ListOrganizationsView? view = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListOrganizationsArguments(
                httpClient: _httpClient,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                view: ref view,
                filter: ref filter);

            var viewValue = view switch
            {
                global::G.ListOrganizationsView.VIEWBASIC => "VIEW_BASIC",
                global::G.ListOrganizationsView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1beta/organizations?pageSize={pageSize}&pageToken={pageToken}&view={(global::System.Uri.EscapeDataString(viewValue?.ToString() ?? string.Empty))}&filter={filter}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListOrganizationsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                pageSize: pageSize,
                pageToken: pageToken,
                view: view,
                filter: filter);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListOrganizationsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListOrganizationsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListOrganizationsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}