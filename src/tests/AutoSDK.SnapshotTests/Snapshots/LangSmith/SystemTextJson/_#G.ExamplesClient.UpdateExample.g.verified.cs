//HintName: G.ExamplesClient.UpdateExample.g.cs

#nullable enable

namespace G
{
    public partial class ExamplesClient
    {
        partial void PrepareUpdateExampleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid exampleId,
            global::G.ExampleUpdate request);
        partial void PrepareUpdateExampleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid exampleId,
            global::G.ExampleUpdate request);
        partial void ProcessUpdateExampleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateExampleResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> UpdateExampleAsync(
            global::System.Guid exampleId,
            global::G.ExampleUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateExampleArguments(
                httpClient: HttpClient,
                exampleId: ref exampleId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/examples/{exampleId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareUpdateExampleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                exampleId: exampleId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateExampleResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUpdateExampleResponseContent(
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
        /// Update Example<br/>
        /// Update a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="datasetId"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="metadata"></param>
        /// <param name="split"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> UpdateExampleAsync(
            global::System.Guid exampleId,
            global::System.Guid? datasetId = default,
            object? inputs = default,
            object? outputs = default,
            object? metadata = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>? split = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ExampleUpdate
            {
                DatasetId = datasetId,
                Inputs = inputs,
                Outputs = outputs,
                Metadata = metadata,
                Split = split,
            };

            return await UpdateExampleAsync(
                exampleId: exampleId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}