//HintName: G.TagClient.TagUpdateTagAppWeight.g.cs

#nullable enable

namespace G
{
    public partial class TagClient
    {
        partial void PrepareTagUpdateTagAppWeightArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? token,
            ref global::System.Guid? currentProjectId,
            ref global::System.Guid? tagAppId,
            ref double? newWeight);
        partial void PrepareTagUpdateTagAppWeightRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? token,
            global::System.Guid? currentProjectId,
            global::System.Guid? tagAppId,
            double? newWeight);
        partial void ProcessTagUpdateTagAppWeightResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTagUpdateTagAppWeightResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// UpdateTagAppWeight.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="currentProjectId"></param>
        /// <param name="tagAppId"></param>
        /// <param name="newWeight"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> TagUpdateTagAppWeightAsync(
            string? token = default,
            global::System.Guid? currentProjectId = default,
            global::System.Guid? tagAppId = default,
            double? newWeight = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTagUpdateTagAppWeightArguments(
                httpClient: HttpClient,
                token: ref token,
                currentProjectId: ref currentProjectId,
                tagAppId: ref tagAppId,
                newWeight: ref newWeight);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/tag/updatetagappweight",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("currentProjectId", currentProjectId?.ToString()) 
                .AddOptionalParameter("tagAppId", tagAppId?.ToString()) 
                .AddOptionalParameter("newWeight", newWeight?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (token != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("token", token.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTagUpdateTagAppWeightRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                token: token,
                currentProjectId: currentProjectId,
                tagAppId: tagAppId,
                newWeight: newWeight);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTagUpdateTagAppWeightResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessTagUpdateTagAppWeightResponseContent(
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
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

            using var __streamReader = new global::System.IO.StreamReader(__responseStream);
            using var __jsonReader = new global::Newtonsoft.Json.JsonTextReader(__streamReader);
            var __serializer = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions);
            var __responseValue = __serializer.Deserialize<string?>(__jsonReader);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}