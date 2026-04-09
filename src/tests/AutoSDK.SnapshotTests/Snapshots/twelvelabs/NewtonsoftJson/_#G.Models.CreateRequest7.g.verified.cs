//HintName: G.Models.CreateRequest7.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest7
    {
        /// <summary>
        /// The type of media you wish to use. This parameter is required for media queries. For example, to perform an image-based search, set this parameter to `image`. Use `query_text` together with this parameter when you want to perform a composed image+text search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_media_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaTypeJsonConverter))]
        public global::G.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType? QueryMediaType { get; set; }

        /// <summary>
        /// The publicly accessible URL of a media file to use as a query. This parameter is required for media queries if `query_media_file` is not provided.<br/>
        /// You can provide up to 10 images by specifying this parameter multiple times (Marengo 3.0 only):<br/>
        /// ```<br/>
        /// --form query_media_url=https://example.com/image1.jpg \<br/>
        /// --form query_media_url=https://example.com/image2.jpg<br/>
        /// ```
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_media_url")]
        public global::G.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl? QueryMediaUrl { get; set; }

        /// <summary>
        /// A local media file to use as a query. This parameter is required for media queries if `query_media_url` is not provided.<br/>
        /// You can provide up to 10 images by specifying this parameter multiple times (Marengo 3.0 only):<br/>
        /// ```<br/>
        /// --form query_media_file=@/path/to/image1.jpg \<br/>
        /// --form query_media_file=@/path/to/image2.jpg<br/>
        /// ```
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_media_file")]
        public global::G.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile? QueryMediaFile { get; set; }

        /// <summary>
        /// The text query to search for. This parameter is required for text queries. Note that the platform supports full natural language-based search. You can use this parameter together with `query_media_type` and `query_media_url` or `query_media_file` to perform a composed image+text search.<br/>
        /// If you're using the Entity Search feature to search for specific persons in your video content, you must enclose the unique identifier of your entity between the `&lt;@` and `&gt;` markers. For example, to search for an entity with the ID `entity123`, use `&lt;@entity123&gt; is walking` as your query.<br/>
        /// The maximum query length varies by model. Marengo 3.0 supports up to 500 tokens per query, while Marengo 2.7 supports up to 77 tokens per query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_text")]
        public string? QueryText { get; set; }

        /// <summary>
        /// The unique identifier of the index to search.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string IndexId { get; set; } = default!;

        /// <summary>
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
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems> SearchOptions { get; set; } = default!;

        /// <summary>
        /// Specifies how the platform matches your text query with the words spoken in the video. This parameter applies only when using Marengo 3.0 with the `search_options` parameter containing the `transcription` value.<br/>
        /// Available options:<br/>
        /// - `lexical`: Exact word matching<br/>
        /// - `semantic`: Meaning-based matching<br/>
        /// For details on when to use each option, see the [Transcription options](/v1.3/docs/concepts/modalities#transcription-options) section.<br/>
        /// **Default**: `["lexical", "semantic"]`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcription_options")]
        public global::System.Collections.Generic.IList<global::G.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>? TranscriptionOptions { get; set; }

        /// <summary>
        /// &lt;Info&gt;<br/>
        ///   This parameter is deprecated in Marengo 3.0 and newer versions. Use the [`rank`](/v1.3/api-reference/any-to-video-search/make-search-request#response.body.data.rank) field in the response instead, which indicates the relevance ranking assigned by the model.<br/>
        /// &lt;/Info&gt;<br/>
        /// This parameter specifies the strictness of the thresholds for assigning the high, medium, or low confidence levels to search results. If you use a lower value, the thresholds become more relaxed, and more search results will be classified as having high, medium, or low confidence levels. You can use this parameter to include a broader range of potentially relevant video clips, even if some results might be less precise.<br/>
        /// **Min**: 0<br/>
        /// **Max**: 1<br/>
        /// **Default:** 0.5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("adjust_confidence_level")]
        public double? AdjustConfidenceLevel { get; set; }

        /// <summary>
        /// Use this parameter to group or ungroup items in a response. It can take one of the following values:<br/>
        /// - `video`:  The platform will group the matching video clips in the response by video.<br/>
        /// - `clip`: The matching video clips in the response will not be grouped.<br/>
        /// **Default:** `clip`<br/>
        /// Default Value: clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_by")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaGroupByJsonConverter))]
        public global::G.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy? GroupBy { get; set; }

        /// <summary>
        /// &lt;Info&gt;<br/>
        ///   This parameter is deprecated in Marengo 3.0 and newer versions. Use the [`rank`](/v1.3/api-reference/any-to-video-search/make-search-request#response.body.data.rank)  field in the response instead, which indicates the relevance ranking assigned by the model.<br/>
        /// &lt;/Info&gt;<br/>
        /// Use this parameter to filter on the level of confidence that the results match your query.<br/>
        /// **Default**: `low`<br/>
        /// Default Value: low
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ThresholdSearchJsonConverter))]
        public global::G.ThresholdSearch? Threshold { get; set; }

        /// <summary>
        /// &lt;Info&gt;<br/>
        ///   This parameter is deprecated in Marengo 3.0 and newer versions. Use the [`rank`](/v1.3/api-reference/any-to-video-search/make-search-request#response.body.data.rank) field in the response instead, which indicates the relevance ranking assigned by the model.<br/>
        /// &lt;/Info&gt;<br/>
        /// Use this parameter to specify the sort order for the response.<br/>
        /// When performing a search, the platform assigns a relevance ranking to each video clip that matches your search terms. By default, the search results are sorted by relevance ranking in ascending order, with 1 being the most relevant result.<br/>
        /// If you set this parameter to `score` and `group_by` is set to `video`, the platform will determine the highest relevance ranking (lowest number) for each video and sort the videos in the response by this ranking. For each video, the matching video clips will be sorted by relevance ranking in ascending order.<br/>
        /// If you set this parameter to `clip_count` and `group_by` is set to `video`, the platform will sort the videos in the response by the number of clips. For each video, the matching video clips will be sorted by relevance ranking in ascending order. You can use `clip_count` only when the matching video clips are grouped by video.<br/>
        /// **Default:** `score`<br/>
        /// Default Value: score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sort_option")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSortOptionJsonConverter))]
        public global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSortOption? SortOption { get; set; }

        /// <summary>
        /// Combines multiple search options using `or` or `and`. Use `and` to find segments matching all search options. Use `or` to find segments matching any search option. For detailed guidance on using this parameter, see the [Combine multiple modalities](/v1.3/docs/concepts/modalities#combine-multiple-modalities) section.<br/>
        /// **Default**: `or`.<br/>
        /// Default Value: or
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorJsonConverter))]
        public global::G.SearchPostRequestBodyContentMultipartFormDataSchemaOperator? Operator { get; set; }

        /// <summary>
        /// The number of items to return on each page. When grouping by video, this parameter represents the number of videos per page. Otherwise, it represents the maximum number of video clips per page.<br/>
        /// **Max**: `50`.<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_limit")]
        public int? PageLimit { get; set; }

        /// <summary>
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
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Specifies whether to include user-defined metadata in the search results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_user_metadata")]
        public bool? IncludeUserMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest7" /> class.
        /// </summary>
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
        public CreateRequest7(
            string indexId,
            global::System.Collections.Generic.IList<global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItems> searchOptions,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaType? queryMediaType,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrl? queryMediaUrl,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFile? queryMediaFile,
            string? queryText,
            global::System.Collections.Generic.IList<global::G.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItems>? transcriptionOptions,
            double? adjustConfidenceLevel,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaGroupBy? groupBy,
            global::G.ThresholdSearch? threshold,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaSortOption? sortOption,
            global::G.SearchPostRequestBodyContentMultipartFormDataSchemaOperator? @operator,
            int? pageLimit,
            string? filter,
            bool? includeUserMetadata)
        {
            this.QueryMediaType = queryMediaType;
            this.QueryMediaUrl = queryMediaUrl;
            this.QueryMediaFile = queryMediaFile;
            this.QueryText = queryText;
            this.IndexId = indexId ?? throw new global::System.ArgumentNullException(nameof(indexId));
            this.SearchOptions = searchOptions ?? throw new global::System.ArgumentNullException(nameof(searchOptions));
            this.TranscriptionOptions = transcriptionOptions;
            this.AdjustConfidenceLevel = adjustConfidenceLevel;
            this.GroupBy = groupBy;
            this.Threshold = threshold;
            this.SortOption = sortOption;
            this.Operator = @operator;
            this.PageLimit = pageLimit;
            this.Filter = filter;
            this.IncludeUserMetadata = includeUserMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest7" /> class.
        /// </summary>
        public CreateRequest7()
        {
        }
    }
}