//HintName: G.SubpackageSearchClient.Create.g.cs

#nullable enable

namespace G
{
    public partial class SubpackageSearchClient
    {
        partial void PrepareCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string xApiKey,
            global::G.CreateRequest7 request);
        partial void PrepareCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string xApiKey,
            global::G.CreateRequest7 request);
        partial void ProcessCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Make any-to-video search requests<br/>
        /// Use this endpoint to search for relevant matches in an index using text, media, or a combination of both as your query.<br/>
        /// **Text queries**:<br/>
        /// - Use the `query_text` parameter to specify your query.<br/>
        /// **Media queries**:<br/>
        /// - Set the `query_media_type` parameter to the corresponding media type (example: `image`).<br/>
        /// - Provide up to 10 images by specifying the following parameters multiple times:<br/>
        ///   - `query_media_url`: Publicly accessible URL of your media file.<br/>
        ///   - `query_media_file`: Local media file.<br/>
        /// - Marengo 2.7 supports a single image per request.<br/>
        /// **Composed text and media queries** (Marengo 3.0 only):<br/>
        /// - Use the `query_text` parameter for your text query.<br/>
        /// - Set `query_media_type` to `image`.<br/>
        /// - Provide up to 10 images by specifying the `query_media_url` and `query_media_file` parameters multiple times.<br/>
        /// **Entity search** (Marengo 3.0 only and in beta):<br/>
        /// - To find a specific person in your videos, enclose the unique identifier of the entity you want to find in the `query_text` parameter.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - When using images in your search queries (either as media queries or in composed searches), ensure your image files meet the [requirements](/v1.3/docs/concepts/models/marengo#image-file-requirements).<br/>
        /// - This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SearchResults> CreateAsync(
            string xApiKey,

            global::G.CreateRequest7 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateArguments(
                httpClient: HttpClient,
                xApiKey: ref xApiKey,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/search",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            __httpRequest.Headers.TryAddWithoutValidation("x-api-key", xApiKey.ToString());

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{xApiKey}"),
                name: "\"x-api-key\"");
            if (request.QueryMediaType != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.QueryMediaType?.ToValueString()}"),
                    name: "\"query_media_type\"");
            } 
            if (request.QueryMediaUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.QueryMediaUrl?.ToString() ?? string.Empty),
                    name: "\"query_media_url\"");
            } 
            if (request.QueryMediaFile != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent(request.QueryMediaFile?.ToString() ?? string.Empty),
                    name: "\"query_media_file\"");
            } 
            if (request.QueryText != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.QueryText}"),
                    name: "\"query_text\"");
            }
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.IndexId}"),
                name: "\"index_id\"");
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.SearchOptions, x => x.ToValueString()))}]"),
                name: "\"search_options\"");
            if (request.TranscriptionOptions != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.TranscriptionOptions, x => x.ToValueString()))}]"),
                    name: "\"transcription_options\"");
            } 
            if (request.AdjustConfidenceLevel != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AdjustConfidenceLevel}"),
                    name: "\"adjust_confidence_level\"");
            } 
            if (request.GroupBy != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.GroupBy?.ToValueString()}"),
                    name: "\"group_by\"");
            } 
            if (request.Threshold != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Threshold?.ToValueString()}"),
                    name: "\"threshold\"");
            } 
            if (request.SortOption != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SortOption?.ToValueString()}"),
                    name: "\"sort_option\"");
            } 
            if (request.Operator != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Operator?.ToValueString()}"),
                    name: "\"operator\"");
            } 
            if (request.PageLimit != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PageLimit}"),
                    name: "\"page_limit\"");
            } 
            if (request.Filter != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Filter}"),
                    name: "\"filter\"");
            } 
            if (request.IncludeUserMetadata != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.IncludeUserMetadata}"),
                    name: "\"include_user_metadata\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xApiKey: xApiKey,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // The request has failed.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.AnyToVideoSearchRequestBadRequestError? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.AnyToVideoSearchRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.AnyToVideoSearchRequestBadRequestError.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.AnyToVideoSearchRequestBadRequestError>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // If the rate limit is reached, the platform returns an `HTTP 429 - Too many requests` error response. The response body is empty. 
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                string? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::Newtonsoft.Json.JsonConvert.DeserializeObject<string?>(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<string>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
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
                ProcessCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.SearchResults.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.SearchResults.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Make any-to-video search requests<br/>
        /// Use this endpoint to search for relevant matches in an index using text, media, or a combination of both as your query.<br/>
        /// **Text queries**:<br/>
        /// - Use the `query_text` parameter to specify your query.<br/>
        /// **Media queries**:<br/>
        /// - Set the `query_media_type` parameter to the corresponding media type (example: `image`).<br/>
        /// - Provide up to 10 images by specifying the following parameters multiple times:<br/>
        ///   - `query_media_url`: Publicly accessible URL of your media file.<br/>
        ///   - `query_media_file`: Local media file.<br/>
        /// - Marengo 2.7 supports a single image per request.<br/>
        /// **Composed text and media queries** (Marengo 3.0 only):<br/>
        /// - Use the `query_text` parameter for your text query.<br/>
        /// - Set `query_media_type` to `image`.<br/>
        /// - Provide up to 10 images by specifying the `query_media_url` and `query_media_file` parameters multiple times.<br/>
        /// **Entity search** (Marengo 3.0 only and in beta):<br/>
        /// - To find a specific person in your videos, enclose the unique identifier of the entity you want to find in the `query_text` parameter.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - When using images in your search queries (either as media queries or in composed searches), ensure your image files meet the [requirements](/v1.3/docs/concepts/models/marengo#image-file-requirements).<br/>
        /// - This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="queryMediaType">
        /// The type of media you wish to use. This parameter is required for media queries. For example, to perform an image-based search, set this parameter to `image`. Use `query_text` together with this parameter when you want to perform a composed image+text search.
        /// </param>
        /// <param name="queryMediaUrl">
        /// The publicly accessible URL of a media file to use as a query. This parameter is required for media queries if `query_media_file` is not provided.<br/>
        /// You can provide up to 10 images by specifying this parameter multiple times (Marengo 3.0 only):<br/>
        /// ```<br/>
        /// --form query_media_url=https://example.com/image1.jpg \<br/>
        /// --form query_media_url=https://example.com/image2.jpg<br/>
        /// ```
        /// </param>
        /// <param name="queryMediaFile">
        /// A local media file to use as a query. This parameter is required for media queries if `query_media_url` is not provided.<br/>
        /// You can provide up to 10 images by specifying this parameter multiple times (Marengo 3.0 only):<br/>
        /// ```<br/>
        /// --form query_media_file=@/path/to/image1.jpg \<br/>
        /// --form query_media_file=@/path/to/image2.jpg<br/>
        /// ```
        /// </param>
        /// <param name="queryText">
        /// The text query to search for. This parameter is required for text queries. Note that the platform supports full natural language-based search. You can use this parameter together with `query_media_type` and `query_media_url` or `query_media_file` to perform a composed image+text search.<br/>
        /// If you're using the Entity Search feature to search for specific persons in your video content, you must enclose the unique identifier of your entity between the `&lt;@` and `&gt;` markers. For example, to search for an entity with the ID `entity123`, use `&lt;@entity123&gt; is walking` as your query.<br/>
        /// The maximum query length varies by model. Marengo 3.0 supports up to 500 tokens per query, while Marengo 2.7 supports up to 77 tokens per query.
        /// </param>
        /// <param name="indexId">
        /// The unique identifier of the index to search.
        /// </param>
        /// <param name="searchOptions">
        /// Specifies the modalities the video understanding model uses to find relevant information.<br/>
        /// Available options:<br/>
        /// - `visual`: Searches visual content.<br/>
        /// - `audio`: Searches non-speech audio (Marengo 3.0) or all audio (Marengo 2.7).<br/>
        /// - `transcription`: Spoken words (Marengo 3.0 only)<br/>
        /// &lt;Note title="Note"&gt;<br/>
        /// - You can specify multiple search options in conjunction with the [`operator`](/v1.3/api-reference/any-to-video-search/make-search-request#request.body.operator.operator) parameter described below to broaden or narrow your search. For example, to search using both visual and non-speech audio content, include this parameter two times in the request as shown below:<br/>
        ///   ```JSON<br/>
        ///   --form search_options=visual \<br/>
        ///   --form search_options=audio \<br/>
        ///   --form search_options=transcription \<br/>
        ///   ```<br/>
        /// &lt;/Note&gt;<br/>
        /// For detailed guidance and version-specific behavior, see the [Search options](/v1.3/docs/concepts/modalities#search-options) section.
        /// </param>
        /// <param name="transcriptionOptions">
        /// Specifies how the platform matches your text query with the words spoken in the video. This parameter applies only when using Marengo 3.0 with the `search_options` parameter containing the `transcription` value.<br/>
        /// Available options:<br/>
        /// - `lexical`: Exact word matching<br/>
        /// - `semantic`: Meaning-based matching<br/>
        /// For details on when to use each option, see the [Transcription options](/v1.3/docs/concepts/modalities#transcription-options) section.<br/>
        /// **Default**: `["lexical", "semantic"]`.
        /// </param>
        /// <param name="adjustConfidenceLevel">
        /// &lt;Info&gt;<br/>
        ///   This parameter is deprecated in Marengo 3.0 and newer versions. Use the [`rank`](/v1.3/api-reference/any-to-video-search/make-search-request#response.body.data.rank) field in the response instead, which indicates the relevance ranking assigned by the model.<br/>
        /// &lt;/Info&gt;<br/>
        /// This parameter specifies the strictness of the thresholds for assigning the high, medium, or low confidence levels to search results. If you use a lower value, the thresholds become more relaxed, and more search results will be classified as having high, medium, or low confidence levels. You can use this parameter to include a broader range of potentially relevant video clips, even if some results might be less precise.<br/>
        /// **Min**: 0<br/>
        /// **Max**: 1<br/>
        /// **Default:** 0.5
        /// </param>
        /// <param name="groupBy">
        /// Use this parameter to group or ungroup items in a response. It can take one of the following values:<br/>
        /// - `video`:  The platform will group the matching video clips in the response by video.<br/>
        /// - `clip`: The matching video clips in the response will not be grouped.<br/>
        /// **Default:** `clip`<br/>
        /// Default Value: clip
        /// </param>
        /// <param name="threshold">
        /// &lt;Info&gt;<br/>
        ///   This parameter is deprecated in Marengo 3.0 and newer versions. Use the [`rank`](/v1.3/api-reference/any-to-video-search/make-search-request#response.body.data.rank)  field in the response instead, which indicates the relevance ranking assigned by the model.<br/>
        /// &lt;/Info&gt;<br/>
        /// Use this parameter to filter on the level of confidence that the results match your query.<br/>
        /// **Default**: `low`<br/>
        /// Default Value: low
        /// </param>
        /// <param name="sortOption">
        /// &lt;Info&gt;<br/>
        ///   This parameter is deprecated in Marengo 3.0 and newer versions. Use the [`rank`](/v1.3/api-reference/any-to-video-search/make-search-request#response.body.data.rank) field in the response instead, which indicates the relevance ranking assigned by the model.<br/>
        /// &lt;/Info&gt;<br/>
        /// Use this parameter to specify the sort order for the response.<br/>
        /// When performing a search, the platform assigns a relevance ranking to each video clip that matches your search terms. By default, the search results are sorted by relevance ranking in ascending order, with 1 being the most relevant result.<br/>
        /// If you set this parameter to `score` and `group_by` is set to `video`, the platform will determine the highest relevance ranking (lowest number) for each video and sort the videos in the response by this ranking. For each video, the matching video clips will be sorted by relevance ranking in ascending order.<br/>
        /// If you set this parameter to `clip_count` and `group_by` is set to `video`, the platform will sort the videos in the response by the number of clips. For each video, the matching video clips will be sorted by relevance ranking in ascending order. You can use `clip_count` only when the matching video clips are grouped by video.<br/>
        /// **Default:** `score`<br/>
        /// Default Value: score
        /// </param>
        /// <param name="operator">
        /// Combines multiple search options using `or` or `and`. Use `and` to find segments matching all search options. Use `or` to find segments matching any search option. For detailed guidance on using this parameter, see the [Combine multiple modalities](/v1.3/docs/concepts/modalities#combine-multiple-modalities) section.<br/>
        /// **Default**: `or`.<br/>
        /// Default Value: or
        /// </param>
        /// <param name="pageLimit">
        /// The number of items to return on each page. When grouping by video, this parameter represents the number of videos per page. Otherwise, it represents the maximum number of video clips per page.<br/>
        /// **Max**: `50`.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="filter">
        /// Specifies a stringified JSON object to filter your search results. Supports both system-generated metadata (example: video ID, duration) and user-defined metadata.<br/>
        /// **Syntax for filtering**<br/>
        /// The following table describes the supported data types, operators, and filter syntax:<br/>
        /// | Data type | Operator | Description | Syntax |<br/>
        /// |:----------|:---------|:------------|:-------|<br/>
        /// | String | `=` | Matches results equal to the specified value. | `{"field": "value"}`<br/>
        /// | Array of strings | `=` | Matches results with any value in the specified array. Supported only for `id`. | `{"id": ["value1", "value2"]}` |<br/>
        /// | Numeric (integer, float) | `=`, `lte`, `gte` | Matches results equal to or within a range of the specified value. | `{"field": number}` or `{"field": { "gte": number, "lte": number }}` |<br/>
        /// | Boolean | `=` | Matches results equal to the specified boolean value. | `{"field": true}` or `{"field": false}`. |<br/>
        /// &lt;br/&gt;<br/>
        /// **System-generated metadata**<br/>
        /// The table below describes the system-generated metadata available for filtering your  search results:<br/>
        /// | Field name | Description | Type | Example |<br/>
        /// |:-----------|:------------|:-----|:--------|<br/>
        /// | `id` | Filters by specific video IDs. | Array of strings | `{"id": ["67cec9caf45d9b64a58340fc", "67cec9baf45d9b64a58340fa"]}`. |<br/>
        /// | `duration` | Filters based on the duration of the video containing the segment that matches your query. | Number or object with `gte` and `lte` | `{"duration": 600}` or `{"duration": { "gte": 600, "lte": 800 }}` |<br/>
        /// | `width` | Filters by video width (in pixels). | Number or object with `gte` and `lte` | `{"width": 1920}` or `{"width": { "gte": 1280, "lte": 1920}}` |<br/>
        /// | `height` | Filters by video height (in pixels). | Number or object with `gte` and `lte`. | `{"height": 1080}` or `{"height": { "gte": 720, "lte": 1080 }}`. |<br/>
        /// | `size` | Filters by video size (in bytes) | Number or object with `gte` and `lte`. | `{"size": 1048576}` or `{"size": { "gte": 1048576, "lte": 5242880}}` |<br/>
        /// | `filename` | Filters by the exact file name. | String | `{"filename": "Animal Encounters part 1"}` |<br/>
        /// &lt;br/&gt;<br/>
        /// **User-defined metadata**<br/>
        /// To filter by user-defined metadata:<br/>
        /// 1. Add metadata to your video by calling the [`PUT`](/v1.3/api-reference/videos/update) method of the `/indexes/:index-id/videos/:video-id` endpoint<br/>
        /// 2. Reference the custom field in your filter object. For example, to filter videos where a custom field named `needsReview` of type boolean is `true`, use `{"needs_review": true}`.<br/>
        /// For more details and examples, see the [Filter search results](/v1.3/docs/guides/search/filtering) page.
        /// </param>
        /// <param name="includeUserMetadata">
        /// Specifies whether to include user-defined metadata in the search results.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SearchResults> CreateAsync(
            string xApiKey,
            string indexId,
            global::System.Collections.Generic.IList<global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems> searchOptions,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType? queryMediaType = default,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl? queryMediaUrl = default,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile? queryMediaFile = default,
            string? queryText = default,
            global::System.Collections.Generic.IList<global::G.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>? transcriptionOptions = default,
            double? adjustConfidenceLevel = default,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy? groupBy = default,
            global::G.ThresholdSearch? threshold = default,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSortOption? sortOption = default,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaOperator? @operator = default,
            int? pageLimit = default,
            string? filter = default,
            bool? includeUserMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateRequest7
            {
                QueryMediaType = queryMediaType,
                QueryMediaUrl = queryMediaUrl,
                QueryMediaFile = queryMediaFile,
                QueryText = queryText,
                IndexId = indexId,
                SearchOptions = searchOptions,
                TranscriptionOptions = transcriptionOptions,
                AdjustConfidenceLevel = adjustConfidenceLevel,
                GroupBy = groupBy,
                Threshold = threshold,
                SortOption = sortOption,
                Operator = @operator,
                PageLimit = pageLimit,
                Filter = filter,
                IncludeUserMetadata = includeUserMetadata,
            };

            return await CreateAsync(
                xApiKey: xApiKey,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}