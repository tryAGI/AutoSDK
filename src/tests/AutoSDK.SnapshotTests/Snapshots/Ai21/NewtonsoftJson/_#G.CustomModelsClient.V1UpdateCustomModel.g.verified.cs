//HintName: G.CustomModelsClient.V1UpdateCustomModel.g.cs

#nullable enable

namespace G
{
    public partial class CustomModelsClient
    {
        partial void PrepareV1UpdateCustomModelArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string customModelPid,
            global::G.CustomModelUpdateBody request);
        partial void PrepareV1UpdateCustomModelRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string customModelPid,
            global::G.CustomModelUpdateBody request);
        partial void ProcessV1UpdateCustomModelResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1UpdateCustomModelResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Model
        /// </summary>
        /// <param name="customModelPid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> V1UpdateCustomModelAsync(
            string customModelPid,
            global::G.CustomModelUpdateBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1UpdateCustomModelArguments(
                httpClient: HttpClient,
                customModelPid: ref customModelPid,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/studio/v1/custom-model/{customModelPid}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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
            PrepareV1UpdateCustomModelRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                customModelPid: customModelPid,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1UpdateCustomModelResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1UpdateCustomModelResponseContent(
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

            return __content;
        }

        /// <summary>
        /// Update Model
        /// </summary>
        /// <param name="customModelPid"></param>
        /// <param name="defaultEpoch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> V1UpdateCustomModelAsync(
            string customModelPid,
            int? defaultEpoch = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CustomModelUpdateBody
            {
                DefaultEpoch = defaultEpoch,
            };

            return await V1UpdateCustomModelAsync(
                customModelPid: customModelPid,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}