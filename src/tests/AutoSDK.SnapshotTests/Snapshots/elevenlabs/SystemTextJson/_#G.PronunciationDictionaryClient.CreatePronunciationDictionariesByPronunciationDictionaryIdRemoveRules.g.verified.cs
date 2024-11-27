//HintName: G.PronunciationDictionaryClient.CreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRules.g.cs

#nullable enable

namespace G
{
    public partial class PronunciationDictionaryClient
    {
        partial void PrepareCreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pronunciationDictionaryId,
            ref string? xiApiKey,
            global::G.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost request);
        partial void PrepareCreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pronunciationDictionaryId,
            string? xiApiKey,
            global::G.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost request);
        partial void ProcessCreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Remove Rules From The Pronunciation Dictionary<br/>
        /// Remove rules from the pronunciation dictionary
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RemovePronunciationDictionaryRulesResponseModel> CreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesAsync(
            string pronunciationDictionaryId,
            global::G.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesArguments(
                httpClient: HttpClient,
                pronunciationDictionaryId: ref pronunciationDictionaryId,
                xiApiKey: ref xiApiKey,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/pronunciation-dictionaries/{pronunciationDictionaryId}/remove-rules",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
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
            PrepareCreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pronunciationDictionaryId: pronunciationDictionaryId,
                xiApiKey: xiApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesResponse(
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
                    message: __response.ReasonPhrase ?? string.Empty,
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
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesResponseContent(
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
                    global::G.RemovePronunciationDictionaryRulesResponseModel.FromJson(__content, JsonSerializerOptions) ??
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

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::G.RemovePronunciationDictionaryRulesResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Remove Rules From The Pronunciation Dictionary<br/>
        /// Remove rules from the pronunciation dictionary
        /// </summary>
        /// <param name="pronunciationDictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="ruleStrings">
        /// List of strings to remove from the pronunciation dictionary.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.RemovePronunciationDictionaryRulesResponseModel> CreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesAsync(
            string pronunciationDictionaryId,
            global::System.Collections.Generic.IList<string> ruleStrings,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost
            {
                RuleStrings = ruleStrings,
            };

            return await CreatePronunciationDictionariesByPronunciationDictionaryIdRemoveRulesAsync(
                pronunciationDictionaryId: pronunciationDictionaryId,
                xiApiKey: xiApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}