//HintName: G.DatasetClient.UpdateHeliconeDatasetRequest.g.cs

#nullable enable

namespace G
{
    public partial class DatasetClient
    {
        partial void PrepareUpdateHeliconeDatasetRequestArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            ref string requestId,
            global::G.UpdateHeliconeDatasetRequestRequest request);
        partial void PrepareUpdateHeliconeDatasetRequestRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            string requestId,
            global::G.UpdateHeliconeDatasetRequestRequest request);
        partial void ProcessUpdateHeliconeDatasetRequestResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateHeliconeDatasetRequestResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="requestId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ResultErrorUnknown, global::G.ResultSuccessAny>> UpdateHeliconeDatasetRequestAsync(
            string datasetId,
            string requestId,

            global::G.UpdateHeliconeDatasetRequestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateHeliconeDatasetRequestArguments(
                httpClient: HttpClient,
                datasetId: ref datasetId,
                requestId: ref requestId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/helicone-dataset/{datasetId}/request/{requestId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateHeliconeDatasetRequestRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                datasetId: datasetId,
                requestId: requestId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateHeliconeDatasetRequestResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUpdateHeliconeDatasetRequestResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AnyOf<global::G.ResultErrorUnknown, global::G.ResultSuccessAny>.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.AnyOf<global::G.ResultErrorUnknown, global::G.ResultSuccessAny>.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="requestId"></param>
        /// <param name="responseBody"></param>
        /// <param name="requestBody"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ResultErrorUnknown, global::G.ResultSuccessAny>> UpdateHeliconeDatasetRequestAsync(
            string datasetId,
            string requestId,
            global::G.Json? responseBody = default,
            global::G.Json? requestBody = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.UpdateHeliconeDatasetRequestRequest
            {
                ResponseBody = responseBody,
                RequestBody = requestBody,
            };

            return await UpdateHeliconeDatasetRequestAsync(
                datasetId: datasetId,
                requestId: requestId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}