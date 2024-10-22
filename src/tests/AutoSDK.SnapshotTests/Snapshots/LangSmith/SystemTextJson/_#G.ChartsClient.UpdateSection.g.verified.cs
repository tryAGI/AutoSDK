//HintName: G.ChartsClient.UpdateSection.g.cs

#nullable enable

namespace G
{
    public partial class ChartsClient
    {
        partial void PrepareUpdateSectionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid sectionId,
            global::G.CustomChartsSectionUpdate request);
        partial void PrepareUpdateSectionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid sectionId,
            global::G.CustomChartsSectionUpdate request);
        partial void ProcessUpdateSectionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateSectionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Section<br/>
        /// Update a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CustomChartsSectionResponse> UpdateSectionAsync(
            global::System.Guid sectionId,
            global::G.CustomChartsSectionUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateSectionArguments(
                httpClient: HttpClient,
                sectionId: ref sectionId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/charts/section/{sectionId}",
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
            PrepareUpdateSectionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                sectionId: sectionId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateSectionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUpdateSectionResponseContent(
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
                global::G.CustomChartsSectionResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Section<br/>
        /// Update a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CustomChartsSectionResponse> UpdateSectionAsync(
            global::System.Guid sectionId,
            global::G.AnyOf<string, global::G.Missing>? title = default,
            global::G.AnyOf<string, global::G.Missing>? description = default,
            global::G.AnyOf<int?, global::G.Missing>? index = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CustomChartsSectionUpdate
            {
                Title = title,
                Description = description,
                Index = index,
            };

            return await UpdateSectionAsync(
                sectionId: sectionId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}