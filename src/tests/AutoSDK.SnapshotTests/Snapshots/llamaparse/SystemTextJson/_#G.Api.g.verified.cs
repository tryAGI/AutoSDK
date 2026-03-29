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
        public const string DefaultBaseUrl = "https://api.cloud.llamaindex.ai";

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
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.ApplyStatusDetailsStatusJsonConverter(),
                    new global::G.JsonConverters.ApplyStatusDetailsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.AutoModeParsingConfTier2JsonConverter(),
                    new global::G.JsonConverters.AutoModeParsingConfTier2NullableJsonConverter(),
                    new global::G.JsonConverters.AutoModeParsingConfVersionJsonConverter(),
                    new global::G.JsonConverters.AutoModeParsingConfVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AutoModeParsingConfSpecializedChartParsing2JsonConverter(),
                    new global::G.JsonConverters.AutoModeParsingConfSpecializedChartParsing2NullableJsonConverter(),
                    new global::G.JsonConverters.BatchFileStatusJsonConverter(),
                    new global::G.JsonConverters.BatchFileStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BatchJobStatusJsonConverter(),
                    new global::G.JsonConverters.BatchJobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BatchJobTypeJsonConverter(),
                    new global::G.JsonConverters.BatchJobTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BatchParseJobConfigPriority2JsonConverter(),
                    new global::G.JsonConverters.BatchParseJobConfigPriority2NullableJsonConverter(),
                    new global::G.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.BatchParseJobConfigImagesToSaveVariant1ItemNullableJsonConverter(),
                    new global::G.JsonConverters.BoxAuthMechanismJsonConverter(),
                    new global::G.JsonConverters.BoxAuthMechanismNullableJsonConverter(),
                    new global::G.JsonConverters.ClassifyModeJsonConverter(),
                    new global::G.JsonConverters.ClassifyModeNullableJsonConverter(),
                    new global::G.JsonConverters.ClassifyV2JobResponseStatusJsonConverter(),
                    new global::G.JsonConverters.ClassifyV2JobResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ClassifyV2JobResponseDocumentInputTypeJsonConverter(),
                    new global::G.JsonConverters.ClassifyV2JobResponseDocumentInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CloudJiraDataSourceV2ApiVersionJsonConverter(),
                    new global::G.JsonConverters.CloudJiraDataSourceV2ApiVersionNullableJsonConverter(),
                    new global::G.JsonConverters.CompositeRetrievalModeJsonConverter(),
                    new global::G.JsonConverters.CompositeRetrievalModeNullableJsonConverter(),
                    new global::G.JsonConverters.ConfigurableDataSinkNamesJsonConverter(),
                    new global::G.JsonConverters.ConfigurableDataSinkNamesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfigurableDataSourceNamesJsonConverter(),
                    new global::G.JsonConverters.ConfigurableDataSourceNamesNullableJsonConverter(),
                    new global::G.JsonConverters.ConfigurationCreateRequestParametersDiscriminatorProductTypeJsonConverter(),
                    new global::G.JsonConverters.ConfigurationCreateRequestParametersDiscriminatorProductTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConfigurationResponseProductTypeJsonConverter(),
                    new global::G.JsonConverters.ConfigurationResponseProductTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConfigurationResponseParametersDiscriminatorProductTypeJsonConverter(),
                    new global::G.JsonConverters.ConfigurationResponseParametersDiscriminatorProductTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeJsonConverter(),
                    new global::G.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DataSourceReaderVersionMetadataReaderVersion2JsonConverter(),
                    new global::G.JsonConverters.DataSourceReaderVersionMetadataReaderVersion2NullableJsonConverter(),
                    new global::G.JsonConverters.DiffingStatusDetailsStatusJsonConverter(),
                    new global::G.JsonConverters.DiffingStatusDetailsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.DocumentChunkModeJsonConverter(),
                    new global::G.JsonConverters.DocumentChunkModeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelConfigEmbeddingConfigDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelConfigCreateEmbeddingConfigDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelConfigUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ExtractConfigPriority2JsonConverter(),
                    new global::G.JsonConverters.ExtractConfigPriority2NullableJsonConverter(),
                    new global::G.JsonConverters.ExtractConfigurationTierJsonConverter(),
                    new global::G.JsonConverters.ExtractConfigurationTierNullableJsonConverter(),
                    new global::G.JsonConverters.ExtractConfigurationExtractionTargetJsonConverter(),
                    new global::G.JsonConverters.ExtractConfigurationExtractionTargetNullableJsonConverter(),
                    new global::G.JsonConverters.ExtractJobStatusJsonConverter(),
                    new global::G.JsonConverters.ExtractJobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ExtractJobCreatePriority2JsonConverter(),
                    new global::G.JsonConverters.ExtractJobCreatePriority2NullableJsonConverter(),
                    new global::G.JsonConverters.ExtractModeJsonConverter(),
                    new global::G.JsonConverters.ExtractModeNullableJsonConverter(),
                    new global::G.JsonConverters.ExtractModelsJsonConverter(),
                    new global::G.JsonConverters.ExtractModelsNullableJsonConverter(),
                    new global::G.JsonConverters.ExtractStateJsonConverter(),
                    new global::G.JsonConverters.ExtractStateNullableJsonConverter(),
                    new global::G.JsonConverters.ExtractTargetJsonConverter(),
                    new global::G.JsonConverters.ExtractTargetNullableJsonConverter(),
                    new global::G.JsonConverters.ExtractV2ParametersTierJsonConverter(),
                    new global::G.JsonConverters.ExtractV2ParametersTierNullableJsonConverter(),
                    new global::G.JsonConverters.ExtractV2ParametersExtractionTargetJsonConverter(),
                    new global::G.JsonConverters.ExtractV2ParametersExtractionTargetNullableJsonConverter(),
                    new global::G.JsonConverters.FailPageModeJsonConverter(),
                    new global::G.JsonConverters.FailPageModeNullableJsonConverter(),
                    new global::G.JsonConverters.FileCreateStorageTypeJsonConverter(),
                    new global::G.JsonConverters.FileCreateStorageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FileCreateFromUrlStorageTypeJsonConverter(),
                    new global::G.JsonConverters.FileCreateFromUrlStorageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FilterConditionJsonConverter(),
                    new global::G.JsonConverters.FilterConditionNullableJsonConverter(),
                    new global::G.JsonConverters.FilterOperatorJsonConverter(),
                    new global::G.JsonConverters.FilterOperatorNullableJsonConverter(),
                    new global::G.JsonConverters.FooterItemItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.FooterItemItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.HeaderItemItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.HeaderItemItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageMetadataCategory2JsonConverter(),
                    new global::G.JsonConverters.ImageMetadataCategory2NullableJsonConverter(),
                    new global::G.JsonConverters.JobNameMappingJsonConverter(),
                    new global::G.JsonConverters.JobNameMappingNullableJsonConverter(),
                    new global::G.JsonConverters.ListingStatusDetailsStatusJsonConverter(),
                    new global::G.JsonConverters.ListingStatusDetailsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.LlamaParseOutputOptionsImagesToSaveItemJsonConverter(),
                    new global::G.JsonConverters.LlamaParseOutputOptionsImagesToSaveItemNullableJsonConverter(),
                    new global::G.JsonConverters.LlamaParseParametersPriority2JsonConverter(),
                    new global::G.JsonConverters.LlamaParseParametersPriority2NullableJsonConverter(),
                    new global::G.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.LlamaParseParametersImagesToSaveVariant1ItemNullableJsonConverter(),
                    new global::G.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing2JsonConverter(),
                    new global::G.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing2NullableJsonConverter(),
                    new global::G.JsonConverters.LlamaParseSupportedFileExtensionsJsonConverter(),
                    new global::G.JsonConverters.LlamaParseSupportedFileExtensionsNullableJsonConverter(),
                    new global::G.JsonConverters.ManagedIngestionStatusJsonConverter(),
                    new global::G.JsonConverters.ManagedIngestionStatusNullableJsonConverter(),
                    new global::G.JsonConverters.MessageRoleJsonConverter(),
                    new global::G.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.NodeRelationshipJsonConverter(),
                    new global::G.JsonConverters.NodeRelationshipNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectTypeJsonConverter(),
                    new global::G.JsonConverters.ObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PGVectorDistanceMethodJsonConverter(),
                    new global::G.JsonConverters.PGVectorDistanceMethodNullableJsonConverter(),
                    new global::G.JsonConverters.PGVectorVectorTypeJsonConverter(),
                    new global::G.JsonConverters.PGVectorVectorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ParseJobResponseStatusJsonConverter(),
                    new global::G.JsonConverters.ParseJobResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ParsePlanLevelJsonConverter(),
                    new global::G.JsonConverters.ParsePlanLevelNullableJsonConverter(),
                    new global::G.JsonConverters.ParseRequestConfigurationTierJsonConverter(),
                    new global::G.JsonConverters.ParseRequestConfigurationTierNullableJsonConverter(),
                    new global::G.JsonConverters.ParseRequestConfigurationVersionJsonConverter(),
                    new global::G.JsonConverters.ParseRequestConfigurationVersionNullableJsonConverter(),
                    new global::G.JsonConverters.ParseV2ParametersTierJsonConverter(),
                    new global::G.JsonConverters.ParseV2ParametersTierNullableJsonConverter(),
                    new global::G.JsonConverters.ParseV2ParametersVersionJsonConverter(),
                    new global::G.JsonConverters.ParseV2ParametersVersionNullableJsonConverter(),
                    new global::G.JsonConverters.ParserLanguagesJsonConverter(),
                    new global::G.JsonConverters.ParserLanguagesNullableJsonConverter(),
                    new global::G.JsonConverters.ParsingModeJsonConverter(),
                    new global::G.JsonConverters.ParsingModeNullableJsonConverter(),
                    new global::G.JsonConverters.PartitionNamesJsonConverter(),
                    new global::G.JsonConverters.PartitionNamesNullableJsonConverter(),
                    new global::G.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PipelineEmbeddingConfigDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelineStatus2JsonConverter(),
                    new global::G.JsonConverters.PipelineStatus2NullableJsonConverter(),
                    new global::G.JsonConverters.PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PipelineCreateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelineDataSourceStatus2JsonConverter(),
                    new global::G.JsonConverters.PipelineDataSourceStatus2NullableJsonConverter(),
                    new global::G.JsonConverters.PipelineFileStatus2JsonConverter(),
                    new global::G.JsonConverters.PipelineFileStatus2NullableJsonConverter(),
                    new global::G.JsonConverters.PipelineFileResponseStatus2JsonConverter(),
                    new global::G.JsonConverters.PipelineFileResponseStatus2NullableJsonConverter(),
                    new global::G.JsonConverters.PipelineTypeJsonConverter(),
                    new global::G.JsonConverters.PipelineTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.PipelineUpdateEmbeddingConfigVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PoolingJsonConverter(),
                    new global::G.JsonConverters.PoolingNullableJsonConverter(),
                    new global::G.JsonConverters.PublicModelNameJsonConverter(),
                    new global::G.JsonConverters.PublicModelNameNullableJsonConverter(),
                    new global::G.JsonConverters.ReRankerTypeJsonConverter(),
                    new global::G.JsonConverters.ReRankerTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RetrievalModeJsonConverter(),
                    new global::G.JsonConverters.RetrievalModeNullableJsonConverter(),
                    new global::G.JsonConverters.SparseModelTypeJsonConverter(),
                    new global::G.JsonConverters.SparseModelTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SplitStrategyAllowUncategorizedJsonConverter(),
                    new global::G.JsonConverters.SplitStrategyAllowUncategorizedNullableJsonConverter(),
                    new global::G.JsonConverters.SpreadsheetParsingConfigTableMergeSensitivityJsonConverter(),
                    new global::G.JsonConverters.SpreadsheetParsingConfigTableMergeSensitivityNullableJsonConverter(),
                    new global::G.JsonConverters.SpreadsheetResultTypeJsonConverter(),
                    new global::G.JsonConverters.SpreadsheetResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StatusEnumJsonConverter(),
                    new global::G.JsonConverters.StatusEnumNullableJsonConverter(),
                    new global::G.JsonConverters.StructuredResultPageItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.StructuredResultPageItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SupportedLLMModelNamesJsonConverter(),
                    new global::G.JsonConverters.SupportedLLMModelNamesNullableJsonConverter(),
                    new global::G.JsonConverters.UsageMetricEventTypeJsonConverter(),
                    new global::G.JsonConverters.UsageMetricEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.VertexEmbeddingModeJsonConverter(),
                    new global::G.JsonConverters.VertexEmbeddingModeNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.WebhookConfigurationWebhookEventsVariant1ItemNullableJsonConverter(),
                    new global::G.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemNullableJsonConverter(),
                    new global::G.JsonConverters.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyJsonConverter(),
                    new global::G.JsonConverters.ListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsGetStatusRefreshPolicyNullableJsonConverter(),
                    new global::G.JsonConverters.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicyJsonConverter(),
                    new global::G.JsonConverters.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicyNullableJsonConverter(),
                    new global::G.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.ListConfigurationsApiV1BetaConfigurationsGetProductTypeVariant1ItemNullableJsonConverter(),
                    new global::G.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2JsonConverter(),
                    new global::G.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2NullableJsonConverter(),
                    new global::G.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemNullableJsonConverter(),
                    new global::G.JsonConverters.ListParseJobsApiV2ParseGetStatus2JsonConverter(),
                    new global::G.JsonConverters.ListParseJobsApiV2ParseGetStatus2NullableJsonConverter(),
                    new global::G.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatus2JsonConverter(),
                    new global::G.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatus2NullableJsonConverter(),
                    new global::G.JsonConverters.ListExtractJobsApiV2ExtractGetStatus2JsonConverter(),
                    new global::G.JsonConverters.ListExtractJobsApiV2ExtractGetStatus2NullableJsonConverter(),
                    new global::G.JsonConverters.ParametersJsonConverter(),
                    new global::G.JsonConverters.Parameters2JsonConverter(),
                    new global::G.JsonConverters.ParametersVariant1JsonConverter(),
                    new global::G.JsonConverters.EmbeddingConfigJsonConverter(),
                    new global::G.JsonConverters.EmbeddingConfig2JsonConverter(),
                    new global::G.JsonConverters.EmbeddingConfigVariant1JsonConverter(),
                    new global::G.JsonConverters.ItemsItemJsonConverter(),
                    new global::G.JsonConverters.ItemsItem2JsonConverter(),
                    new global::G.JsonConverters.EmbeddingConfig3JsonConverter(),
                    new global::G.JsonConverters.EmbeddingConfigVariant12JsonConverter(),
                    new global::G.JsonConverters.EmbeddingConfigVariant13JsonConverter(),
                    new global::G.JsonConverters.ItemsItem4JsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.NoneSegmentationConfig, global::G.PageSegmentationConfig, global::G.ElementSegmentationConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.NoneChunkingConfig, global::G.CharacterChunkingConfig, global::G.TokenChunkingConfig, global::G.SentenceChunkingConfig, global::G.SemanticChunkingConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.AutoModeParsingConfVersion?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.BatchParseJobRecordCreate, global::G.ClassifyJob>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::G.CloudPineconeVectorStore, global::G.CloudPostgresVectorStore, global::G.CloudQdrantVectorStore, global::G.CloudAzureAISearchVectorStore, global::G.CloudMongoDBAtlasVectorSearch, global::G.CloudMilvusVectorStore, global::G.CloudAstraDBVectorStore, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ExtractModels?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.FileCreateStorageType?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.FileCreateFromUrlStorageType?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, string, global::System.DateTime?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.TextItem, global::G.ListItem>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.MarkdownResultPage, global::G.FailedMarkdownPage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, double?, string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<int>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.MetadataFilter, global::G.MetadataFilters>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ParseRequestConfigurationVersion?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ParseV2ParametersVersion?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.AutoTransformConfig, global::G.AdvancedModeTransformConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.AutoTransformConfig, global::G.AdvancedModeTransformConfig, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::G.CloudS3DataSource, global::G.CloudAzStorageBlobDataSource, global::G.CloudGoogleDriveDataSource, global::G.CloudOneDriveDataSource, global::G.CloudSharepointDataSource, global::G.CloudSlackDataSource, global::G.CloudNotionPageDataSource, global::G.CloudConfluenceDataSource, global::G.CloudJiraDataSource, global::G.CloudJiraDataSourceV2, global::G.CloudBoxDataSource>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.AutoTransformConfig, global::G.AdvancedModeTransformConfig, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.BatchParseJobRecordCreate, global::G.ClassifyJob>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ObjectType?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>, string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.StructuredResultPage, global::G.FailedStructuredPage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?, double?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.RelatedNodeInfo, global::System.Collections.Generic.IList<global::G.RelatedNodeInfo>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public BetaClient Beta => new BetaClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ClassifierClient Classifier => new ClassifierClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataSinksClient DataSinks => new DataSinksClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataSourcesClient DataSources => new DataSourcesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingModelConfigsClient EmbeddingModelConfigs => new EmbeddingModelConfigsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LlamaExtractClient LlamaExtract => new LlamaExtractClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations => new OrganizationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PageFiguresClient PageFigures => new PageFiguresClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PageScreenshotsClient PageScreenshots => new PageScreenshotsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ParsingClient Parsing => new ParsingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelineDataSourcesClient PipelineDataSources => new PipelineDataSourcesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelineFilesClient PipelineFiles => new PipelineFilesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines => new PipelinesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RetrieversClient Retrievers => new RetrieversClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public V2Client V2 => new V2Client(HttpClient, authorizations: Authorizations)
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