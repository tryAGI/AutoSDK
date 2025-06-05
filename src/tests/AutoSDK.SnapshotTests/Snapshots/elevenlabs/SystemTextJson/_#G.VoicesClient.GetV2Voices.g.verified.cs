//HintName: G.VoicesClient.GetV2Voices.g.cs

#nullable enable

namespace G
{
    public partial class VoicesClient
    {
        partial void PrepareGetV2VoicesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? nextPageToken,
            ref int? pageSize,
            ref string? search,
            ref string? sort,
            ref string? sortDirection,
            ref string? voiceType,
            ref string? category,
            ref string? fineTuningState,
            ref bool? includeTotalCount,
            ref string? xiApiKey);
        partial void PrepareGetV2VoicesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? nextPageToken,
            int? pageSize,
            string? search,
            string? sort,
            string? sortDirection,
            string? voiceType,
            string? category,
            string? fineTuningState,
            bool? includeTotalCount,
            string? xiApiKey);
        partial void ProcessGetV2VoicesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetV2VoicesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Voices V2<br/>
        /// Gets a list of all available voices for a user with search, filtering and pagination.
        /// </summary>
        /// <param name="nextPageToken">
        /// The next page token to use for pagination. Returned from the previous request.<br/>
        /// Example: 0
        /// </param>
        /// <param name="pageSize">
        /// How many voices to return at maximum. Can not exceed 100, defaults to 10. Page 0 may include more voices due to default voices being included.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="search">
        /// Search term to filter voices by. Searches in name, description, labels, category.
        /// </param>
        /// <param name="sort">
        /// Which field to sort by, one of 'created_at_unix' or 'name'. 'created_at_unix' may not be available for older voices.<br/>
        /// Example: created_at_unix
        /// </param>
        /// <param name="sortDirection">
        /// Which direction to sort the voices in. 'asc' or 'desc'.<br/>
        /// Example: desc
        /// </param>
        /// <param name="voiceType">
        /// Type of the voice to filter by. One of 'personal', 'community', 'default', 'workspace'.
        /// </param>
        /// <param name="category">
        /// Category of the voice to filter by. One of 'premade', 'cloned', 'generated', 'professional'
        /// </param>
        /// <param name="fineTuningState">
        /// State of the voice's fine tuning to filter by. Applicable only to professional voices clones. One of 'draft', 'not_verified', 'not_started', 'queued', 'fine_tuning', 'fine_tuned', 'failed', 'delayed'
        /// </param>
        /// <param name="includeTotalCount">
        /// Whether to include the total count of voices found in the response. Incurs a performance cost.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetVoicesV2ResponseModel> GetV2VoicesAsync(
            string? nextPageToken = default,
            int? pageSize = default,
            string? search = default,
            string? sort = default,
            string? sortDirection = default,
            string? voiceType = default,
            string? category = default,
            string? fineTuningState = default,
            bool? includeTotalCount = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetV2VoicesArguments(
                httpClient: HttpClient,
                nextPageToken: ref nextPageToken,
                pageSize: ref pageSize,
                search: ref search,
                sort: ref sort,
                sortDirection: ref sortDirection,
                voiceType: ref voiceType,
                category: ref category,
                fineTuningState: ref fineTuningState,
                includeTotalCount: ref includeTotalCount,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/voices",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("next_page_token", nextPageToken) 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                .AddOptionalParameter("search", search) 
                .AddOptionalParameter("sort", sort) 
                .AddOptionalParameter("sort_direction", sortDirection) 
                .AddOptionalParameter("voice_type", voiceType) 
                .AddOptionalParameter("category", category) 
                .AddOptionalParameter("fine_tuning_state", fineTuningState) 
                .AddOptionalParameter("include_total_count", includeTotalCount?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetV2VoicesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                nextPageToken: nextPageToken,
                pageSize: pageSize,
                search: search,
                sort: sort,
                sortDirection: sortDirection,
                voiceType: voiceType,
                category: category,
                fineTuningState: fineTuningState,
                includeTotalCount: includeTotalCount,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetV2VoicesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessGetV2VoicesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::G.GetVoicesV2ResponseModel.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::G.GetVoicesV2ResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}