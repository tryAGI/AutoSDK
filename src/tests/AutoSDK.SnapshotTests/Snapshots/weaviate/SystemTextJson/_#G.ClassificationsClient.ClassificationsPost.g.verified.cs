//HintName: G.ClassificationsClient.ClassificationsPost.g.cs

#nullable enable

namespace G
{
    public partial class ClassificationsClient
    {
        partial void PrepareClassificationsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.Classification request);
        partial void PrepareClassificationsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.Classification request);
        partial void ProcessClassificationsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessClassificationsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Starts a classification.<br/>
        /// Trigger a classification based on the specified params. Classifications will run in the background, use GET /classifications/&lt;id&gt; to retrieve the status of your classification.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Classification> ClassificationsPostAsync(
            global::G.Classification request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareClassificationsPostArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/classifications/",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareClassificationsPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessClassificationsPostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessClassificationsPostResponseContent(
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
                global::G.Classification.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Starts a classification.<br/>
        /// Trigger a classification based on the specified params. Classifications will run in the background, use GET /classifications/&lt;id&gt; to retrieve the status of your classification.
        /// </summary>
        /// <param name="id">
        /// ID to uniquely identify this classification run<br/>
        /// Example: ee722219-b8ec-4db1-8f8d-5150bb1a9e0c
        /// </param>
        /// <param name="class">
        /// class (name) which is used in this classification<br/>
        /// Example: City
        /// </param>
        /// <param name="classifyProperties">
        /// which ref-property to set as part of the classification<br/>
        /// Example: [inCountry]
        /// </param>
        /// <param name="basedOnProperties">
        /// base the text-based classification on these fields (of type text)<br/>
        /// Example: [description]
        /// </param>
        /// <param name="status">
        /// status of this classification<br/>
        /// Example: running
        /// </param>
        /// <param name="meta">
        /// Additional information to a specific classification
        /// </param>
        /// <param name="type">
        /// which algorithm to use for classifications
        /// </param>
        /// <param name="settings">
        /// classification-type specific settings
        /// </param>
        /// <param name="error">
        /// error message if status == failed<br/>
        /// Example: classify xzy: something went wrong
        /// </param>
        /// <param name="filters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.Classification> ClassificationsPostAsync(
            global::System.Guid? id = default,
            string? @class = default,
            global::System.Collections.Generic.IList<string>? classifyProperties = default,
            global::System.Collections.Generic.IList<string>? basedOnProperties = default,
            global::G.ClassificationStatus? status = default,
            global::G.ClassificationMeta? meta = default,
            string? type = default,
            object? settings = default,
            string? error = default,
            global::G.ClassificationFilters? filters = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.Classification
            {
                Id = id,
                Class = @class,
                ClassifyProperties = classifyProperties,
                BasedOnProperties = basedOnProperties,
                Status = status,
                Meta = meta,
                Type = type,
                Settings = settings,
                Error = error,
                Filters = filters,
            };

            return await ClassificationsPostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}