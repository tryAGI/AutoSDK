//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API specification for the backend data server. The API is hosted globally at<br/>
    /// https://api.braintrust.dev or in your own environment.<br/>
    /// You can access the OpenAPI spec for this API at https://github.com/braintrustdata/braintrust-openapi.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.braintrust.dev/";

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
                    new global::G.JsonConverters.ViewTypeJsonConverter(),
                    new global::G.JsonConverters.ViewTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AclObjectTypeJsonConverter(),
                    new global::G.JsonConverters.AclObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AclListOrgObjectTypeJsonConverter(),
                    new global::G.JsonConverters.AclListOrgObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AclListPermissionJsonConverter(),
                    new global::G.JsonConverters.AclListPermissionNullableJsonConverter(),
                    new global::G.JsonConverters.AclListRestrictObjectTypeJsonConverter(),
                    new global::G.JsonConverters.AclListRestrictObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectScoreTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectScoreTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EnvVarObjectTypeJsonConverter(),
                    new global::G.JsonConverters.EnvVarObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionTypeEnumJsonConverter(),
                    new global::G.JsonConverters.FunctionTypeEnumNullableJsonConverter(),
                    new global::G.JsonConverters.NullableSavedFunctionIdFunctionTypeJsonConverter(),
                    new global::G.JsonConverters.NullableSavedFunctionIdFunctionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.NullableSavedFunctionIdGlobalTypeJsonConverter(),
                    new global::G.JsonConverters.NullableSavedFunctionIdGlobalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant1JsonConverter(),
                    new global::G.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant1NullableJsonConverter(),
                    new global::G.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant2JsonConverter(),
                    new global::G.JsonConverters.ProjectSettingsSpanFieldOrderItemLayoutVariant2NullableJsonConverter(),
                    new global::G.JsonConverters.SpanTypeJsonConverter(),
                    new global::G.JsonConverters.SpanTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ObjectReferenceNullishObjectTypeJsonConverter(),
                    new global::G.JsonConverters.ObjectReferenceNullishObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SavedFunctionIdFunctionTypeJsonConverter(),
                    new global::G.JsonConverters.SavedFunctionIdFunctionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SavedFunctionIdGlobalTypeJsonConverter(),
                    new global::G.JsonConverters.SavedFunctionIdGlobalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectLogsEventLogIdJsonConverter(),
                    new global::G.JsonConverters.ProjectLogsEventLogIdNullableJsonConverter(),
                    new global::G.JsonConverters.FeedbackResponseSchemaStatusJsonConverter(),
                    new global::G.JsonConverters.FeedbackResponseSchemaStatusNullableJsonConverter(),
                    new global::G.JsonConverters.FeedbackProjectLogsItemSourceJsonConverter(),
                    new global::G.JsonConverters.FeedbackProjectLogsItemSourceNullableJsonConverter(),
                    new global::G.JsonConverters.FeedbackExperimentItemSourceJsonConverter(),
                    new global::G.JsonConverters.FeedbackExperimentItemSourceNullableJsonConverter(),
                    new global::G.JsonConverters.FeedbackDatasetItemSourceJsonConverter(),
                    new global::G.JsonConverters.FeedbackDatasetItemSourceNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartTextTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartTextTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartTextCacheControlTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartTextCacheControlTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartTextWithTitleTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartTextWithTitleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartTextWithTitleCacheControlTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartTextWithTitleCacheControlTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailAutoJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailAutoNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailLowJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailLowNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailHighJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartImageWithTitleImageUrlDetailHighNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartImageWithTitleTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartImageWithTitleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartFileWithTitleTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartFileWithTitleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageToolCallTypeJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageToolCallTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamSystemRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamSystemRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamUserRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamUserRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamAssistantRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamAssistantRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamToolRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamToolRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamFunctionRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamFunctionRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamDeveloperRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamDeveloperRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamFallbackRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamFallbackRoleNullableJsonConverter(),
                    new global::G.JsonConverters.PromptBlockDataNullishChatTypeJsonConverter(),
                    new global::G.JsonConverters.PromptBlockDataNullishChatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptBlockDataNullishCompletionTypeJsonConverter(),
                    new global::G.JsonConverters.PromptBlockDataNullishCompletionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatNullishJsonObjectTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatNullishJsonObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatNullishJsonSchemaTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatNullishJsonSchemaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatNullishTextTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatNullishTextTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceAutoJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceAutoNullableJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceNoneJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceNoneNullableJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceRequiredJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceRequiredNullableJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceFunctionTypeJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsToolChoiceFunctionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallAutoJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallAutoNullableJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallNoneJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsFunctionCallNoneNullableJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsVerbosityJsonConverter(),
                    new global::G.JsonConverters.ModelParamsOpenAIModelParamsVerbosityNullableJsonConverter(),
                    new global::G.JsonConverters.PromptParserNullishTypeJsonConverter(),
                    new global::G.JsonConverters.PromptParserNullishTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptDataNullishToolFunctionVariant2FunctionTypeJsonConverter(),
                    new global::G.JsonConverters.PromptDataNullishToolFunctionVariant2FunctionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptDataNullishToolFunctionVariant2GlobalTypeJsonConverter(),
                    new global::G.JsonConverters.PromptDataNullishToolFunctionVariant2GlobalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptDataNullishTemplateFormatJsonConverter(),
                    new global::G.JsonConverters.PromptDataNullishTemplateFormatNullableJsonConverter(),
                    new global::G.JsonConverters.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeJsonConverter(),
                    new global::G.JsonConverters.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeJsonConverter(),
                    new global::G.JsonConverters.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionTypeEnumNullishJsonConverter(),
                    new global::G.JsonConverters.FunctionTypeEnumNullishNullableJsonConverter(),
                    new global::G.JsonConverters.PromptLogIdJsonConverter(),
                    new global::G.JsonConverters.PromptLogIdNullableJsonConverter(),
                    new global::G.JsonConverters.PermissionJsonConverter(),
                    new global::G.JsonConverters.PermissionNullableJsonConverter(),
                    new global::G.JsonConverters.RetentionObjectTypeJsonConverter(),
                    new global::G.JsonConverters.RetentionObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeJsonConverter(),
                    new global::G.JsonConverters.TopicMapFunctionAutomationFunctionVariant2FunctionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeJsonConverter(),
                    new global::G.JsonConverters.TopicMapFunctionAutomationFunctionVariant2GlobalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SpanScopeTypeJsonConverter(),
                    new global::G.JsonConverters.SpanScopeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TraceScopeTypeJsonConverter(),
                    new global::G.JsonConverters.TraceScopeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GroupScopeTypeJsonConverter(),
                    new global::G.JsonConverters.GroupScopeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationDataScopeVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationDataScopeVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationDataScopeVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationDataScopeVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationDataScopeVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationDataScopeVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationConfigEventTypeJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationConfigEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationConfigFacetFunctionVariant2FunctionTypeJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationConfigFacetFunctionVariant2FunctionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationConfigFacetFunctionVariant2GlobalTypeJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationConfigFacetFunctionVariant2GlobalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant1EventTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant1EventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant2EventTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant2EventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant2FormatJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant2FormatNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant2CredentialsTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant2CredentialsTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant3EventTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant3EventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant4EventTypeJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant4EventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant4ActionVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant4ActionVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.ProjectAutomationConfigVariant4ActionVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant1EventTypeJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant1EventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant2EventTypeJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant2EventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant2FormatJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant2FormatNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsTypeJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant3EventTypeJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant3EventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant4EventTypeJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant4EventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant1EventTypeJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant1EventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant1ActionVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant2EventTypeJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant2EventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant2FormatJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant2FormatNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsTypeJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant3EventTypeJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant3EventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant4EventTypeJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant4EventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.OnlineScoreConfigScorerVariant2FunctionTypeJsonConverter(),
                    new global::G.JsonConverters.OnlineScoreConfigScorerVariant2FunctionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeJsonConverter(),
                    new global::G.JsonConverters.OnlineScoreConfigScorerVariant2GlobalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EvalStatusPageThemeJsonConverter(),
                    new global::G.JsonConverters.EvalStatusPageThemeNullableJsonConverter(),
                    new global::G.JsonConverters.EvalStatusPageConfigSortOrderJsonConverter(),
                    new global::G.JsonConverters.EvalStatusPageConfigSortOrderNullableJsonConverter(),
                    new global::G.JsonConverters.CodeBundleRuntimeContextRuntimeJsonConverter(),
                    new global::G.JsonConverters.CodeBundleRuntimeContextRuntimeNullableJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationExperimentTypeJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationExperimentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationExperimentPositionVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationExperimentPositionScorerTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationFunctionTypeJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationFunctionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant1ProviderJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant1ProviderNullableJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant2ProviderJsonConverter(),
                    new global::G.JsonConverters.CodeBundleLocationVariant3SandboxSpecVariant2ProviderNullableJsonConverter(),
                    new global::G.JsonConverters.PromptBlockDataChatTypeJsonConverter(),
                    new global::G.JsonConverters.PromptBlockDataChatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptBlockDataCompletionTypeJsonConverter(),
                    new global::G.JsonConverters.PromptBlockDataCompletionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant4TypeJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant4TypeNullableJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant5TypeJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant5TypeNullableJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant6TypeJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant6TypeNullableJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant7TypeJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant7TypeNullableJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant8TypeJsonConverter(),
                    new global::G.JsonConverters.GraphNodeVariant8TypeNullableJsonConverter(),
                    new global::G.JsonConverters.GraphEdgePurposeJsonConverter(),
                    new global::G.JsonConverters.GraphEdgePurposeNullableJsonConverter(),
                    new global::G.JsonConverters.GraphDataTypeJsonConverter(),
                    new global::G.JsonConverters.GraphDataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FacetDataTypeJsonConverter(),
                    new global::G.JsonConverters.FacetDataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TopicMapDataTypeJsonConverter(),
                    new global::G.JsonConverters.TopicMapDataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BatchedFacetDataTypeJsonConverter(),
                    new global::G.JsonConverters.BatchedFacetDataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataPromptTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataPromptTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataCodeTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataCodeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataCodeDataTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataCodeDataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataCodeDataType2JsonConverter(),
                    new global::G.JsonConverters.FunctionDataCodeDataType2NullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataCodeDataRuntimeContextRuntimeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataCodeDataRuntimeContextRuntimeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataRemoteEvalTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataRemoteEvalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataGlobalTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataGlobalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataParametersTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataParametersTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataParametersSchemaTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataParametersSchemaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionLogIdJsonConverter(),
                    new global::G.JsonConverters.FunctionLogIdNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishPromptTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishPromptTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishCodeTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishCodeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishCodeDataTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishCodeDataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishCodeDataType2JsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishCodeDataType2NullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishCodeDataRuntimeContextRuntimeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishCodeDataRuntimeContextRuntimeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishRemoteEvalTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishRemoteEvalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishGlobalTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishGlobalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishParametersTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishParametersTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishParametersSchemaTypeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishParametersSchemaTypeNullableJsonConverter(),
                    new global::G.JsonConverters.InvokeParentSpanParentStructObjectTypeJsonConverter(),
                    new global::G.JsonConverters.InvokeParentSpanParentStructObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingModeJsonConverter(),
                    new global::G.JsonConverters.StreamingModeNullableJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsMonitorViewOptionsOptionsSpanTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsMonitorViewOptionsOptionsTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsTableViewOptionsExcludedMeasureTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsTableViewOptionsYMetricTypeJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsTableViewOptionsYMetricTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsTableViewOptionsXAxisTypeJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsTableViewOptionsXAxisTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsTableViewOptionsSymbolGroupingTypeJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsTableViewOptionsSymbolGroupingTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsTableViewOptionsQueryShapeJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsTableViewOptionsQueryShapeNullableJsonConverter(),
                    new global::G.JsonConverters.ViewViewTypeJsonConverter(),
                    new global::G.JsonConverters.ViewViewTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateViewViewTypeJsonConverter(),
                    new global::G.JsonConverters.CreateViewViewTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchViewViewTypeJsonConverter(),
                    new global::G.JsonConverters.PatchViewViewTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageRenderingModeJsonConverter(),
                    new global::G.JsonConverters.ImageRenderingModeNullableJsonConverter(),
                    new global::G.JsonConverters.PatchOrganizationMembersOutputStatusJsonConverter(),
                    new global::G.JsonConverters.PatchOrganizationMembersOutputStatusNullableJsonConverter(),
                    new global::G.JsonConverters.EnvVarObjectType2JsonConverter(),
                    new global::G.JsonConverters.EnvVarObjectType2NullableJsonConverter(),
                    new global::G.JsonConverters.EnvVarSecretCategoryJsonConverter(),
                    new global::G.JsonConverters.EnvVarSecretCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.PromptDataToolFunctionVariant2FunctionTypeJsonConverter(),
                    new global::G.JsonConverters.PromptDataToolFunctionVariant2FunctionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptDataToolFunctionVariant2GlobalTypeJsonConverter(),
                    new global::G.JsonConverters.PromptDataToolFunctionVariant2GlobalTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptDataTemplateFormatJsonConverter(),
                    new global::G.JsonConverters.PromptDataTemplateFormatNullableJsonConverter(),
                    new global::G.JsonConverters.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeJsonConverter(),
                    new global::G.JsonConverters.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeJsonConverter(),
                    new global::G.JsonConverters.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServersTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FunctionIdInlineCodeInlineContextRuntimeJsonConverter(),
                    new global::G.JsonConverters.FunctionIdInlineCodeInlineContextRuntimeNullableJsonConverter(),
                    new global::G.JsonConverters.GitMetadataSettingsCollectJsonConverter(),
                    new global::G.JsonConverters.GitMetadataSettingsCollectNullableJsonConverter(),
                    new global::G.JsonConverters.GitMetadataSettingsFieldJsonConverter(),
                    new global::G.JsonConverters.GitMetadataSettingsFieldNullableJsonConverter(),
                    new global::G.JsonConverters.PostEnvVarRequestObjectTypeJsonConverter(),
                    new global::G.JsonConverters.PostEnvVarRequestObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PutEnvVarRequestObjectTypeJsonConverter(),
                    new global::G.JsonConverters.PutEnvVarRequestObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.IdsJsonConverter(),
                    new global::G.JsonConverters.UserGivenNameJsonConverter(),
                    new global::G.JsonConverters.UserFamilyNameJsonConverter(),
                    new global::G.JsonConverters.UserEmailJsonConverter(),
                    new global::G.JsonConverters.AISecretTypeJsonConverter(),
                    new global::G.JsonConverters.NullableSavedFunctionIdJsonConverter(),
                    new global::G.JsonConverters.SavedFunctionIdJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionContentPartJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionMessageParamJsonConverter(),
                    new global::G.JsonConverters.PromptBlockDataNullishJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatNullishJsonConverter(),
                    new global::G.JsonConverters.ModelParamsJsonConverter(),
                    new global::G.JsonConverters.TopicAutomationDataScopeJsonConverter(),
                    new global::G.JsonConverters.ProjectScoreCategoriesJsonConverter(),
                    new global::G.JsonConverters.PromptBlockDataJsonConverter(),
                    new global::G.JsonConverters.GraphNodeJsonConverter(),
                    new global::G.JsonConverters.FunctionDataJsonConverter(),
                    new global::G.JsonConverters.FunctionDataNullishJsonConverter(),
                    new global::G.JsonConverters.InvokeParentJsonConverter(),
                    new global::G.JsonConverters.ViewOptionsJsonConverter(),
                    new global::G.JsonConverters.FunctionIdJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ProjectSettingsSpanFieldOrderItemLayoutVariant1?, global::G.ProjectSettingsSpanFieldOrderItemLayoutVariant2?, object>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.ProjectSettings, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailAuto?, global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailLow?, global::G.ChatCompletionContentPartImageWithTitleImageUrlDetailHigh?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartText>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPart>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartText>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartText>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartText>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, object?>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ModelParamsOpenAIModelParamsToolChoiceAuto?, global::G.ModelParamsOpenAIModelParamsToolChoiceNone?, global::G.ModelParamsOpenAIModelParamsToolChoiceRequired?, global::G.ModelParamsOpenAIModelParamsToolChoiceFunction>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ModelParamsOpenAIModelParamsFunctionCallAuto?, global::G.ModelParamsOpenAIModelParamsFunctionCallNone?, global::G.ModelParamsOpenAIModelParamsFunctionCallFunction>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.SavedFunctionId?, global::G.AnyOf<global::G.PromptDataNullishToolFunctionVariant2Function, global::G.PromptDataNullishToolFunctionVariant2Global>?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PromptDataNullishToolFunctionVariant2Function, global::G.PromptDataNullishToolFunctionVariant2Global>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.PromptDataNullishMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::G.PromptDataNullishMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.SavedFunctionId?, global::G.AnyOf<global::G.TopicMapFunctionAutomationFunctionVariant2Function, global::G.TopicMapFunctionAutomationFunctionVariant2Global>?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.TopicMapFunctionAutomationFunctionVariant2Function, global::G.TopicMapFunctionAutomationFunctionVariant2Global>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.SavedFunctionId?, global::G.AnyOf<global::G.TopicAutomationConfigFacetFunctionVariant2Function, global::G.TopicAutomationConfigFacetFunctionVariant2Global>?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.TopicAutomationConfigFacetFunctionVariant2Function, global::G.TopicAutomationConfigFacetFunctionVariant2Global>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SpanScope, global::G.TraceScope, global::G.GroupScope, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.TopicAutomationConfigBackfillTimeRange, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ProjectAutomationConfigVariant1, global::G.ProjectAutomationConfigVariant2, global::G.ProjectAutomationConfigVariant3, global::G.ProjectAutomationConfigVariant4, global::G.TopicAutomationConfig>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ProjectAutomationConfigVariant1ActionVariant1, global::G.ProjectAutomationConfigVariant1ActionVariant2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ProjectAutomationConfigVariant2ExportDefinitionVariant1, global::G.ProjectAutomationConfigVariant2ExportDefinitionVariant2, global::G.ProjectAutomationConfigVariant2ExportDefinitionVariant3>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ProjectAutomationConfigVariant4ActionVariant1, global::G.ProjectAutomationConfigVariant4ActionVariant2>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateProjectAutomationConfigVariant1, global::G.CreateProjectAutomationConfigVariant2, global::G.CreateProjectAutomationConfigVariant3, global::G.CreateProjectAutomationConfigVariant4, global::G.TopicAutomationConfig>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.CreateProjectAutomationConfigVariant1ActionVariant1, global::G.CreateProjectAutomationConfigVariant1ActionVariant2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant1, global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2, global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.CreateProjectAutomationConfigVariant4ActionVariant1, global::G.CreateProjectAutomationConfigVariant4ActionVariant2>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PatchProjectAutomationConfigVariant1, global::G.PatchProjectAutomationConfigVariant2, global::G.PatchProjectAutomationConfigVariant3, global::G.PatchProjectAutomationConfigVariant4, global::G.TopicAutomationConfig, object>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.PatchProjectAutomationConfigVariant1ActionVariant1, global::G.PatchProjectAutomationConfigVariant1ActionVariant2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.PatchProjectAutomationConfigVariant2ExportDefinitionVariant1, global::G.PatchProjectAutomationConfigVariant2ExportDefinitionVariant2, global::G.PatchProjectAutomationConfigVariant2ExportDefinitionVariant3>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.PatchProjectAutomationConfigVariant4ActionVariant1, global::G.PatchProjectAutomationConfigVariant4ActionVariant2>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.SavedFunctionId?, global::G.AnyOf<global::G.OnlineScoreConfigScorerVariant2Function, global::G.OnlineScoreConfigScorerVariant2Global>?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.OnlineScoreConfigScorerVariant2Function, global::G.OnlineScoreConfigScorerVariant2Global>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SpanScope, global::G.TraceScope, global::G.GroupScope, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.CodeBundleLocationExperiment, global::G.CodeBundleLocationFunction, global::G.CodeBundleLocationVariant3>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.CodeBundleLocationExperimentPositionVariant1, global::G.CodeBundleLocationExperimentPositionScorer>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.CodeBundleLocationVariant3SandboxSpecVariant1, global::G.CodeBundleLocationVariant3SandboxSpecVariant2>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.NullableSavedFunctionId?, object>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.NullableSavedFunctionId?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.AllOf<global::G.FunctionDataCodeData, global::G.CodeBundle>?, global::G.FunctionDataCodeData2>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.FunctionDataCodeData, global::G.CodeBundle>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.TopicMapData, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.AllOf<global::G.FunctionDataNullishCodeData, global::G.CodeBundle>?, global::G.FunctionDataNullishCodeData2>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.FunctionDataNullishCodeData, global::G.CodeBundle>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.TopicMapData, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.ViewOptionsTableViewOptionsTimeRangeFilter, object>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.SavedFunctionId?, global::G.AnyOf<global::G.PromptDataToolFunctionVariant2Function, global::G.PromptDataToolFunctionVariant2Global>?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.PromptDataToolFunctionVariant2Function, global::G.PromptDataToolFunctionVariant2Global>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitions, global::G.PromptDataMcpMcpServerUrlThisIsUsedForInlineDefinitionsOfMcpServers>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.RunEvalDataDatasetId, global::G.RunEvalDataProjectDatasetName, global::G.RunEvalDataDatasetRows>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.FunctionId?, object>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.InvokeParent?, object>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.RepoInfo, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ProjectScoreType?, global::System.Collections.Generic.IList<global::G.AllOf<global::G.ProjectScoreType?, object>>>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.ProjectScoreType?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AclsClient Acls => new AclsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AiSecretsClient AiSecrets => new AiSecretsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys => new ApiKeysClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CorsClient Cors => new CorsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CrossObjectClient CrossObject => new CrossObjectClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EnvVarsClient EnvVars => new EnvVarsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentsClient Environments => new EnvironmentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvalStatusPagesClient EvalStatusPages => new EvalStatusPagesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvalsClient Evals => new EvalsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExperimentsClient Experiments => new ExperimentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FunctionsClient Functions => new FunctionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GroupsClient Groups => new GroupsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LogsClient Logs => new LogsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public McpServersClient McpServers => new McpServersClient(HttpClient, authorizations: Authorizations)
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
        public OtherClient Other => new OtherClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectAutomationsClient ProjectAutomations => new ProjectAutomationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectScoresClient ProjectScores => new ProjectScoresClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectTagsClient ProjectTags => new ProjectTagsClient(HttpClient, authorizations: Authorizations)
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
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProxyClient Proxy => new ProxyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RolesClient Roles => new RolesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ServiceTokensClient ServiceTokens => new ServiceTokensClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SpanIframesClient SpanIframes => new SpanIframesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ViewsClient Views => new ViewsClient(HttpClient, authorizations: Authorizations)
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