//HintName: G.Api.CancelTunedModelOperation.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCancelTunedModelOperationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string tunedModelId,
            ref string operationId,
            global::G.CancelOperationRequest request);
        partial void PrepareCancelTunedModelOperationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string tunedModelId,
            string operationId,
            global::G.CancelOperationRequest request);
        partial void ProcessCancelTunedModelOperationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCancelTunedModelOperationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the operation, but success is not guaranteed. If the server doesn't support this method, it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether the cancellation succeeded or whether the operation completed despite cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="tunedModelId"></param>
        /// <param name="operationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Empty> CancelTunedModelOperationAsync(
            string tunedModelId,
            string operationId,
            global::G.CancelOperationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCancelTunedModelOperationArguments(
                httpClient: _httpClient,
                tunedModelId: ref tunedModelId,
                operationId: ref operationId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/tunedModels/{tunedModelId}/operations/{operationId}:cancel",
                baseUri: _httpClient.BaseAddress);
            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "ApiKey" &&
                    _authorization.Location == "Query")
                {
                    __pathBuilder = __pathBuilder.AddRequiredParameter(_authorization.Name, _authorization.Value);
                }
            } 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCancelTunedModelOperationRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                tunedModelId: tunedModelId,
                operationId: operationId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCancelTunedModelOperationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCancelTunedModelOperationResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.Empty?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the operation, but success is not guaranteed. If the server doesn't support this method, it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether the cancellation succeeded or whether the operation completed despite cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="tunedModelId"></param>
        /// <param name="operationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Empty> CancelTunedModelOperationAsync(
            string tunedModelId,
            string operationId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CancelOperationRequest
            {
            };

            return await CancelTunedModelOperationAsync(
                tunedModelId: tunedModelId,
                operationId: operationId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}