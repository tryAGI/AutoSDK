//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.twelvelabs.io/v1.3";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodJsonConverter(),
                    new global::G.JsonConverters.AssetsPostRequestBodyContentMultipartFormDataSchemaMethodNullableJsonConverter(),
                    new global::G.JsonConverters.AssetMethodJsonConverter(),
                    new global::G.JsonConverters.AssetMethodNullableJsonConverter(),
                    new global::G.JsonConverters.AssetStatusJsonConverter(),
                    new global::G.JsonConverters.AssetStatusNullableJsonConverter(),
                    new global::G.JsonConverters.AssetsGetParametersAssetTypesSchemaItemsJsonConverter(),
                    new global::G.JsonConverters.AssetsGetParametersAssetTypesSchemaItemsNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAssetUploadRequestTypeJsonConverter(),
                    new global::G.JsonConverters.CreateAssetUploadRequestTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MultipartUploadStatusTypeJsonConverter(),
                    new global::G.JsonConverters.MultipartUploadStatusTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChunkInfoStatusJsonConverter(),
                    new global::G.JsonConverters.ChunkInfoStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CompletedChunkProofTypeJsonConverter(),
                    new global::G.JsonConverters.CompletedChunkProofTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TasksGetParametersStatusSchemaItemsJsonConverter(),
                    new global::G.JsonConverters.TasksGetParametersStatusSchemaItemsNullableJsonConverter(),
                    new global::G.JsonConverters.HlsObjectStatusJsonConverter(),
                    new global::G.JsonConverters.HlsObjectStatusNullableJsonConverter(),
                    new global::G.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsJsonConverter(),
                    new global::G.JsonConverters.IndexesIndexIdIndexedAssetsIndexedAssetIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter(),
                    new global::G.JsonConverters.IndexedAssetStatusJsonConverter(),
                    new global::G.JsonConverters.IndexedAssetStatusNullableJsonConverter(),
                    new global::G.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsJsonConverter(),
                    new global::G.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersStatusSchemaItemsNullableJsonConverter(),
                    new global::G.JsonConverters.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsJsonConverter(),
                    new global::G.JsonConverters.IndexesIndexIdVideosVideoIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter(),
                    new global::G.JsonConverters.EntityCollectionsGetParametersSortByJsonConverter(),
                    new global::G.JsonConverters.EntityCollectionsGetParametersSortByNullableJsonConverter(),
                    new global::G.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusJsonConverter(),
                    new global::G.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersStatusNullableJsonConverter(),
                    new global::G.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByJsonConverter(),
                    new global::G.JsonConverters.EntityCollectionsEntityCollectionIdEntitiesGetParametersSortByNullableJsonConverter(),
                    new global::G.JsonConverters.EntityStatusJsonConverter(),
                    new global::G.JsonConverters.EntityStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaTypeJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSearchOptionsItemsNullableJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaTranscriptionOptionsItemsNullableJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaGroupByJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaGroupByNullableJsonConverter(),
                    new global::G.JsonConverters.ThresholdSearchJsonConverter(),
                    new global::G.JsonConverters.ThresholdSearchNullableJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSortOptionJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaSortOptionNullableJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaOperatorNullableJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingsRequestInputTypeJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingsRequestInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingsRequestModelNameJsonConverter(),
                    new global::G.JsonConverters.CreateEmbeddingsRequestModelNameNullableJsonConverter(),
                    new global::G.JsonConverters.AudioSegmentationStrategyJsonConverter(),
                    new global::G.JsonConverters.AudioSegmentationStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.AudioInputRequestEmbeddingOptionItemsJsonConverter(),
                    new global::G.JsonConverters.AudioInputRequestEmbeddingOptionItemsNullableJsonConverter(),
                    new global::G.JsonConverters.AudioInputRequestEmbeddingScopeItemsJsonConverter(),
                    new global::G.JsonConverters.AudioInputRequestEmbeddingScopeItemsNullableJsonConverter(),
                    new global::G.JsonConverters.AudioInputRequestEmbeddingTypeItemsJsonConverter(),
                    new global::G.JsonConverters.AudioInputRequestEmbeddingTypeItemsNullableJsonConverter(),
                    new global::G.JsonConverters.VideoSegmentation0StrategyJsonConverter(),
                    new global::G.JsonConverters.VideoSegmentation0StrategyNullableJsonConverter(),
                    new global::G.JsonConverters.VideoSegmentation1StrategyJsonConverter(),
                    new global::G.JsonConverters.VideoSegmentation1StrategyNullableJsonConverter(),
                    new global::G.JsonConverters.VideoInputRequestEmbeddingOptionItemsJsonConverter(),
                    new global::G.JsonConverters.VideoInputRequestEmbeddingOptionItemsNullableJsonConverter(),
                    new global::G.JsonConverters.VideoInputRequestEmbeddingScopeItemsJsonConverter(),
                    new global::G.JsonConverters.VideoInputRequestEmbeddingScopeItemsNullableJsonConverter(),
                    new global::G.JsonConverters.VideoInputRequestEmbeddingTypeItemsJsonConverter(),
                    new global::G.JsonConverters.VideoInputRequestEmbeddingTypeItemsNullableJsonConverter(),
                    new global::G.JsonConverters.MultiInputMediaSourceMediaTypeJsonConverter(),
                    new global::G.JsonConverters.MultiInputMediaSourceMediaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingDataEmbeddingOptionJsonConverter(),
                    new global::G.JsonConverters.EmbeddingDataEmbeddingOptionNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingDataEmbeddingScopeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingDataEmbeddingScopeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingImageMetadataInputTypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingImageMetadataInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingTextImageMetadataInputTypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingTextImageMetadataInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingAudioMetadataInputTypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingAudioMetadataInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingAudioMetadataEmbeddingScopesItemsJsonConverter(),
                    new global::G.JsonConverters.EmbeddingAudioMetadataEmbeddingScopesItemsNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingVideoMetadataInputTypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingVideoMetadataInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingVideoMetadataEmbeddingScopesItemsJsonConverter(),
                    new global::G.JsonConverters.EmbeddingVideoMetadataEmbeddingScopesItemsNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingMultiInputMetadataInputTypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingMultiInputMetadataInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAsyncEmbeddingRequestInputTypeJsonConverter(),
                    new global::G.JsonConverters.CreateAsyncEmbeddingRequestInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAsyncEmbeddingRequestModelNameJsonConverter(),
                    new global::G.JsonConverters.CreateAsyncEmbeddingRequestModelNameNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusJsonConverter(),
                    new global::G.JsonConverters.EmbedV2TasksPostResponsesContentApplicationJsonSchemaStatusNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingTaskResponseStatusJsonConverter(),
                    new global::G.JsonConverters.EmbeddingTaskResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsJsonConverter(),
                    new global::G.JsonConverters.EmbedTasksPostRequestBodyContentMultipartFormDataSchemaVideoEmbeddingScopeItemsNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsJsonConverter(),
                    new global::G.JsonConverters.EmbedTasksTaskIdGetParametersEmbeddingOptionSchemaItemsNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StreamStartResponseEventTypeJsonConverter(),
                    new global::G.JsonConverters.StreamStartResponseEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StreamTextResponseEventTypeJsonConverter(),
                    new global::G.JsonConverters.StreamTextResponseEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StreamEndResponseEventTypeJsonConverter(),
                    new global::G.JsonConverters.StreamEndResponseEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FinishReasonJsonConverter(),
                    new global::G.JsonConverters.FinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.IndexesIndexIdIndexedAssetsGetParametersUserMetadataSchemaJsonConverter(),
                    new global::G.JsonConverters.IndexesIndexIdVideosGetParametersUserMetadataSchemaJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaUrlJsonConverter(),
                    new global::G.JsonConverters.SearchPostRequestBodyContentMultipartFormDataSchemaQueryMediaFileJsonConverter(),
                    new global::G.JsonConverters.VideoSegmentationJsonConverter(),
                    new global::G.JsonConverters.EmbeddingMediaMetadataJsonConverter(),
                    new global::G.JsonConverters.EmbeddingTaskMediaMetadataJsonConverter(),
                    new global::G.JsonConverters.StreamAnalyzeResponseJsonConverter(),
                    new global::G.JsonConverters.AnalyzeResponse200JsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.EmbeddingDataEmbeddingOption?, object>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.EmbeddingDataEmbeddingScope?, object>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public SubpackageAssetsClient SubpackageAssets => new SubpackageAssetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageEmbedClient SubpackageEmbed => new SubpackageEmbedClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageEmbedSubpackageEmbedTasksClient SubpackageEmbedSubpackageEmbedTasks => new SubpackageEmbedSubpackageEmbedTasksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageEmbedSubpackageEmbedV2Client SubpackageEmbedSubpackageEmbedV2 => new SubpackageEmbedSubpackageEmbedV2Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageEmbedSubpackageEmbedV2SubpackageEmbedV2TasksClient SubpackageEmbedSubpackageEmbedV2SubpackageEmbedV2Tasks => new SubpackageEmbedSubpackageEmbedV2SubpackageEmbedV2TasksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageEntityCollectionsClient SubpackageEntityCollections => new SubpackageEntityCollectionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient SubpackageEntityCollectionsSubpackageEntityCollectionsEntities => new SubpackageEntityCollectionsSubpackageEntityCollectionsEntitiesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageIndexesClient SubpackageIndexes => new SubpackageIndexesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageIndexesSubpackageIndexesIndexedAssetsClient SubpackageIndexesSubpackageIndexesIndexedAssets => new SubpackageIndexesSubpackageIndexesIndexedAssetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageIndexesSubpackageIndexesVideosClient SubpackageIndexesSubpackageIndexesVideos => new SubpackageIndexesSubpackageIndexesVideosClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageMultipartUploadClient SubpackageMultipartUpload => new SubpackageMultipartUploadClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageSearchClient SubpackageSearch => new SubpackageSearchClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTasksClient SubpackageTasks => new SubpackageTasksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageTasksSubpackageTasksTransfersClient SubpackageTasksSubpackageTasksTransfers => new SubpackageTasksSubpackageTasksTransfersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}