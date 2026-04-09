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
        /// mixedbread ai production server
        /// </summary>
        public const string DefaultBaseUrl = "https://api.mixedbread.com/";

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

        /// <inheritdoc/>
        public global::G.AutoSDKClientOptions Options { get; }
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
                    new global::G.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.AudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChunkingStrategyJsonConverter(),
                    new global::G.JsonConverters.ChunkingStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.ConditionOperatorJsonConverter(),
                    new global::G.JsonConverters.ConditionOperatorNullableJsonConverter(),
                    new global::G.JsonConverters.DataSourceAuthParamsVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.DataSourceAuthParamsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DataSourceTypeJsonConverter(),
                    new global::G.JsonConverters.DataSourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ElementTypeJsonConverter(),
                    new global::G.JsonConverters.ElementTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EncodingFormat3JsonConverter(),
                    new global::G.JsonConverters.EncodingFormat3NullableJsonConverter(),
                    new global::G.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ModeJsonConverter(),
                    new global::G.JsonConverters.ModeNullableJsonConverter(),
                    new global::G.JsonConverters.MultiModalQueryVariant2DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MultiModalQueryVariant2DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ParsingJobStatusJsonConverter(),
                    new global::G.JsonConverters.ParsingJobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.RegexFlagJsonConverter(),
                    new global::G.JsonConverters.RegexFlagNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnFormatJsonConverter(),
                    new global::G.JsonConverters.ReturnFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ScopeMethodJsonConverter(),
                    new global::G.JsonConverters.ScopeMethodNullableJsonConverter(),
                    new global::G.JsonConverters.ScoredStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ScoredStoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScoredVectorStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ScoredVectorStoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StoreEventHistogramBucketTypeJsonConverter(),
                    new global::G.JsonConverters.StoreEventHistogramBucketTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StoreEventListResponseDataItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.StoreEventListResponseDataItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.StoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StoreFileParsingStrategyJsonConverter(),
                    new global::G.JsonConverters.StoreFileParsingStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.StoreFileStatusJsonConverter(),
                    new global::G.JsonConverters.StoreFileStatusNullableJsonConverter(),
                    new global::G.JsonConverters.StoreQAResultsSourceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.StoreQAResultsSourceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StoreSearchResponseDataItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.StoreSearchResponseDataItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StoreStatusJsonConverter(),
                    new global::G.JsonConverters.StoreStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SyncStatusJsonConverter(),
                    new global::G.JsonConverters.SyncStatusNullableJsonConverter(),
                    new global::G.JsonConverters.TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.TextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileStatusJsonConverter(),
                    new global::G.JsonConverters.VectorStoreFileStatusNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStoreQAResultsSourceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.VectorStoreQAResultsSourceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.VectorStoreSearchResponseDataItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.VectorStoreSearchResponseDataItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.VideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleCreateParamsRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleUpdateParamsRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredAudioUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredImageUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MxbaiOmniCoreStoreModelsChunkTypesScoredVideoUrlInputChunkGeneratedMetadataVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListStoreEventsEventTypeJsonConverter(),
                    new global::G.JsonConverters.ListStoreEventsEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GeneratedMetadataVariant1JsonConverter(),
                    new global::G.JsonConverters.AuthParamsVariant1JsonConverter(),
                    new global::G.JsonConverters.EmbeddingItemJsonConverter(),
                    new global::G.JsonConverters.GeneratedMetadataVariant12JsonConverter(),
                    new global::G.JsonConverters.AuthParamsVariant12JsonConverter(),
                    new global::G.JsonConverters.MultiModalQueryJsonConverter(),
                    new global::G.JsonConverters.MultiModalQueryVariant2JsonConverter(),
                    new global::G.JsonConverters.AuthParamsVariant13JsonConverter(),
                    new global::G.JsonConverters.ChunksVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.ChunksVariant1Item2JsonConverter(),
                    new global::G.JsonConverters.DataItemJsonConverter(),
                    new global::G.JsonConverters.ChunksVariant1Item3JsonConverter(),
                    new global::G.JsonConverters.SourcesItemJsonConverter(),
                    new global::G.JsonConverters.DataItem2JsonConverter(),
                    new global::G.JsonConverters.GeneratedMetadataVariant13JsonConverter(),
                    new global::G.JsonConverters.ChunksVariant1Item4JsonConverter(),
                    new global::G.JsonConverters.SourcesItem2JsonConverter(),
                    new global::G.JsonConverters.DataItem3JsonConverter(),
                    new global::G.JsonConverters.GeneratedMetadataVariant14JsonConverter(),
                    new global::G.JsonConverters.GeneratedMetadataVariant15JsonConverter(),
                    new global::G.JsonConverters.GeneratedMetadataVariant16JsonConverter(),
                    new global::G.JsonConverters.GeneratedMetadataVariant17JsonConverter(),
                    new global::G.JsonConverters.GeneratedMetadataVariant18JsonConverter(),
                    new global::G.JsonConverters.RulesItemJsonConverter(),
                    new global::G.JsonConverters.RulesItem2JsonConverter(),
                    new global::G.JsonConverters.RuleJsonConverter(),
                    new global::G.JsonConverters.DeletedRuleJsonConverter(),
                    new global::G.JsonConverters.RulesVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.RulesItem3JsonConverter(),
                    new global::G.JsonConverters.RulesItem4JsonConverter(),
                    new global::G.JsonConverters.Rule2JsonConverter(),
                    new global::G.JsonConverters.DeletedRule2JsonConverter(),
                    new global::G.JsonConverters.RulesVariant1Item2JsonConverter(),
                    new global::G.JsonConverters.GeneratedMetadataVariant19JsonConverter(),
                    new global::G.JsonConverters.GeneratedMetadataVariant110JsonConverter(),
                    new global::G.JsonConverters.GeneratedMetadataVariant111JsonConverter(),
                    new global::G.JsonConverters.GeneratedMetadataVariant112JsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.EncodingFormat3?, global::System.Collections.Generic.IList<global::G.EncodingFormat3>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.Embedding>, global::System.Collections.Generic.IList<global::G.MultiEncodingEmbedding>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.EncodingFormat3?, global::System.Collections.Generic.IList<global::G.EncodingFormat3>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextInput, global::G.ImageUrlInput2>>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.TextInput, global::G.ImageUrlInput2>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, global::G.RerankConfig, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, global::G.AgenticSearchConfig, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, global::G.ContextualizationConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, global::G.RerankConfig, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, global::G.AgenticSearchConfig, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, global::G.RerankConfig, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, global::G.AgenticSearchConfig, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, global::G.RerankConfig, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, global::G.AgenticSearchConfig, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.SearchFilter, global::G.SearchFilterCondition>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SearchFilter, global::G.SearchFilterCondition>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.NotionDataSourceCreateOrUpdateParams, global::G.LinearDataSourceCreateOrUpdateParams>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.NotionDataSourceCreateOrUpdateParams, global::G.LinearDataSourceCreateOrUpdateParams>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<int>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AdminClient Admin => new AdminClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys => new ApiKeysClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing => new BillingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CompletionsClient Completions => new CompletionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataSourcesClient DataSources => new DataSourcesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DeprecatedVectorStoresClient DeprecatedVectorStores => new DeprecatedVectorStoresClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExtractionsClient Extractions => new ExtractionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ParsingClient Parsing => new ParsingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SchemasClient Schemas => new SchemasClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StoresClient Stores => new StoresClient(HttpClient, authorizations: Authorizations, options: Options)
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
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            global::G.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            Options = options ?? new global::G.AutoSDKClientOptions();
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