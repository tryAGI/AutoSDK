//HintName: G.Api.ListTunedModelOperations.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareListTunedModelOperationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string tunedModelId,
            ref int? pageSize,
            ref string? filter,
            ref string? pageToken);
        partial void PrepareListTunedModelOperationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string tunedModelId,
            int? pageSize,
            string? filter,
            string? pageToken);
        partial void ProcessListTunedModelOperationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListTunedModelOperationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method, it returns `UNIMPLEMENTED`.
        /// </summary>
        /// <param name="tunedModelId"></param>
        /// <param name="pageSize"></param>
        /// <param name="filter"></param>
        /// <param name="pageToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListOperationsResponse> ListTunedModelOperationsAsync(
            string tunedModelId,
            int? pageSize = default,
            string? filter = default,
            string? pageToken = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListTunedModelOperationsArguments(
                httpClient: _httpClient,
                tunedModelId: ref tunedModelId,
                pageSize: ref pageSize,
                filter: ref filter,
                pageToken: ref pageToken);

            var __pathBuilder = new PathBuilder(
                path: $"/tunedModels/{tunedModelId}/operations",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter(_authorization!.Name, _authorization!.Value) 
                .AddOptionalParameter("pageSize", pageSize?.ToString()) 
                .AddOptionalParameter("filter", filter) 
                .AddOptionalParameter("pageToken", pageToken) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListTunedModelOperationsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                tunedModelId: tunedModelId,
                pageSize: pageSize,
                filter: filter,
                pageToken: pageToken);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListTunedModelOperationsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListTunedModelOperationsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListOperationsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}