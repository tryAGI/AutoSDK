//HintName: G.PronunciationDictionaryClient.GetPronunciationDictionaries.g.cs

#nullable enable

namespace G
{
    public partial class PronunciationDictionaryClient
    {
        partial void PrepareGetPronunciationDictionariesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? cursor,
            ref int? pageSize,
            ref string? xiApiKey);
        partial void PrepareGetPronunciationDictionariesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? cursor,
            int? pageSize,
            string? xiApiKey);
        partial void ProcessGetPronunciationDictionariesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetPronunciationDictionariesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Pronunciation Dictionaries<br/>
        /// Get a list of the pronunciation dictionaries you have access to and their metadata
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many pronunciation dictionaries to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetPronunciationDictionariesMetadataResponseModel> GetPronunciationDictionariesAsync(
            string? cursor = default,
            int? pageSize = 30,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetPronunciationDictionariesArguments(
                httpClient: HttpClient,
                cursor: ref cursor,
                pageSize: ref pageSize,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: "/v1/pronunciation-dictionaries/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("cursor", cursor) 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetPronunciationDictionariesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cursor: cursor,
                pageSize: pageSize,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetPronunciationDictionariesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessGetPronunciationDictionariesResponseContent(
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
                global::G.GetPronunciationDictionariesMetadataResponseModel.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}