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
        /// Letta Cloud
        /// </summary>
        public const string DefaultBaseUrl = "https://app.letta.com/";

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
                    new global::G.JsonConverters.AgentStateToolRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.AgentStateToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AgentStateModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::G.JsonConverters.AgentStateModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AgentStateResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.AgentStateResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AgentTypeJsonConverter(),
                    new global::G.JsonConverters.AgentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AnthropicModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.AnthropicModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AnthropicModelSettingsVerbosity2JsonConverter(),
                    new global::G.JsonConverters.AnthropicModelSettingsVerbosity2NullableJsonConverter(),
                    new global::G.JsonConverters.AnthropicModelSettingsEffort2JsonConverter(),
                    new global::G.JsonConverters.AnthropicModelSettingsEffort2NullableJsonConverter(),
                    new global::G.JsonConverters.AnthropicThinkingTypeJsonConverter(),
                    new global::G.JsonConverters.AnthropicThinkingTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ApprovalCreateApprovalsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ApprovalCreateApprovalsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AzureModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.AzureModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BedrockModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.BedrockModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionServiceTier2JsonConverter(),
                    new global::G.JsonConverters.ChatCompletionServiceTier2NullableJsonConverter(),
                    new global::G.JsonConverters.ChatGPTOAuthReasoningReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.ChatGPTOAuthReasoningReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.ChoiceFinishReasonJsonConverter(),
                    new global::G.JsonConverters.ChoiceFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::G.JsonConverters.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CompactionSettingsInputModeJsonConverter(),
                    new global::G.JsonConverters.CompactionSettingsInputModeNullableJsonConverter(),
                    new global::G.JsonConverters.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::G.JsonConverters.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CompactionSettingsOutputModeJsonConverter(),
                    new global::G.JsonConverters.CompactionSettingsOutputModeNullableJsonConverter(),
                    new global::G.JsonConverters.ComparisonOperatorJsonConverter(),
                    new global::G.JsonConverters.ComparisonOperatorNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::G.JsonConverters.ConversationModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ConversationMessageRequestInputVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ConversationMessageRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAgentRequestToolRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateAgentRequestToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::G.JsonConverters.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAgentRequestResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateAgentRequestResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::G.JsonConverters.CreateConversationModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateMCPServerRequestConfigDiscriminatorMcpServerTypeJsonConverter(),
                    new global::G.JsonConverters.CreateMCPServerRequestConfigDiscriminatorMcpServerTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DeepseekModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.DeepseekModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DuplicateFileHandlingJsonConverter(),
                    new global::G.JsonConverters.DuplicateFileHandlingNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingConfigEmbeddingEndpointTypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingConfigEmbeddingEndpointTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelEmbeddingEndpointTypeJsonConverter(),
                    new global::G.JsonConverters.EmbeddingModelEmbeddingEndpointTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FeedbackTypeJsonConverter(),
                    new global::G.JsonConverters.FeedbackTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FileProcessingStatusJsonConverter(),
                    new global::G.JsonConverters.FileProcessingStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GoogleAIModelSettingsResponseSchemaVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GroqModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.GroqModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GroupCreateManagerConfigDiscriminatorManagerTypeJsonConverter(),
                    new global::G.JsonConverters.GroupCreateManagerConfigDiscriminatorManagerTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GroupSchemaManagerConfigDiscriminatorManagerTypeJsonConverter(),
                    new global::G.JsonConverters.GroupSchemaManagerConfigDiscriminatorManagerTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeJsonConverter(),
                    new global::G.JsonConverters.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeNullableJsonConverter(),
                    new global::G.JsonConverters.HiddenReasoningMessageStateJsonConverter(),
                    new global::G.JsonConverters.HiddenReasoningMessageStateNullableJsonConverter(),
                    new global::G.JsonConverters.IdentityPropertyTypeJsonConverter(),
                    new global::G.JsonConverters.IdentityPropertyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.IdentityTypeJsonConverter(),
                    new global::G.JsonConverters.IdentityTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageContentSourceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ImageContentSourceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageURLDetailJsonConverter(),
                    new global::G.JsonConverters.ImageURLDetailNullableJsonConverter(),
                    new global::G.JsonConverters.InputAudioFormatJsonConverter(),
                    new global::G.JsonConverters.InputAudioFormatNullableJsonConverter(),
                    new global::G.JsonConverters.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.InternalTemplateAgentCreateToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::G.JsonConverters.InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::G.JsonConverters.InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerTypeJsonConverter(),
                    new global::G.JsonConverters.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerTypeNullableJsonConverter(),
                    new global::G.JsonConverters.JobStatusJsonConverter(),
                    new global::G.JsonConverters.JobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.JobTypeJsonConverter(),
                    new global::G.JsonConverters.JobTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LLMConfigModelEndpointTypeJsonConverter(),
                    new global::G.JsonConverters.LLMConfigModelEndpointTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LLMConfigReasoningEffort2JsonConverter(),
                    new global::G.JsonConverters.LLMConfigReasoningEffort2NullableJsonConverter(),
                    new global::G.JsonConverters.LLMConfigEffort2JsonConverter(),
                    new global::G.JsonConverters.LLMConfigEffort2NullableJsonConverter(),
                    new global::G.JsonConverters.LLMConfigCompatibilityType2JsonConverter(),
                    new global::G.JsonConverters.LLMConfigCompatibilityType2NullableJsonConverter(),
                    new global::G.JsonConverters.LLMConfigVerbosity2JsonConverter(),
                    new global::G.JsonConverters.LLMConfigVerbosity2NullableJsonConverter(),
                    new global::G.JsonConverters.LLMConfigResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LLMConfigResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaAsyncRequestInputVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LettaAsyncRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaBatchRequestInputVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LettaBatchRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaRequestInputVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LettaRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaStreamingRequestInputVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LettaStreamingRequestInputVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaStreamingResponseDiscriminatorMessageTypeJsonConverter(),
                    new global::G.JsonConverters.LettaStreamingResponseDiscriminatorMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MCPServerTypeJsonConverter(),
                    new global::G.JsonConverters.MCPServerTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ManagerTypeJsonConverter(),
                    new global::G.JsonConverters.ManagerTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageContentVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.MessageContentVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageCreateRoleJsonConverter(),
                    new global::G.JsonConverters.MessageCreateRoleNullableJsonConverter(),
                    new global::G.JsonConverters.MessageRoleJsonConverter(),
                    new global::G.JsonConverters.MessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.MessageSearchRequestSearchModeJsonConverter(),
                    new global::G.JsonConverters.MessageSearchRequestSearchModeNullableJsonConverter(),
                    new global::G.JsonConverters.MessageTypeJsonConverter(),
                    new global::G.JsonConverters.MessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ModalSandboxConfigLanguageJsonConverter(),
                    new global::G.JsonConverters.ModalSandboxConfigLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.ModelModelEndpointTypeJsonConverter(),
                    new global::G.JsonConverters.ModelModelEndpointTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ModelReasoningEffort2JsonConverter(),
                    new global::G.JsonConverters.ModelReasoningEffort2NullableJsonConverter(),
                    new global::G.JsonConverters.ModelEffort2JsonConverter(),
                    new global::G.JsonConverters.ModelEffort2NullableJsonConverter(),
                    new global::G.JsonConverters.ModelCompatibilityType2JsonConverter(),
                    new global::G.JsonConverters.ModelCompatibilityType2NullableJsonConverter(),
                    new global::G.JsonConverters.ModelVerbosity2JsonConverter(),
                    new global::G.JsonConverters.ModelVerbosity2NullableJsonConverter(),
                    new global::G.JsonConverters.ModelResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ModelResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAIModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.OpenAIModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAIReasoningReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.OpenAIReasoningReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PassageSearchRequestTagMatchModeJsonConverter(),
                    new global::G.JsonConverters.PassageSearchRequestTagMatchModeNullableJsonConverter(),
                    new global::G.JsonConverters.ProviderCategoryJsonConverter(),
                    new global::G.JsonConverters.ProviderCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.ProviderTypeJsonConverter(),
                    new global::G.JsonConverters.ProviderTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ReasoningMessageSourceJsonConverter(),
                    new global::G.JsonConverters.ReasoningMessageSourceNullableJsonConverter(),
                    new global::G.JsonConverters.RunStatusJsonConverter(),
                    new global::G.JsonConverters.RunStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SandboxTypeJsonConverter(),
                    new global::G.JsonConverters.SandboxTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SearchAllMessagesRequestSearchModeJsonConverter(),
                    new global::G.JsonConverters.SearchAllMessagesRequestSearchModeNullableJsonConverter(),
                    new global::G.JsonConverters.StepFeedback2JsonConverter(),
                    new global::G.JsonConverters.StepFeedback2NullableJsonConverter(),
                    new global::G.JsonConverters.StepStatus2JsonConverter(),
                    new global::G.JsonConverters.StepStatus2NullableJsonConverter(),
                    new global::G.JsonConverters.StopReasonTypeJsonConverter(),
                    new global::G.JsonConverters.StopReasonTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TogetherModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.TogetherModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolExecutionResultStatusJsonConverter(),
                    new global::G.JsonConverters.ToolExecutionResultStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ToolReturnMessageStatusJsonConverter(),
                    new global::G.JsonConverters.ToolReturnMessageStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ToolSearchRequestSearchModeJsonConverter(),
                    new global::G.JsonConverters.ToolSearchRequestSearchModeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolTypeJsonConverter(),
                    new global::G.JsonConverters.ToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TurnTokenDataRoleJsonConverter(),
                    new global::G.JsonConverters.TurnTokenDataRoleNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateAgentToolRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.UpdateAgentToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateAgentModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::G.JsonConverters.UpdateAgentModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateAgentResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.UpdateAgentResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateConversationModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::G.JsonConverters.UpdateConversationModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateMCPServerRequestConfigDiscriminatorMcpServerTypeJsonConverter(),
                    new global::G.JsonConverters.UpdateMCPServerRequestConfigDiscriminatorMcpServerTypeNullableJsonConverter(),
                    new global::G.JsonConverters.VectorDBProviderJsonConverter(),
                    new global::G.JsonConverters.VectorDBProviderNullableJsonConverter(),
                    new global::G.JsonConverters.XAIModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.XAIModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ZAIModelSettingsResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ZAIModelSettingsResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ZAIThinkingTypeJsonConverter(),
                    new global::G.JsonConverters.ZAIThinkingTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderTypeJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasAgentFileAgentSchemaResponseFormatVariant1DiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasLettaMessageToolReturnStatusJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasLettaMessageToolReturnStatusNullableJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasMessageToolReturnInputStatusJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasMessageToolReturnInputStatusNullableJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasMessageToolReturnInputFuncResponseVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasMessageToolReturnOutputStatusJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasMessageToolReturnOutputStatusNullableJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LettaSchemasMessageToolReturnOutputFuncResponseVariant2ItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaMessageUnionDiscriminatorMessageTypeJsonConverter(),
                    new global::G.JsonConverters.LettaMessageUnionDiscriminatorMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaMessageContentUnionDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LettaMessageContentUnionDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaAssistantMessageContentUnionDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LettaAssistantMessageContentUnionDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaToolReturnContentUnionDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LettaToolReturnContentUnionDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LettaUserMessageContentUnionDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.LettaUserMessageContentUnionDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant1FieldJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant1FieldNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2FieldJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2FieldNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2OperatorJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2OperatorNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3FieldJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3FieldNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3OperatorJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant3OperatorNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4FieldJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4FieldNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4OperatorJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4OperatorNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant5FieldJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant5FieldNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant5OperatorJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant5OperatorNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6FieldJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6FieldNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6OperatorJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6OperatorNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestCombinatorJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestCombinatorNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSortByJsonConverter(),
                    new global::G.JsonConverters.AgentsSearchDeployedAgentsRequestSortByNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRoleJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRoleNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRoleJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRoleNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateTemplateNoProjectRequestVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategyJsonConverter(),
                    new global::G.JsonConverters.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesSaveTemplateVersionRequestBlockReconciliationStrategyJsonConverter(),
                    new global::G.JsonConverters.TemplatesSaveTemplateVersionRequestBlockReconciliationStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateTemplateRequestVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateTemplateRequestVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateTemplateRequestVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateTemplateRequestVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1AccesJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1AccesNullableJsonConverter(),
                    new global::G.JsonConverters.MetadataSendFeedbackRequestFeatureJsonConverter(),
                    new global::G.JsonConverters.MetadataSendFeedbackRequestFeatureNullableJsonConverter(),
                    new global::G.JsonConverters.MetadataSendTelemetryRequestServiceJsonConverter(),
                    new global::G.JsonConverters.MetadataSendTelemetryRequestServiceNullableJsonConverter(),
                    new global::G.JsonConverters.MetadataSendTelemetryRequestEventVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.MetadataSendTelemetryRequestEventVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.MetadataSendTelemetryRequestEventVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.MetadataSendTelemetryRequestEventVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.MetadataSendTelemetryRequestEventVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.MetadataSendTelemetryRequestEventVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.MetadataSendTelemetryRequestEventVariant4TypeJsonConverter(),
                    new global::G.JsonConverters.MetadataSendTelemetryRequestEventVariant4TypeNullableJsonConverter(),
                    new global::G.JsonConverters.MetadataSendTelemetryRequestEventVariant5TypeJsonConverter(),
                    new global::G.JsonConverters.MetadataSendTelemetryRequestEventVariant5TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceTypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2SourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageTypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageTypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestIncludeReturnMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineRequestIntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineRequestIntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigRequestProducerConfigVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesPreviewPipelineRequestIntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesPreviewPipelineRequestIntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesPreviewPipelineRequestProducerConfigVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1RoleJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1RoleNullableJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemTypeJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2ItemTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2ItemTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1StatusJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1StatusNullableJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendModeChangeRequestModeJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsSendModeChangeRequestModeNullableJsonConverter(),
                    new global::G.JsonConverters.ListArchivesOrderJsonConverter(),
                    new global::G.JsonConverters.ListArchivesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForArchiveOrderJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForArchiveOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForArchiveIncludeItemJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForArchiveIncludeItemNullableJsonConverter(),
                    new global::G.JsonConverters.ListToolsOrderJsonConverter(),
                    new global::G.JsonConverters.ListToolsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListFoldersOrderJsonConverter(),
                    new global::G.JsonConverters.ListFoldersOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForFolderOrderJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForFolderOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListFolderPassagesOrderJsonConverter(),
                    new global::G.JsonConverters.ListFolderPassagesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListFilesForFolderOrderJsonConverter(),
                    new global::G.JsonConverters.ListFilesForFolderOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentsIncludeItemJsonConverter(),
                    new global::G.JsonConverters.ListAgentsIncludeItemNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentsOrderJsonConverter(),
                    new global::G.JsonConverters.ListAgentsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentsOrderByJsonConverter(),
                    new global::G.JsonConverters.ListAgentsOrderByNullableJsonConverter(),
                    new global::G.JsonConverters.RetrieveAgentIncludeItemJsonConverter(),
                    new global::G.JsonConverters.RetrieveAgentIncludeItemNullableJsonConverter(),
                    new global::G.JsonConverters.ListToolsForAgentOrderJsonConverter(),
                    new global::G.JsonConverters.ListToolsForAgentOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentSourcesOrderJsonConverter(),
                    new global::G.JsonConverters.ListAgentSourcesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListFoldersForAgentOrderJsonConverter(),
                    new global::G.JsonConverters.ListFoldersForAgentOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListFilesForAgentOrderJsonConverter(),
                    new global::G.JsonConverters.ListFilesForAgentOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListCoreMemoryBlocksOrderJsonConverter(),
                    new global::G.JsonConverters.ListCoreMemoryBlocksOrderNullableJsonConverter(),
                    new global::G.JsonConverters.SearchArchivalMemoryTagMatchModeJsonConverter(),
                    new global::G.JsonConverters.SearchArchivalMemoryTagMatchModeNullableJsonConverter(),
                    new global::G.JsonConverters.ListMessagesOrderJsonConverter(),
                    new global::G.JsonConverters.ListMessagesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListGroupsForAgentOrderJsonConverter(),
                    new global::G.JsonConverters.ListGroupsForAgentOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListConversationsOrderJsonConverter(),
                    new global::G.JsonConverters.ListConversationsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListConversationsOrderByJsonConverter(),
                    new global::G.JsonConverters.ListConversationsOrderByNullableJsonConverter(),
                    new global::G.JsonConverters.ListConversationMessagesOrderJsonConverter(),
                    new global::G.JsonConverters.ListConversationMessagesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListGroupsOrderJsonConverter(),
                    new global::G.JsonConverters.ListGroupsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListGroupMessagesOrderJsonConverter(),
                    new global::G.JsonConverters.ListGroupMessagesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListIdentitiesOrderJsonConverter(),
                    new global::G.JsonConverters.ListIdentitiesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForIdentityOrderJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForIdentityOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForIdentityIncludeItemJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForIdentityIncludeItemNullableJsonConverter(),
                    new global::G.JsonConverters.ListBlocksForIdentityOrderJsonConverter(),
                    new global::G.JsonConverters.ListBlocksForIdentityOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListInternalBlocksOrderJsonConverter(),
                    new global::G.JsonConverters.ListInternalBlocksOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForInternalBlockOrderJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForInternalBlockOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListInternalRunsOrderJsonConverter(),
                    new global::G.JsonConverters.ListInternalRunsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListInternalRunsOrderByJsonConverter(),
                    new global::G.JsonConverters.ListInternalRunsOrderByNullableJsonConverter(),
                    new global::G.JsonConverters.ListInternalRunsDurationOperator2JsonConverter(),
                    new global::G.JsonConverters.ListInternalRunsDurationOperator2NullableJsonConverter(),
                    new global::G.JsonConverters.ListBlocksOrderJsonConverter(),
                    new global::G.JsonConverters.ListBlocksOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForBlockOrderJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForBlockOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForBlockIncludeItemJsonConverter(),
                    new global::G.JsonConverters.ListAgentsForBlockIncludeItemNullableJsonConverter(),
                    new global::G.JsonConverters.ListJobsOrderJsonConverter(),
                    new global::G.JsonConverters.ListJobsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListProvidersOrderJsonConverter(),
                    new global::G.JsonConverters.ListProvidersOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListRunsOrderJsonConverter(),
                    new global::G.JsonConverters.ListRunsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListMessagesForRunOrderJsonConverter(),
                    new global::G.JsonConverters.ListMessagesForRunOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListStepsForRunOrderJsonConverter(),
                    new global::G.JsonConverters.ListStepsForRunOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListStepsOrderJsonConverter(),
                    new global::G.JsonConverters.ListStepsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListStepsFeedback2JsonConverter(),
                    new global::G.JsonConverters.ListStepsFeedback2NullableJsonConverter(),
                    new global::G.JsonConverters.ListMessagesForStepOrderJsonConverter(),
                    new global::G.JsonConverters.ListMessagesForStepOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListTagsOrderJsonConverter(),
                    new global::G.JsonConverters.ListTagsOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListAllMessagesOrderJsonConverter(),
                    new global::G.JsonConverters.ListAllMessagesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListBatchesOrderJsonConverter(),
                    new global::G.JsonConverters.ListBatchesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ListMessagesForBatchOrderJsonConverter(),
                    new global::G.JsonConverters.ListMessagesForBatchOrderNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant1FieldJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant1FieldNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2FieldJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2FieldNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2OperatorJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant2OperatorNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3FieldJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3FieldNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3OperatorJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant3OperatorNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant4FieldJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant4FieldNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant4OperatorJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant4OperatorNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant5FieldJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant5FieldNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant5OperatorJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant5OperatorNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6FieldJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6FieldNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6OperatorJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsSearchItemVariant6OperatorNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsCombinatorJsonConverter(),
                    new global::G.JsonConverters.AgentsCountDeployedAgentsCombinatorNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesListTemplatesSortByJsonConverter(),
                    new global::G.JsonConverters.TemplatesListTemplatesSortByNullableJsonConverter(),
                    new global::G.JsonConverters.ModifyMessageResponseDiscriminatorMessageTypeJsonConverter(),
                    new global::G.JsonConverters.ModifyMessageResponseDiscriminatorMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ModifyGroupMessageResponseDiscriminatorMessageTypeJsonConverter(),
                    new global::G.JsonConverters.ModifyGroupMessageResponseDiscriminatorMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListMessagesForStepResponseItemDiscriminatorMessageTypeJsonConverter(),
                    new global::G.JsonConverters.ListMessagesForStepResponseItemDiscriminatorMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SearchAllMessagesResponseItemDiscriminatorMessageTypeJsonConverter(),
                    new global::G.JsonConverters.SearchAllMessagesResponseItemDiscriminatorMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsGetAgentVariablesResponseMessageJsonConverter(),
                    new global::G.JsonConverters.AgentsGetAgentVariablesResponseMessageNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9TypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9TypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentAgentTypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentAgentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevelJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevelNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffortJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffortNullableJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseTypeJsonConverter(),
                    new global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersionJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersionNullableJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1AccesJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1AccesNullableJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersionJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersionNullableJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1AccesJsonConverter(),
                    new global::G.JsonConverters.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1AccesNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2SourceTypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2SourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageTypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageTypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageIncludeReturnMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceTypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2SourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageTypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageTypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseMessageIncludeReturnMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.FeedsSubscribeAgentResponseMergeStrategyJsonConverter(),
                    new global::G.JsonConverters.FeedsSubscribeAgentResponseMergeStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.FeedsSubscribeAgentResponseErrorCodeJsonConverter(),
                    new global::G.JsonConverters.FeedsSubscribeAgentResponseErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.FeedsUpdateSubscriptionResponseMergeStrategyJsonConverter(),
                    new global::G.JsonConverters.FeedsUpdateSubscriptionResponseMergeStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.FeedsBackfillSubscriptionResponseErrorCodeJsonConverter(),
                    new global::G.JsonConverters.FeedsBackfillSubscriptionResponseErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.FeedsListSubscriptionHistoryResponseRunTypeJsonConverter(),
                    new global::G.JsonConverters.FeedsListSubscriptionHistoryResponseRunTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FeedsListSubscriptionHistoryResponseRunStatusJsonConverter(),
                    new global::G.JsonConverters.FeedsListSubscriptionHistoryResponseRunStatusNullableJsonConverter(),
                    new global::G.JsonConverters.FeedsListSubscriptionHistoryResponseErrorCodeJsonConverter(),
                    new global::G.JsonConverters.FeedsListSubscriptionHistoryResponseErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.FeedsListSubscriptionsResponseSubscriptionMergeStrategyJsonConverter(),
                    new global::G.JsonConverters.FeedsListSubscriptionsResponseSubscriptionMergeStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.MemoryFilesListDirectoryResponseEntrieTypeJsonConverter(),
                    new global::G.JsonConverters.MemoryFilesListDirectoryResponseEntrieTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineResponsePipelineIntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineResponsePipelineIntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineResponsePipelineConfigVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineResponseErrorCodeJsonConverter(),
                    new global::G.JsonConverters.PipelinesCreatePipelineResponseErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesListPipelinesResponsePipelineIntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesListPipelinesResponsePipelineIntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesListPipelinesResponsePipelineConfigVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesGetPipelineResponsePipelineIntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesGetPipelineResponsePipelineIntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesGetPipelineResponsePipelineConfigVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesGetPipelineResponseErrorCodeJsonConverter(),
                    new global::G.JsonConverters.PipelinesGetPipelineResponseErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineResponsePipelineIntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineResponsePipelineIntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineResponseErrorCodeJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineResponseErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesDeletePipelineResponseErrorCodeJsonConverter(),
                    new global::G.JsonConverters.PipelinesDeletePipelineResponseErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineIntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigResponsePipelineConfigVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCodeJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCode2JsonConverter(),
                    new global::G.JsonConverters.PipelinesUpdatePipelineProducerConfigResponseErrorCode2NullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesPreviewPipelineResponseErrorCodeJsonConverter(),
                    new global::G.JsonConverters.PipelinesPreviewPipelineResponseErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesSyncPipelineResponseErrorCodeJsonConverter(),
                    new global::G.JsonConverters.PipelinesSyncPipelineResponseErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesSyncPipelineResponseErrorCode2JsonConverter(),
                    new global::G.JsonConverters.PipelinesSyncPipelineResponseErrorCode2NullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesListPipelineSyncHistoryResponseRunStatusJsonConverter(),
                    new global::G.JsonConverters.PipelinesListPipelineSyncHistoryResponseRunStatusNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinesListPipelineSyncHistoryResponseErrorCodeJsonConverter(),
                    new global::G.JsonConverters.PipelinesListPipelineSyncHistoryResponseErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsGetConnectionResponseCurrentModeJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsGetConnectionResponseCurrentModeNullableJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsListConnectionsResponseConnectionCurrentModeJsonConverter(),
                    new global::G.JsonConverters.EnvironmentsListConnectionsResponseConnectionCurrentModeNullableJsonConverter(),
                    new global::G.JsonConverters.ToolRulesVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.ModelSettingsVariant1JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant1JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant12JsonConverter(),
                    new global::G.JsonConverters.ApprovalsVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.ApprovalsVariant1Item2JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant13JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant14JsonConverter(),
                    new global::G.JsonConverters.ModelSettingsVariant12JsonConverter(),
                    new global::G.JsonConverters.ModelSettingsVariant13JsonConverter(),
                    new global::G.JsonConverters.ModelSettingsVariant14JsonConverter(),
                    new global::G.JsonConverters.InputVariant2ItemJsonConverter(),
                    new global::G.JsonConverters.ToolRulesVariant1Item2JsonConverter(),
                    new global::G.JsonConverters.ModelSettingsVariant15JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant15JsonConverter(),
                    new global::G.JsonConverters.ModelSettingsVariant16JsonConverter(),
                    new global::G.JsonConverters.ConfigJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant16JsonConverter(),
                    new global::G.JsonConverters.ResponseSchemaVariant1JsonConverter(),
                    new global::G.JsonConverters.ResponseSchemaVariant12JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant17JsonConverter(),
                    new global::G.JsonConverters.ManagerConfigJsonConverter(),
                    new global::G.JsonConverters.ManagerConfig2JsonConverter(),
                    new global::G.JsonConverters.ManagerConfigVariant1JsonConverter(),
                    new global::G.JsonConverters.SourceJsonConverter(),
                    new global::G.JsonConverters.ToolRulesVariant1Item3JsonConverter(),
                    new global::G.JsonConverters.ModelSettingsVariant17JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant18JsonConverter(),
                    new global::G.JsonConverters.ManagerConfig3JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant19JsonConverter(),
                    new global::G.JsonConverters.InputVariant2Item2JsonConverter(),
                    new global::G.JsonConverters.InputVariant2Item3JsonConverter(),
                    new global::G.JsonConverters.InputVariant2Item4JsonConverter(),
                    new global::G.JsonConverters.InputVariant2Item5JsonConverter(),
                    new global::G.JsonConverters.LettaStreamingResponseJsonConverter(),
                    new global::G.JsonConverters.ContentVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant110JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant111JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant112JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant113JsonConverter(),
                    new global::G.JsonConverters.ToolRulesVariant1Item4JsonConverter(),
                    new global::G.JsonConverters.ModelSettingsVariant18JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant114JsonConverter(),
                    new global::G.JsonConverters.ModelSettingsVariant19JsonConverter(),
                    new global::G.JsonConverters.Config4JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant115JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant116JsonConverter(),
                    new global::G.JsonConverters.ToolRulesVariant1Item5JsonConverter(),
                    new global::G.JsonConverters.ModelSettingsVariant110JsonConverter(),
                    new global::G.JsonConverters.ResponseFormatVariant117JsonConverter(),
                    new global::G.JsonConverters.FuncResponseVariant2ItemJsonConverter(),
                    new global::G.JsonConverters.FuncResponseVariant2Item2JsonConverter(),
                    new global::G.JsonConverters.LettaMessageUnionJsonConverter(),
                    new global::G.JsonConverters.LettaMessageContentUnionJsonConverter(),
                    new global::G.JsonConverters.LettaAssistantMessageContentUnionJsonConverter(),
                    new global::G.JsonConverters.LettaToolReturnContentUnionJsonConverter(),
                    new global::G.JsonConverters.LettaUserMessageContentUnionJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateTemplateNoProjectRequestJsonConverter(),
                    new global::G.JsonConverters.TemplatesCreateTemplateRequestJsonConverter(),
                    new global::G.JsonConverters.PolicyItemJsonConverter(),
                    new global::G.JsonConverters.EventsItemJsonConverter(),
                    new global::G.JsonConverters.ProducerConfigJsonConverter(),
                    new global::G.JsonConverters.ProducerConfig2JsonConverter(),
                    new global::G.JsonConverters.ProducerConfig3JsonConverter(),
                    new global::G.JsonConverters.ModifyMessageResponseJsonConverter(),
                    new global::G.JsonConverters.ModifyGroupMessageResponseJsonConverter(),
                    new global::G.JsonConverters.ListMessagesForStepResponseItemJsonConverter(),
                    new global::G.JsonConverters.SearchAllMessagesResponseItemJsonConverter(),
                    new global::G.JsonConverters.DataItemJsonConverter(),
                    new global::G.JsonConverters.DataItem2JsonConverter(),
                    new global::G.JsonConverters.Config5JsonConverter(),
                    new global::G.JsonConverters.Config6JsonConverter(),
                    new global::G.JsonConverters.Config7JsonConverter(),
                    new global::G.JsonConverters.Config8JsonConverter(),
                    new global::G.JsonConverters.Config9JsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ToolCall2, global::G.ToolCallDelta>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.ToolCall2>, global::G.ToolCallDelta, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.LettaAssistantMessageContentUnion>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.LettaAssistantMessageContentUnion>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionContentPartTextParam, global::G.ChatCompletionContentPartRefusalParam>>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ChatCompletionContentPartTextParam, global::G.ChatCompletionContentPartRefusalParam>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ChatCompletionMessageFunctionToolCallParam, global::G.ChatCompletionMessageCustomToolCallParam>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartTextParam>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ChatCompletionMessageFunctionToolCallOutput, global::G.ChatCompletionMessageCustomToolCall>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ChatCompletionDeveloperMessageParam, global::G.ChatCompletionSystemMessageParam, global::G.ChatCompletionUserMessageParam, global::G.ChatCompletionAssistantMessageParam, global::G.ChatCompletionToolMessageParam, global::G.ChatCompletionFunctionMessageParam>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartTextParam>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartTextParam>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionContentPartTextParam, global::G.ChatCompletionContentPartImageParam, global::G.ChatCompletionContentPartInputAudioParam, global::G.File>>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ChatCompletionContentPartTextParam, global::G.ChatCompletionContentPartImageParam, global::G.ChatCompletionContentPartInputAudioParam, global::G.File>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.MessageCreate, global::G.ApprovalCreate, global::G.ToolReturnCreate>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.InputVariant2Item>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.MessageCreate, global::G.ApprovalCreate, global::G.ToolReturnCreate>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.InputVariant2Item2>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.MessageCreate, global::G.ApprovalCreate, global::G.ToolReturnCreate>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.InputVariant2Item3>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.MessageCreate, global::G.ApprovalCreate, global::G.ToolReturnCreate>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.InputVariant2Item4>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.MessageCreate, global::G.ApprovalCreate, global::G.ToolReturnCreate>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.InputVariant2Item5>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.AgentType?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ApprovalReturn, global::G.LettaSchemasMessageToolReturnOutput>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.LettaMessageContentUnion>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.LocalSandboxConfig, global::G.E2BSandboxConfig, global::G.ModalSandboxConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.LocalSandboxConfig, global::G.E2BSandboxConfig, global::G.ModalSandboxConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ToolCall2, global::G.ToolCallDelta>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.ToolCall2>, global::G.ToolCallDelta, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.LettaAssistantMessageContentUnion>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.LettaUserMessageContentUnion>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.LettaUserMessageContentUnion>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.LettaUserMessageContentUnion>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.LettaMessageContentUnion>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ApprovalReturn, global::G.LettaSchemasMessageToolReturnInput>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.LettaToolReturnContentUnion>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.FuncResponseVariant2Item>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.FuncResponseVariant2Item2>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.BaseToolRuleSchema, global::G.ChildToolRuleSchema, global::G.MaxCountPerStepToolRuleSchema, global::G.ConditionalToolRuleSchema>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.LettaSchemasMcpUpdateStdioMCPServer, global::G.LettaSchemasMcpUpdateSSEMCPServer, global::G.LettaSchemasMcpUpdateStreamableHTTPMCPServer>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.UpdateSystemMessage, global::G.UpdateUserMessage, global::G.UpdateReasoningMessage, global::G.UpdateAssistantMessage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.LettaRequest, global::G.LettaStreamingRequest>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.UpdateSystemMessage, global::G.UpdateUserMessage, global::G.UpdateReasoningMessage, global::G.UpdateAssistantMessage>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant1, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant3, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant5, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant6>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::G.OneOf<global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>>, string>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant1, global::G.ScheduledMessagesScheduleAgentMessageRequestMessageContentVariant1ItemVariant2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant1, global::G.ScheduledMessagesScheduleAgentMessageRequestScheduleVariant2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.EnvironmentsSendMessageRequestMessageVariant1, global::G.EnvironmentsSendMessageRequestMessageVariant2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.EnvironmentsSendMessageRequestMessageVariant1ContentVariant2Item>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1, global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.EnvironmentsSendMessageRequestMessageVariant2ApprovalVariant1ToolReturnVariant2Item>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.AgentsCountDeployedAgentsSearchItemVariant1, global::G.AgentsCountDeployedAgentsSearchItemVariant2, global::G.AgentsCountDeployedAgentsSearchItemVariant3, global::G.AgentsCountDeployedAgentsSearchItemVariant4, global::G.AgentsCountDeployedAgentsSearchItemVariant5, global::G.AgentsCountDeployedAgentsSearchItemVariant6>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.SSEServerConfig, global::G.StdioServerConfig, global::G.StreamableHTTPServerConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.StdioMCPServer, global::G.SSEMCPServer, global::G.StreamableHTTPMCPServer>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.StdioMCPServer, global::G.SSEMCPServer, global::G.StreamableHTTPMCPServer>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.StdioMCPServer, global::G.SSEMCPServer, global::G.StreamableHTTPMCPServer>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.StdioMCPServer, global::G.SSEMCPServer, global::G.StreamableHTTPMCPServer>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant1, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant2, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant3, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant5, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant6, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant7, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant8, global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant9>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::G.OneOf<global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>>, string>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant1, global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageContentVariant1ItemVariant2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant1, global::G.ScheduledMessagesListScheduledMessagesResponseScheduledMessageScheduleVariant2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::G.OneOf<global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>>, string>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant1, global::G.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageContentVariant1ItemVariant2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant1, global::G.ScheduledMessagesRetrieveScheduledMessageResponseScheduleVariant2>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AgentsClient Agents => new AgentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ArchivesClient Archives => new ArchivesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BlocksClient Blocks => new BlocksClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatClient Chat => new ChatClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ClientSideAccessTokensClient ClientSideAccessTokens => new ClientSideAccessTokensClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ConversationsClient Conversations => new ConversationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentsClient Environments => new EnvironmentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeedsClient Feeds => new FeedsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FoldersClient Folders => new FoldersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public GroupsClient Groups => new GroupsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public HealthClient Health => new HealthClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public IdentitiesClient Identities => new IdentitiesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InternalAgentsClient InternalAgents => new InternalAgentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InternalBlocksClient InternalBlocks => new InternalBlocksClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InternalRunsClient InternalRuns => new InternalRunsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InternalTemplatesClient InternalTemplates => new InternalTemplatesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public JobsClient Jobs => new JobsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public McpServersClient McpServers => new McpServersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MemoryFilesClient MemoryFiles => new MemoryFilesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MessagesClient Messages => new MessagesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetadataClient Metadata => new MetadataClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PassagesClient Passages => new PassagesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PipelinesClient Pipelines => new PipelinesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProvidersClient Providers => new ProvidersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RunsClient Runs => new RunsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScheduledMessagesClient ScheduledMessages => new ScheduledMessagesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SourcesClient Sources => new SourcesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StepsClient Steps => new StepsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TagClient Tag => new TagClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TelemetryClient Telemetry => new TelemetryClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TemplatesClient Templates => new TemplatesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VoiceClient Voice => new VoiceClient(HttpClient, authorizations: Authorizations, options: Options)
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