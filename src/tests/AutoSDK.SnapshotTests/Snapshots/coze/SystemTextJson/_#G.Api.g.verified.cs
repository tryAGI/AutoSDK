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
        /// International
        /// </summary>
        public const string DefaultBaseUrl = "https://api.coze.com";

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
                    new global::G.JsonConverters.EmotionJsonConverter(),
                    new global::G.JsonConverters.EmotionNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAPIVoiceStateJsonConverter(),
                    new global::G.JsonConverters.OpenAPIVoiceStateNullableJsonConverter(),
                    new global::G.JsonConverters.PublishStatusJsonConverter(),
                    new global::G.JsonConverters.PublishStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageContentExpandTypeJsonConverter(),
                    new global::G.JsonConverters.ChatMessageContentExpandTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageExpandTypeJsonConverter(),
                    new global::G.JsonConverters.ChatMessageExpandTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EnterMessage1ContentTypeJsonConverter(),
                    new global::G.JsonConverters.EnterMessage1ContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EnterMessage1RoleJsonConverter(),
                    new global::G.JsonConverters.EnterMessage1RoleNullableJsonConverter(),
                    new global::G.JsonConverters.EnterMessage1TypeJsonConverter(),
                    new global::G.JsonConverters.EnterMessage1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.FeedbackTypeJsonConverter(),
                    new global::G.JsonConverters.FeedbackTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OpenMessageApiContentTypeJsonConverter(),
                    new global::G.JsonConverters.OpenMessageApiContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OpenMessageApiRoleJsonConverter(),
                    new global::G.JsonConverters.OpenMessageApiRoleNullableJsonConverter(),
                    new global::G.JsonConverters.OpenMessageApiTypeJsonConverter(),
                    new global::G.JsonConverters.OpenMessageApiTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CacheTypeJsonConverter(),
                    new global::G.JsonConverters.CacheTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EnterMessage2ContentTypeJsonConverter(),
                    new global::G.JsonConverters.EnterMessage2ContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.EnterMessage2RoleJsonConverter(),
                    new global::G.JsonConverters.EnterMessage2RoleNullableJsonConverter(),
                    new global::G.JsonConverters.EnterMessage2TypeJsonConverter(),
                    new global::G.JsonConverters.EnterMessage2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptModeJsonConverter(),
                    new global::G.JsonConverters.PromptModeNullableJsonConverter(),
                    new global::G.JsonConverters.PublishStatus1JsonConverter(),
                    new global::G.JsonConverters.PublishStatus1NullableJsonConverter(),
                    new global::G.JsonConverters.ShortcutSendTypeJsonConverter(),
                    new global::G.JsonConverters.ShortcutSendTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StreamModeJsonConverter(),
                    new global::G.JsonConverters.StreamModeNullableJsonConverter(),
                    new global::G.JsonConverters.SuggestReplyModeJsonConverter(),
                    new global::G.JsonConverters.SuggestReplyModeNullableJsonConverter(),
                    new global::G.JsonConverters.VariableChannelJsonConverter(),
                    new global::G.JsonConverters.VariableChannelNullableJsonConverter(),
                    new global::G.JsonConverters.VariableTypeJsonConverter(),
                    new global::G.JsonConverters.VariableTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListWorkspaceScopeJsonConverter(),
                    new global::G.JsonConverters.ListWorkspaceScopeNullableJsonConverter(),
                    new global::G.JsonConverters.SpaceMemberJoinedStatusJsonConverter(),
                    new global::G.JsonConverters.SpaceMemberJoinedStatusNullableJsonConverter(),
                    new global::G.JsonConverters.WorkspaceRoleTypeJsonConverter(),
                    new global::G.JsonConverters.WorkspaceRoleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAPIEndReturnTypeJsonConverter(),
                    new global::G.JsonConverters.OpenAPIEndReturnTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAPIParamTypeJsonConverter(),
                    new global::G.JsonConverters.OpenAPIParamTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAPIParameterTypeJsonConverter(),
                    new global::G.JsonConverters.OpenAPIParameterTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAPIWorkflowModeJsonConverter(),
                    new global::G.JsonConverters.OpenAPIWorkflowModeNullableJsonConverter(),
                    new global::G.JsonConverters.EnterpriseMemberRoleJsonConverter(),
                    new global::G.JsonConverters.EnterpriseMemberRoleNullableJsonConverter(),
                    new global::G.JsonConverters.OrganizationPeopleOrganizationRoleTypeJsonConverter(),
                    new global::G.JsonConverters.OrganizationPeopleOrganizationRoleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OrganizationPeoplePeopleTypeJsonConverter(),
                    new global::G.JsonConverters.OrganizationPeoplePeopleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OrganizationRoleTypeJsonConverter(),
                    new global::G.JsonConverters.OrganizationRoleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PeopleTypeJsonConverter(),
                    new global::G.JsonConverters.PeopleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AppTypeOpenJsonConverter(),
                    new global::G.JsonConverters.AppTypeOpenNullableJsonConverter(),
                    new global::G.JsonConverters.FolderTypeJsonConverter(),
                    new global::G.JsonConverters.FolderTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TaskEntityTypeJsonConverter(),
                    new global::G.JsonConverters.TaskEntityTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TaskStatusJsonConverter(),
                    new global::G.JsonConverters.TaskStatusNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesConfigRoomModeJsonConverter(),
                    new global::G.JsonConverters.PropertiesConfigRoomModeNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesConfigPropertiesTurnDetectionTypeJsonConverter(),
                    new global::G.JsonConverters.PropertiesConfigPropertiesTurnDetectionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBasicInfoUserLevelJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBasicInfoUserLevelNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsBenefitTypeJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsBenefitTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatusJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicStatusNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategyJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesBasicPropertiesItemInfoStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatusJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectiveStatusNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategyJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesEffectivePropertiesItemInfoStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatusJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategyJsonConverter(),
                    new global::G.JsonConverters.PropertiesDataPropertiesBenefitInfoItemsPropertiesExtraItemsPropertiesItemInfoStrategyNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesTypeJsonConverter(),
                    new global::G.JsonConverters.PropertiesInterruptDataPropertiesRequiredParametersAdditionalPropertiesTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesModelInfoConfigApiModeJsonConverter(),
                    new global::G.JsonConverters.PropertiesModelInfoConfigApiModeNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesModelInfoConfigCacheTypeJsonConverter(),
                    new global::G.JsonConverters.PropertiesModelInfoConfigCacheTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesOrganizationPeopleItemsOrganizationRoleTypeJsonConverter(),
                    new global::G.JsonConverters.PropertiesOrganizationPeopleItemsOrganizationRoleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesPromptInfoPromptModeJsonConverter(),
                    new global::G.JsonConverters.PropertiesPromptInfoPromptModeNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesSuggestReplyInfoReplyModeJsonConverter(),
                    new global::G.JsonConverters.PropertiesSuggestReplyInfoReplyModeNullableJsonConverter(),
                    new global::G.JsonConverters.PropertiesUsersItemsRoleJsonConverter(),
                    new global::G.JsonConverters.PropertiesUsersItemsRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatSDKRequestConfigTypeJsonConverter(),
                    new global::G.JsonConverters.ChatSDKRequestConfigTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateApiAppOpenRequestAppTypeJsonConverter(),
                    new global::G.JsonConverters.CreateApiAppOpenRequestAppTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PublicAudioSpeechRequestEmotionJsonConverter(),
                    new global::G.JsonConverters.PublicAudioSpeechRequestEmotionNullableJsonConverter(),
                    new global::G.JsonConverters.PublicAudioSpeechRequestResponseFormatJsonConverter(),
                    new global::G.JsonConverters.PublicAudioSpeechRequestResponseFormatNullableJsonConverter(),
                    new global::G.JsonConverters.OpenSwitchBotDevelopModeRequestCollaborationModeJsonConverter(),
                    new global::G.JsonConverters.OpenSwitchBotDevelopModeRequestCollaborationModeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateMessageApiRequestContentTypeJsonConverter(),
                    new global::G.JsonConverters.CreateMessageApiRequestContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateMessageApiRequestRoleJsonConverter(),
                    new global::G.JsonConverters.CreateMessageApiRequestRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ListMessageApiRequestOrderJsonConverter(),
                    new global::G.JsonConverters.ListMessageApiRequestOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ModifyMessageApiRequestContentTypeJsonConverter(),
                    new global::G.JsonConverters.ModifyMessageApiRequestContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAPIUpdateEnterpriseMemberRequestRoleJsonConverter(),
                    new global::G.JsonConverters.OpenAPIUpdateEnterpriseMemberRequestRoleNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleTypeJsonConverter(),
                    new global::G.JsonConverters.OpenAPIUpdateOrganizationPeopleRequestOrganizationRoleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAPIToggleCollaborationModeRequestCollaborationModeJsonConverter(),
                    new global::G.JsonConverters.OpenAPIToggleCollaborationModeRequestCollaborationModeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatV3RequestPublishStatusJsonConverter(),
                    new global::G.JsonConverters.ChatV3RequestPublishStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CreateDocumentOpenAPIAgwJsConvJsonConverter(),
                    new global::G.JsonConverters.CreateDocumentOpenAPIAgwJsConvNullableJsonConverter(),
                    new global::G.JsonConverters.DeleteDocumentAPIAgwJsConvJsonConverter(),
                    new global::G.JsonConverters.DeleteDocumentAPIAgwJsConvNullableJsonConverter(),
                    new global::G.JsonConverters.ListDocumentOpenAPIAgwJsConvJsonConverter(),
                    new global::G.JsonConverters.ListDocumentOpenAPIAgwJsConvNullableJsonConverter(),
                    new global::G.JsonConverters.OpenGetProjectListPublishStatusJsonConverter(),
                    new global::G.JsonConverters.OpenGetProjectListPublishStatusNullableJsonConverter(),
                    new global::G.JsonConverters.OpenGetBotListPublishStatusJsonConverter(),
                    new global::G.JsonConverters.OpenGetBotListPublishStatusNullableJsonConverter(),
                    new global::G.JsonConverters.OpenListBotVersionsPublishStatusJsonConverter(),
                    new global::G.JsonConverters.OpenListBotVersionsPublishStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetDocumentProgressOpenAPIAgwJsConvJsonConverter(),
                    new global::G.JsonConverters.GetDocumentProgressOpenAPIAgwJsConvNullableJsonConverter(),
                    new global::G.JsonConverters.ChatV3ResponseEventJsonConverter(),
                    new global::G.JsonConverters.ChatV3ResponseEventNullableJsonConverter(),
                    new global::G.JsonConverters.SubmitToolOutputsResponseEventJsonConverter(),
                    new global::G.JsonConverters.SubmitToolOutputsResponseEventNullableJsonConverter(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
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