//HintName: G.VoicesClient.GetSharedVoices.g.cs

#nullable enable

namespace G
{
    public partial class VoicesClient
    {
        partial void PrepareGetSharedVoicesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? pageSize,
            ref global::G.GetVoicesV1SharedVoicesGetCategory? category,
            ref string? gender,
            ref string? age,
            ref string? accent,
            ref string? language,
            ref string? locale,
            ref string? search,
            global::System.Collections.Generic.IList<string>? useCases,
            global::System.Collections.Generic.IList<string>? descriptives,
            ref bool? featured,
            ref int? minNoticePeriodDays,
            ref bool? readerAppEnabled,
            ref string? ownerId,
            ref string? sort,
            ref int? page,
            ref string? xiApiKey);
        partial void PrepareGetSharedVoicesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            global::G.GetVoicesV1SharedVoicesGetCategory? category,
            string? gender,
            string? age,
            string? accent,
            string? language,
            string? locale,
            string? search,
            global::System.Collections.Generic.IList<string>? useCases,
            global::System.Collections.Generic.IList<string>? descriptives,
            bool? featured,
            int? minNoticePeriodDays,
            bool? readerAppEnabled,
            string? ownerId,
            string? sort,
            int? page,
            string? xiApiKey);
        partial void ProcessGetSharedVoicesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSharedVoicesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Voices<br/>
        /// Retrieves a list of shared voices.
        /// </summary>
        /// <param name="pageSize">
        /// How many shared voices to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="category">
        /// Voice category used for filtering<br/>
        /// Example: professional
        /// </param>
        /// <param name="gender">
        /// Gender used for filtering<br/>
        /// Example: male
        /// </param>
        /// <param name="age">
        /// Age used for filtering<br/>
        /// Example: young
        /// </param>
        /// <param name="accent">
        /// Accent used for filtering<br/>
        /// Example: american
        /// </param>
        /// <param name="language">
        /// Language used for filtering<br/>
        /// Example: en
        /// </param>
        /// <param name="locale">
        /// Locale used for filtering<br/>
        /// Example: en-US
        /// </param>
        /// <param name="search">
        /// Search term used for filtering<br/>
        /// Example: tiktok
        /// </param>
        /// <param name="useCases">
        /// Use-case used for filtering<br/>
        /// Example: audiobook
        /// </param>
        /// <param name="descriptives">
        /// Search term used for filtering<br/>
        /// Example: tiktok
        /// </param>
        /// <param name="featured">
        /// Filter featured voices<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="minNoticePeriodDays">
        /// Filter voices with a minimum notice period of the given number of days.<br/>
        /// Example: 30
        /// </param>
        /// <param name="readerAppEnabled">
        /// Filter voices that are enabled for the reader app<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="ownerId">
        /// Filter voices by public owner ID<br/>
        /// Example: 7c9fab611d9a0e1fb2e7448a0c294a8804efc2bcc324b0a366a5d5232b7d1532
        /// </param>
        /// <param name="sort">
        /// Sort criteria<br/>
        /// Example: created_date
        /// </param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetLibraryVoicesResponseModel> GetSharedVoicesAsync(
            int? pageSize = default,
            global::G.GetVoicesV1SharedVoicesGetCategory? category = default,
            string? gender = default,
            string? age = default,
            string? accent = default,
            string? language = default,
            string? locale = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? useCases = default,
            global::System.Collections.Generic.IList<string>? descriptives = default,
            bool? featured = default,
            int? minNoticePeriodDays = default,
            bool? readerAppEnabled = default,
            string? ownerId = default,
            string? sort = default,
            int? page = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetSharedVoicesArguments(
                httpClient: HttpClient,
                pageSize: ref pageSize,
                category: ref category,
                gender: ref gender,
                age: ref age,
                accent: ref accent,
                language: ref language,
                locale: ref locale,
                search: ref search,
                useCases: useCases,
                descriptives: descriptives,
                featured: ref featured,
                minNoticePeriodDays: ref minNoticePeriodDays,
                readerAppEnabled: ref readerAppEnabled,
                ownerId: ref ownerId,
                sort: ref sort,
                page: ref page,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/shared-voices",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                .AddOptionalParameter("category", category?.ToValueString()) 
                .AddOptionalParameter("gender", gender) 
                .AddOptionalParameter("age", age) 
                .AddOptionalParameter("accent", accent) 
                .AddOptionalParameter("language", language) 
                .AddOptionalParameter("locale", locale) 
                .AddOptionalParameter("search", search) 
                .AddOptionalParameter("use_cases", useCases, delimiter: ",", explode: true) 
                .AddOptionalParameter("descriptives", descriptives, delimiter: ",", explode: true) 
                .AddOptionalParameter("featured", featured?.ToString()) 
                .AddOptionalParameter("min_notice_period_days", minNoticePeriodDays?.ToString()) 
                .AddOptionalParameter("reader_app_enabled", readerAppEnabled?.ToString()) 
                .AddOptionalParameter("owner_id", ownerId) 
                .AddOptionalParameter("sort", sort) 
                .AddOptionalParameter("page", page?.ToString()) 
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
            PrepareGetSharedVoicesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pageSize: pageSize,
                category: category,
                gender: gender,
                age: age,
                accent: accent,
                language: language,
                locale: locale,
                search: search,
                useCases: useCases,
                descriptives: descriptives,
                featured: featured,
                minNoticePeriodDays: minNoticePeriodDays,
                readerAppEnabled: readerAppEnabled,
                ownerId: ownerId,
                sort: sort,
                page: page,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetSharedVoicesResponse(
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
                ProcessGetSharedVoicesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GetLibraryVoicesResponseModel.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.GetLibraryVoicesResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }
    }
}