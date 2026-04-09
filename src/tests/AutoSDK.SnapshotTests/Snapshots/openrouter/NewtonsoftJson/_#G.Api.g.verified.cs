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
        public const string DefaultBaseUrl = "https://openrouter.ai/api/v1";

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
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings
            {
                Converters =
                {
                    new global::G.JsonConverters.OutputItemReasoningTypeJsonConverter(),

                    new global::G.JsonConverters.OutputItemReasoningTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningTextContentTypeJsonConverter(),

                    new global::G.JsonConverters.ReasoningTextContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningSummaryTextTypeJsonConverter(),

                    new global::G.JsonConverters.ReasoningSummaryTextTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemReasoningStatus0JsonConverter(),

                    new global::G.JsonConverters.OutputItemReasoningStatus0NullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemReasoningStatus1JsonConverter(),

                    new global::G.JsonConverters.OutputItemReasoningStatus1NullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemReasoningStatus2JsonConverter(),

                    new global::G.JsonConverters.OutputItemReasoningStatus2NullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningItemFormatJsonConverter(),

                    new global::G.JsonConverters.ReasoningItemFormatNullableJsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageTypeJsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageTypeNullableJsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageRole0JsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageRole0NullableJsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageRole1JsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageRole1NullableJsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageRole2JsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageRole2NullableJsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageRole3JsonConverter(),

                    new global::G.JsonConverters.EasyInputMessageRole3NullableJsonConverter(),

                    new global::G.JsonConverters.InputTextTypeJsonConverter(),

                    new global::G.JsonConverters.InputTextTypeNullableJsonConverter(),

                    new global::G.JsonConverters.InputImageTypeJsonConverter(),

                    new global::G.JsonConverters.InputImageTypeNullableJsonConverter(),

                    new global::G.JsonConverters.InputImageDetailJsonConverter(),

                    new global::G.JsonConverters.InputImageDetailNullableJsonConverter(),

                    new global::G.JsonConverters.InputFileTypeJsonConverter(),

                    new global::G.JsonConverters.InputFileTypeNullableJsonConverter(),

                    new global::G.JsonConverters.InputAudioTypeJsonConverter(),

                    new global::G.JsonConverters.InputAudioTypeNullableJsonConverter(),

                    new global::G.JsonConverters.InputAudioInputAudioFormatJsonConverter(),

                    new global::G.JsonConverters.InputAudioInputAudioFormatNullableJsonConverter(),

                    new global::G.JsonConverters.InputVideoTypeJsonConverter(),

                    new global::G.JsonConverters.InputVideoTypeNullableJsonConverter(),

                    new global::G.JsonConverters.EasyInputMessagePhase0JsonConverter(),

                    new global::G.JsonConverters.EasyInputMessagePhase0NullableJsonConverter(),

                    new global::G.JsonConverters.EasyInputMessagePhase1JsonConverter(),

                    new global::G.JsonConverters.EasyInputMessagePhase1NullableJsonConverter(),

                    new global::G.JsonConverters.InputMessageItemTypeJsonConverter(),

                    new global::G.JsonConverters.InputMessageItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.InputMessageItemRole0JsonConverter(),

                    new global::G.JsonConverters.InputMessageItemRole0NullableJsonConverter(),

                    new global::G.JsonConverters.InputMessageItemRole1JsonConverter(),

                    new global::G.JsonConverters.InputMessageItemRole1NullableJsonConverter(),

                    new global::G.JsonConverters.InputMessageItemRole2JsonConverter(),

                    new global::G.JsonConverters.InputMessageItemRole2NullableJsonConverter(),

                    new global::G.JsonConverters.FunctionCallItemTypeJsonConverter(),

                    new global::G.JsonConverters.FunctionCallItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ToolCallStatusEnumJsonConverter(),

                    new global::G.JsonConverters.ToolCallStatusEnumNullableJsonConverter(),

                    new global::G.JsonConverters.FunctionCallOutputItemTypeJsonConverter(),

                    new global::G.JsonConverters.FunctionCallOutputItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputMessageRoleJsonConverter(),

                    new global::G.JsonConverters.OutputMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.OutputMessageTypeJsonConverter(),

                    new global::G.JsonConverters.OutputMessageTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputMessageStatus0JsonConverter(),

                    new global::G.JsonConverters.OutputMessageStatus0NullableJsonConverter(),

                    new global::G.JsonConverters.OutputMessageStatus1JsonConverter(),

                    new global::G.JsonConverters.OutputMessageStatus1NullableJsonConverter(),

                    new global::G.JsonConverters.OutputMessageStatus2JsonConverter(),

                    new global::G.JsonConverters.OutputMessageStatus2NullableJsonConverter(),

                    new global::G.JsonConverters.ResponseOutputTextTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseOutputTextTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FileCitationTypeJsonConverter(),

                    new global::G.JsonConverters.FileCitationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.UrlCitationTypeJsonConverter(),

                    new global::G.JsonConverters.UrlCitationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FilePathTypeJsonConverter(),

                    new global::G.JsonConverters.FilePathTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesRefusalContentTypeJsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesRefusalContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputMessagePhase0JsonConverter(),

                    new global::G.JsonConverters.OutputMessagePhase0NullableJsonConverter(),

                    new global::G.JsonConverters.OutputMessagePhase1JsonConverter(),

                    new global::G.JsonConverters.OutputMessagePhase1NullableJsonConverter(),

                    new global::G.JsonConverters.OutputReasoningItemFormatJsonConverter(),

                    new global::G.JsonConverters.OutputReasoningItemFormatNullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemFunctionCallTypeJsonConverter(),

                    new global::G.JsonConverters.OutputItemFunctionCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemFunctionCallStatus0JsonConverter(),

                    new global::G.JsonConverters.OutputItemFunctionCallStatus0NullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemFunctionCallStatus1JsonConverter(),

                    new global::G.JsonConverters.OutputItemFunctionCallStatus1NullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemFunctionCallStatus2JsonConverter(),

                    new global::G.JsonConverters.OutputItemFunctionCallStatus2NullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemWebSearchCallTypeJsonConverter(),

                    new global::G.JsonConverters.OutputItemWebSearchCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemWebSearchCallActionOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.OutputItemWebSearchCallActionOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemWebSearchCallActionOneOf0SourcesItemsTypeJsonConverter(),

                    new global::G.JsonConverters.OutputItemWebSearchCallActionOneOf0SourcesItemsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemWebSearchCallActionOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.OutputItemWebSearchCallActionOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemWebSearchCallActionOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.OutputItemWebSearchCallActionOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchStatusJsonConverter(),

                    new global::G.JsonConverters.WebSearchStatusNullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemFileSearchCallTypeJsonConverter(),

                    new global::G.JsonConverters.OutputItemFileSearchCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputItemImageGenerationCallTypeJsonConverter(),

                    new global::G.JsonConverters.OutputItemImageGenerationCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationStatusJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationStatusNullableJsonConverter(),

                    new global::G.JsonConverters.OutputDatetimeItemTypeJsonConverter(),

                    new global::G.JsonConverters.OutputDatetimeItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OutputDatetimeItemStatusJsonConverter(),

                    new global::G.JsonConverters.OutputDatetimeItemStatusNullableJsonConverter(),

                    new global::G.JsonConverters.OutputServerToolItemStatusJsonConverter(),

                    new global::G.JsonConverters.OutputServerToolItemStatusNullableJsonConverter(),

                    new global::G.JsonConverters.FunctionToolTypeJsonConverter(),

                    new global::G.JsonConverters.FunctionToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PreviewWebSearchServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.PreviewWebSearchServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SearchContextSizeEnumJsonConverter(),

                    new global::G.JsonConverters.SearchContextSizeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.PreviewWebSearchUserLocationTypeJsonConverter(),

                    new global::G.JsonConverters.PreviewWebSearchUserLocationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PreviewWebSearchServerToolEngineJsonConverter(),

                    new global::G.JsonConverters.PreviewWebSearchServerToolEngineNullableJsonConverter(),

                    new global::G.JsonConverters.Preview20250311WebSearchServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.Preview20250311WebSearchServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.Preview20250311WebSearchServerToolEngineJsonConverter(),

                    new global::G.JsonConverters.Preview20250311WebSearchServerToolEngineNullableJsonConverter(),

                    new global::G.JsonConverters.LegacyWebSearchServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.LegacyWebSearchServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchUserLocationTypeJsonConverter(),

                    new global::G.JsonConverters.WebSearchUserLocationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.LegacyWebSearchServerToolEngineJsonConverter(),

                    new global::G.JsonConverters.LegacyWebSearchServerToolEngineNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.WebSearchServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchServerToolEngineJsonConverter(),

                    new global::G.JsonConverters.WebSearchServerToolEngineNullableJsonConverter(),

                    new global::G.JsonConverters.FileSearchServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.FileSearchServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FileSearchServerToolFiltersOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.FileSearchServerToolFiltersOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.CompoundFilterTypeJsonConverter(),

                    new global::G.JsonConverters.CompoundFilterTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FileSearchServerToolRankingOptionsRankerJsonConverter(),

                    new global::G.JsonConverters.FileSearchServerToolRankingOptionsRankerNullableJsonConverter(),

                    new global::G.JsonConverters.ComputerUseServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.ComputerUseServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ComputerUseServerToolEnvironmentJsonConverter(),

                    new global::G.JsonConverters.ComputerUseServerToolEnvironmentNullableJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterServerToolContainerOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterServerToolContainerOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterServerToolContainerOneOf1MemoryLimitJsonConverter(),

                    new global::G.JsonConverters.CodeInterpreterServerToolContainerOneOf1MemoryLimitNullableJsonConverter(),

                    new global::G.JsonConverters.McpServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.McpServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.McpServerToolConnectorIdJsonConverter(),

                    new global::G.JsonConverters.McpServerToolConnectorIdNullableJsonConverter(),

                    new global::G.JsonConverters.McpServerToolRequireApproval1JsonConverter(),

                    new global::G.JsonConverters.McpServerToolRequireApproval1NullableJsonConverter(),

                    new global::G.JsonConverters.McpServerToolRequireApproval2JsonConverter(),

                    new global::G.JsonConverters.McpServerToolRequireApproval2NullableJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolBackgroundJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolBackgroundNullableJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolInputFidelityJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolInputFidelityNullableJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolModelJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolModelNullableJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolModerationJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolModerationNullableJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolOutputFormatJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolOutputFormatNullableJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolQualityJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolQualityNullableJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolSizeJsonConverter(),

                    new global::G.JsonConverters.ImageGenerationServerToolSizeNullableJsonConverter(),

                    new global::G.JsonConverters.CodexLocalShellToolTypeJsonConverter(),

                    new global::G.JsonConverters.CodexLocalShellToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ShellServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.ShellServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ApplyPatchServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.ApplyPatchServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CustomToolTypeJsonConverter(),

                    new global::G.JsonConverters.CustomToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.CustomToolFormatOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.CustomToolFormatOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.CustomToolFormatOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.CustomToolFormatOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.CustomToolFormatOneOf1SyntaxJsonConverter(),

                    new global::G.JsonConverters.CustomToolFormatOneOf1SyntaxNullableJsonConverter(),

                    new global::G.JsonConverters.DatetimeServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.DatetimeServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchServerToolOpenRouterTypeJsonConverter(),

                    new global::G.JsonConverters.WebSearchServerToolOpenRouterTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesToolChoice0JsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesToolChoice0NullableJsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesToolChoice1JsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesToolChoice1NullableJsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesToolChoice2JsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesToolChoice2NullableJsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesToolChoiceOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesToolChoiceOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesToolChoiceOneOf4Type0JsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesToolChoiceOneOf4Type0NullableJsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesToolChoiceOneOf4Type1JsonConverter(),

                    new global::G.JsonConverters.OpenAiResponsesToolChoiceOneOf4Type1NullableJsonConverter(),

                    new global::G.JsonConverters.FormatTextConfigTypeJsonConverter(),

                    new global::G.JsonConverters.FormatTextConfigTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FormatJsonObjectConfigTypeJsonConverter(),

                    new global::G.JsonConverters.FormatJsonObjectConfigTypeNullableJsonConverter(),

                    new global::G.JsonConverters.FormatJsonSchemaConfigTypeJsonConverter(),

                    new global::G.JsonConverters.FormatJsonSchemaConfigTypeNullableJsonConverter(),

                    new global::G.JsonConverters.TextConfigVerbosityJsonConverter(),

                    new global::G.JsonConverters.TextConfigVerbosityNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningEffortEnumJsonConverter(),

                    new global::G.JsonConverters.ReasoningEffortEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningSummaryVerbosityEnumJsonConverter(),

                    new global::G.JsonConverters.ReasoningSummaryVerbosityEnumNullableJsonConverter(),

                    new global::G.JsonConverters.OutputModalityEnumJsonConverter(),

                    new global::G.JsonConverters.OutputModalityEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseIncludesEnumJsonConverter(),

                    new global::G.JsonConverters.ResponseIncludesEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestServiceTierJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestServiceTierNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIResponsesTruncationJsonConverter(),

                    new global::G.JsonConverters.OpenAIResponsesTruncationNullableJsonConverter(),

                    new global::G.JsonConverters.DataCollectionJsonConverter(),

                    new global::G.JsonConverters.DataCollectionNullableJsonConverter(),

                    new global::G.JsonConverters.ProviderNameJsonConverter(),

                    new global::G.JsonConverters.ProviderNameNullableJsonConverter(),

                    new global::G.JsonConverters.QuantizationJsonConverter(),

                    new global::G.JsonConverters.QuantizationNullableJsonConverter(),

                    new global::G.JsonConverters.ProviderSortJsonConverter(),

                    new global::G.JsonConverters.ProviderSortNullableJsonConverter(),

                    new global::G.JsonConverters.ProviderSortConfigByJsonConverter(),

                    new global::G.JsonConverters.ProviderSortConfigByNullableJsonConverter(),

                    new global::G.JsonConverters.ProviderSortConfigPartitionJsonConverter(),

                    new global::G.JsonConverters.ProviderSortConfigPartitionNullableJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf0IdJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf0IdNullableJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf1IdJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf1IdNullableJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf2IdJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf2IdNullableJsonConverter(),

                    new global::G.JsonConverters.WebSearchEngineJsonConverter(),

                    new global::G.JsonConverters.WebSearchEngineNullableJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf3IdJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf3IdNullableJsonConverter(),

                    new global::G.JsonConverters.PdfParserEngine0JsonConverter(),

                    new global::G.JsonConverters.PdfParserEngine0NullableJsonConverter(),

                    new global::G.JsonConverters.PdfParserEngine1JsonConverter(),

                    new global::G.JsonConverters.PdfParserEngine1NullableJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf4IdJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf4IdNullableJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf5IdJsonConverter(),

                    new global::G.JsonConverters.ResponsesRequestPluginsItemsOneOf5IdNullableJsonConverter(),

                    new global::G.JsonConverters.ContextCompressionEngineJsonConverter(),

                    new global::G.JsonConverters.ContextCompressionEngineNullableJsonConverter(),

                    new global::G.JsonConverters.BaseResponsesResultObjectJsonConverter(),

                    new global::G.JsonConverters.BaseResponsesResultObjectNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIResponsesResponseStatusJsonConverter(),

                    new global::G.JsonConverters.OpenAIResponsesResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ResponsesErrorFieldCodeJsonConverter(),

                    new global::G.JsonConverters.ResponsesErrorFieldCodeNullableJsonConverter(),

                    new global::G.JsonConverters.IncompleteDetailsReasonJsonConverter(),

                    new global::G.JsonConverters.IncompleteDetailsReasonNullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role0JsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role0NullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role1JsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role1NullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role2JsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role2NullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role3JsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0Role3NullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0Phase0JsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0Phase0NullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0Phase1JsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf0Phase1NullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role0JsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role0NullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role1JsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role1NullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role2JsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf1Role2NullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.BaseInputsOneOf1ItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.ServiceTierEnumJsonConverter(),

                    new global::G.JsonConverters.ServiceTierEnumNullableJsonConverter(),

                    new global::G.JsonConverters.TruncationEnumJsonConverter(),

                    new global::G.JsonConverters.TruncationEnumNullableJsonConverter(),

                    new global::G.JsonConverters.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodJsonConverter(),

                    new global::G.JsonConverters.AuthKeysPostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodNullableJsonConverter(),

                    new global::G.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodJsonConverter(),

                    new global::G.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaCodeChallengeMethodNullableJsonConverter(),

                    new global::G.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitTypeJsonConverter(),

                    new global::G.JsonConverters.AuthKeysCodePostRequestBodyContentApplicationJsonSchemaUsageLimitTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamRoleJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamRoleNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf4TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CitationsItemsOneOf4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf0CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf1SourceOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf1SourceOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf1SourceOneOf0MediaTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf1SourceOneOf0MediaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf1SourceOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf1SourceOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf1CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf0MediaTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf0MediaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf1MediaTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf1MediaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf4TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf0CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf1SourceOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf1SourceOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf1SourceOneOf0MediaTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf1SourceOneOf0MediaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf1SourceOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf1SourceOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf1CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf1CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf1CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentOneOf1ItemsOneOf1CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf3CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf3CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf3CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf3CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf4TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf0MediaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1SourceOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf1CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItemsOneOf4TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCitationsItemsOneOf4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3ContentItemsCacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf3CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf0MediaTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf0MediaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf1MediaTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf1MediaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf4TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CitationsItemsOneOf4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf0CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf1SourceOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf1SourceOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf1SourceOneOf0MediaTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf1SourceOneOf0MediaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf1SourceOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf1SourceOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf1CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf1CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf1CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf2ContentOneOf1ItemsOneOf1CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4SourceOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf4CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf4CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf5TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf5TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf6TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf6TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7NameJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7NameNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf7CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0ItemsTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf0ItemsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCodeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCodeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf4TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCitationsItemsOneOf4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9ContentItemsCacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf9CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCitationsItemsOneOf4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSystemOneOf1ItemsCacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf0CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf0CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf0CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf0CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf1NameJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf1NameNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf1CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf1CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf1CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf1CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf2NameJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf2NameNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf2CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf2CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf2CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf2CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf3NameJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf3NameNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf3UserLocationTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf3UserLocationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf3CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf3CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf3CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf3CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf4TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf4NameJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf4NameNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf4AllowedCallersItemsJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf4AllowedCallersItemsNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf4UserLocationTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf4UserLocationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf4CacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf4CacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf4CacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolsItemsOneOf4CacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesWebSearchServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesWebSearchServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesWebSearchServerToolParametersEngineJsonConverter(),

                    new global::G.JsonConverters.MessagesWebSearchServerToolParametersEngineNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesWebSearchServerToolParametersSearchContextSizeJsonConverter(),

                    new global::G.JsonConverters.MessagesWebSearchServerToolParametersSearchContextSizeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesWebSearchServerToolParametersUserLocationTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesWebSearchServerToolParametersUserLocationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolChoiceOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolChoiceOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolChoiceOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolChoiceOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolChoiceOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolChoiceOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolChoiceOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestToolChoiceOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestThinkingOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestThinkingOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestThinkingOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestThinkingOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestThinkingOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestThinkingOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestServiceTierJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestServiceTierNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesOutputConfigEffortJsonConverter(),

                    new global::G.JsonConverters.MessagesOutputConfigEffortNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesOutputConfigFormatTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesOutputConfigFormatTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestCacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestCacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestCacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestCacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeastTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0ClearAtLeastTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0KeepTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0KeepTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf0TriggerOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1KeepOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1Keep2JsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf1Keep2NullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TriggerTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestContextManagementEditsItemsOneOf2TriggerTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestPluginsItemsOneOf0IdJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestPluginsItemsOneOf0IdNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestPluginsItemsOneOf1IdJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestPluginsItemsOneOf1IdNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestPluginsItemsOneOf2IdJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestPluginsItemsOneOf2IdNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestPluginsItemsOneOf3IdJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestPluginsItemsOneOf3IdNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestPluginsItemsOneOf4IdJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestPluginsItemsOneOf4IdNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestPluginsItemsOneOf5IdJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestPluginsItemsOneOf5IdNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSpeedJsonConverter(),

                    new global::G.JsonConverters.MessagesRequestSpeedNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultTypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultRoleJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultRoleNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf0CitationsItemsOneOf4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf1CallerOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4CallerOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4NameJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf4NameNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5CallerOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsTypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf0ItemsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCodeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf5ContentOneOf1ErrorCodeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6CallerOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCodeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf0ErrorCodeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaTypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0MediaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaTypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1MediaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSourceOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentTypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf6ContentOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf0ErrorCodeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf0ErrorCodeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsTypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf1ContentItemsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsTypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf8TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf8TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCodeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf0ErrorCodeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsTypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf8ContentOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCodeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf0ErrorCodeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf1FileTypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf1FileTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf2TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf3TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf9ContentOneOf3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCodeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCodeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsTypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf1ToolReferencesItemsTypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf10ContentOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf11TypeJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultContentItemsOneOf11TypeNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultStopReasonJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultStopReasonNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultUsageServiceTierJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultUsageServiceTierNullableJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultUsageSpeedJsonConverter(),

                    new global::G.JsonConverters.BaseMessagesResultUsageSpeedNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesResultUsageSpeedJsonConverter(),

                    new global::G.JsonConverters.MessagesResultUsageSpeedNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesResultProviderJsonConverter(),

                    new global::G.JsonConverters.MessagesResultProviderNullableJsonConverter(),

                    new global::G.JsonConverters.MessagesPostResponsesContentApplicationJsonSchemaTypeJsonConverter(),

                    new global::G.JsonConverters.MessagesPostResponsesContentApplicationJsonSchemaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatRequestPluginsItemsOneOf0IdJsonConverter(),

                    new global::G.JsonConverters.ChatRequestPluginsItemsOneOf0IdNullableJsonConverter(),

                    new global::G.JsonConverters.ChatRequestPluginsItemsOneOf1IdJsonConverter(),

                    new global::G.JsonConverters.ChatRequestPluginsItemsOneOf1IdNullableJsonConverter(),

                    new global::G.JsonConverters.ChatRequestPluginsItemsOneOf2IdJsonConverter(),

                    new global::G.JsonConverters.ChatRequestPluginsItemsOneOf2IdNullableJsonConverter(),

                    new global::G.JsonConverters.ChatRequestPluginsItemsOneOf3IdJsonConverter(),

                    new global::G.JsonConverters.ChatRequestPluginsItemsOneOf3IdNullableJsonConverter(),

                    new global::G.JsonConverters.ChatRequestPluginsItemsOneOf4IdJsonConverter(),

                    new global::G.JsonConverters.ChatRequestPluginsItemsOneOf4IdNullableJsonConverter(),

                    new global::G.JsonConverters.ChatRequestPluginsItemsOneOf5IdJsonConverter(),

                    new global::G.JsonConverters.ChatRequestPluginsItemsOneOf5IdNullableJsonConverter(),

                    new global::G.JsonConverters.ChatSystemMessageRoleJsonConverter(),

                    new global::G.JsonConverters.ChatSystemMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ChatContentTextTypeJsonConverter(),

                    new global::G.JsonConverters.ChatContentTextTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatContentCacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.ChatContentCacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatContentCacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.ChatContentCacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.ChatUserMessageRoleJsonConverter(),

                    new global::G.JsonConverters.ChatUserMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ChatContentImageTypeJsonConverter(),

                    new global::G.JsonConverters.ChatContentImageTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatContentImageImageUrlDetailJsonConverter(),

                    new global::G.JsonConverters.ChatContentImageImageUrlDetailNullableJsonConverter(),

                    new global::G.JsonConverters.ChatContentAudioTypeJsonConverter(),

                    new global::G.JsonConverters.ChatContentAudioTypeNullableJsonConverter(),

                    new global::G.JsonConverters.LegacyChatContentVideoTypeJsonConverter(),

                    new global::G.JsonConverters.LegacyChatContentVideoTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatContentVideoTypeJsonConverter(),

                    new global::G.JsonConverters.ChatContentVideoTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatContentFileTypeJsonConverter(),

                    new global::G.JsonConverters.ChatContentFileTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatDeveloperMessageRoleJsonConverter(),

                    new global::G.JsonConverters.ChatDeveloperMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ChatAssistantMessageRoleJsonConverter(),

                    new global::G.JsonConverters.ChatAssistantMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ChatToolCallTypeJsonConverter(),

                    new global::G.JsonConverters.ChatToolCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningDetailSummaryTypeJsonConverter(),

                    new global::G.JsonConverters.ReasoningDetailSummaryTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningDetailSummaryFormatJsonConverter(),

                    new global::G.JsonConverters.ReasoningDetailSummaryFormatNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningDetailEncryptedTypeJsonConverter(),

                    new global::G.JsonConverters.ReasoningDetailEncryptedTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningDetailEncryptedFormatJsonConverter(),

                    new global::G.JsonConverters.ReasoningDetailEncryptedFormatNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningDetailTextTypeJsonConverter(),

                    new global::G.JsonConverters.ReasoningDetailTextTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ReasoningDetailTextFormatJsonConverter(),

                    new global::G.JsonConverters.ReasoningDetailTextFormatNullableJsonConverter(),

                    new global::G.JsonConverters.ChatToolMessageRoleJsonConverter(),

                    new global::G.JsonConverters.ChatToolMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ChatRequestReasoningEffortJsonConverter(),

                    new global::G.JsonConverters.ChatRequestReasoningEffortNullableJsonConverter(),

                    new global::G.JsonConverters.ChatReasoningSummaryVerbosityEnumJsonConverter(),

                    new global::G.JsonConverters.ChatReasoningSummaryVerbosityEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ChatFormatTextConfigTypeJsonConverter(),

                    new global::G.JsonConverters.ChatFormatTextConfigTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatFormatJsonSchemaConfigTypeJsonConverter(),

                    new global::G.JsonConverters.ChatFormatJsonSchemaConfigTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatFormatGrammarConfigTypeJsonConverter(),

                    new global::G.JsonConverters.ChatFormatGrammarConfigTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatFormatPythonConfigTypeJsonConverter(),

                    new global::G.JsonConverters.ChatFormatPythonConfigTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatToolChoice0JsonConverter(),

                    new global::G.JsonConverters.ChatToolChoice0NullableJsonConverter(),

                    new global::G.JsonConverters.ChatToolChoice1JsonConverter(),

                    new global::G.JsonConverters.ChatToolChoice1NullableJsonConverter(),

                    new global::G.JsonConverters.ChatToolChoice2JsonConverter(),

                    new global::G.JsonConverters.ChatToolChoice2NullableJsonConverter(),

                    new global::G.JsonConverters.ChatNamedToolChoiceTypeJsonConverter(),

                    new global::G.JsonConverters.ChatNamedToolChoiceTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatFunctionToolOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.ChatFunctionToolOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchServerToolTypeJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchServerToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchServerToolParametersEngineJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchServerToolParametersEngineNullableJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchServerToolParametersSearchContextSizeJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchServerToolParametersSearchContextSizeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchServerToolParametersUserLocationTypeJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchServerToolParametersUserLocationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandTypeJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandEngineJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandEngineNullableJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandSearchContextSizeJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandSearchContextSizeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandUserLocationTypeJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandUserLocationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandParametersEngineJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandParametersEngineNullableJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandParametersSearchContextSizeJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandParametersSearchContextSizeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandParametersUserLocationTypeJsonConverter(),

                    new global::G.JsonConverters.ChatWebSearchShorthandParametersUserLocationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatRequestModalitiesItemsJsonConverter(),

                    new global::G.JsonConverters.ChatRequestModalitiesItemsNullableJsonConverter(),

                    new global::G.JsonConverters.ChatRequestCacheControlTypeJsonConverter(),

                    new global::G.JsonConverters.ChatRequestCacheControlTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatRequestCacheControlTtlJsonConverter(),

                    new global::G.JsonConverters.ChatRequestCacheControlTtlNullableJsonConverter(),

                    new global::G.JsonConverters.ChatRequestServiceTierJsonConverter(),

                    new global::G.JsonConverters.ChatRequestServiceTierNullableJsonConverter(),

                    new global::G.JsonConverters.ChatFinishReasonEnumJsonConverter(),

                    new global::G.JsonConverters.ChatFinishReasonEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ChatResultObjectJsonConverter(),

                    new global::G.JsonConverters.ChatResultObjectNullableJsonConverter(),

                    new global::G.JsonConverters.CreateChargeRequestChainIdJsonConverter(),

                    new global::G.JsonConverters.CreateChargeRequestChainIdNullableJsonConverter(),

                    new global::G.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0TypeJsonConverter(),

                    new global::G.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0TypeNullableJsonConverter(),

                    new global::G.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1TypeJsonConverter(),

                    new global::G.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormatJsonConverter(),

                    new global::G.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormatNullableJsonConverter(),

                    new global::G.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaObjectJsonConverter(),

                    new global::G.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaObjectNullableJsonConverter(),

                    new global::G.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObjectJsonConverter(),

                    new global::G.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ModelGroupJsonConverter(),

                    new global::G.JsonConverters.ModelGroupNullableJsonConverter(),

                    new global::G.JsonConverters.ModelArchitectureInstructTypeJsonConverter(),

                    new global::G.JsonConverters.ModelArchitectureInstructTypeNullableJsonConverter(),

                    new global::G.JsonConverters.InputModalityJsonConverter(),

                    new global::G.JsonConverters.InputModalityNullableJsonConverter(),

                    new global::G.JsonConverters.OutputModalityJsonConverter(),

                    new global::G.JsonConverters.OutputModalityNullableJsonConverter(),

                    new global::G.JsonConverters.ParameterJsonConverter(),

                    new global::G.JsonConverters.ParameterNullableJsonConverter(),

                    new global::G.JsonConverters.GenerationGetResponsesContentApplicationJsonSchemaDataApiTypeJsonConverter(),

                    new global::G.JsonConverters.GenerationGetResponsesContentApplicationJsonSchemaDataApiTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItemsProviderNameJsonConverter(),

                    new global::G.JsonConverters.GenerationGetResponsesContentApplicationJsonSchemaDataProviderResponsesItemsProviderNameNullableJsonConverter(),

                    new global::G.JsonConverters.ModelsGetParametersCategoryJsonConverter(),

                    new global::G.JsonConverters.ModelsGetParametersCategoryNullableJsonConverter(),

                    new global::G.JsonConverters.InstructType2JsonConverter(),

                    new global::G.JsonConverters.InstructType2NullableJsonConverter(),

                    new global::G.JsonConverters.EndpointStatusJsonConverter(),

                    new global::G.JsonConverters.EndpointStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquartersJsonConverter(),

                    new global::G.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquartersNullableJsonConverter(),

                    new global::G.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItemsJsonConverter(),

                    new global::G.JsonConverters.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItemsNullableJsonConverter(),

                    new global::G.JsonConverters.KeysPostRequestBodyContentApplicationJsonSchemaLimitResetJsonConverter(),

                    new global::G.JsonConverters.KeysPostRequestBodyContentApplicationJsonSchemaLimitResetNullableJsonConverter(),

                    new global::G.JsonConverters.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitResetJsonConverter(),

                    new global::G.JsonConverters.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitResetNullableJsonConverter(),

                    new global::G.JsonConverters.GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetIntervalJsonConverter(),

                    new global::G.JsonConverters.GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetIntervalNullableJsonConverter(),

                    new global::G.JsonConverters.GuardrailsPostRequestBodyContentApplicationJsonSchemaResetIntervalJsonConverter(),

                    new global::G.JsonConverters.GuardrailsPostRequestBodyContentApplicationJsonSchemaResetIntervalNullableJsonConverter(),

                    new global::G.JsonConverters.GuardrailsPostResponsesContentApplicationJsonSchemaDataResetIntervalJsonConverter(),

                    new global::G.JsonConverters.GuardrailsPostResponsesContentApplicationJsonSchemaDataResetIntervalNullableJsonConverter(),

                    new global::G.JsonConverters.GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetIntervalJsonConverter(),

                    new global::G.JsonConverters.GuardrailsIdGetResponsesContentApplicationJsonSchemaDataResetIntervalNullableJsonConverter(),

                    new global::G.JsonConverters.GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetIntervalJsonConverter(),

                    new global::G.JsonConverters.GuardrailsIdPatchRequestBodyContentApplicationJsonSchemaResetIntervalNullableJsonConverter(),

                    new global::G.JsonConverters.GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetIntervalJsonConverter(),

                    new global::G.JsonConverters.GuardrailsIdPatchResponsesContentApplicationJsonSchemaDataResetIntervalNullableJsonConverter(),

                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public SubpackageAnalyticsClient SubpackageAnalytics => new SubpackageAnalyticsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageAnthropicMessagesClient SubpackageAnthropicMessages => new SubpackageAnthropicMessagesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageApiKeysClient SubpackageApiKeys => new SubpackageApiKeysClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageBetaResponsesClient SubpackageBetaResponses => new SubpackageBetaResponsesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageChatClient SubpackageChat => new SubpackageChatClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageCreditsClient SubpackageCredits => new SubpackageCreditsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageEmbeddingsClient SubpackageEmbeddings => new SubpackageEmbeddingsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageEndpointsClient SubpackageEndpoints => new SubpackageEndpointsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageGenerationsClient SubpackageGenerations => new SubpackageGenerationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageGuardrailsClient SubpackageGuardrails => new SubpackageGuardrailsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageModelsClient SubpackageModels => new SubpackageModelsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageOAuthClient SubpackageOAuth => new SubpackageOAuthClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SubpackageProvidersClient SubpackageProviders => new SubpackageProvidersClient(HttpClient, authorizations: Authorizations, options: Options)
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