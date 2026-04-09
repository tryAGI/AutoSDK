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
        /// PRODUCTION API
        /// </summary>
        public const string DefaultBaseUrl = "https://backend.composio.dev/";

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
                    new global::G.JsonConverters.PostAuthConfigsRequestAuthConfigVariant1TypeJsonConverter(),

                    new global::G.JsonConverters.PostAuthConfigsRequestAuthConfigVariant1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.PostAuthConfigsRequestAuthConfigVariant2TypeJsonConverter(),

                    new global::G.JsonConverters.PostAuthConfigsRequestAuthConfigVariant2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.PostAuthConfigsRequestAuthConfigVariant2AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostAuthConfigsRequestAuthConfigVariant2AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PatchAuthConfigsByNanoidRequestVariant1TypeJsonConverter(),

                    new global::G.JsonConverters.PatchAuthConfigsByNanoidRequestVariant1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.PatchAuthConfigsByNanoidRequestVariant2TypeJsonConverter(),

                    new global::G.JsonConverters.PatchAuthConfigsByNanoidRequestVariant2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.PostCliCreateSessionRequestScopeJsonConverter(),

                    new global::G.JsonConverters.PostCliCreateSessionRequestScopeNullableJsonConverter(),

                    new global::G.JsonConverters.PostCliCodactFailuresRequestFailureTypeJsonConverter(),

                    new global::G.JsonConverters.PostCliCodactFailuresRequestFailureTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant2ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant3ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant4ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant6ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant8ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant9ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant12ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant13ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant14ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostInternalTriggerLogsRequestTimeJsonConverter(),

                    new global::G.JsonConverters.PostInternalTriggerLogsRequestTimeNullableJsonConverter(),

                    new global::G.JsonConverters.PostInternalTriggerLogsRequestStatusJsonConverter(),

                    new global::G.JsonConverters.PostInternalTriggerLogsRequestStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PatchOrgProjectConfigRequestLogVisibilitySettingJsonConverter(),

                    new global::G.JsonConverters.PatchOrgProjectConfigRequestLogVisibilitySettingNullableJsonConverter(),

                    new global::G.JsonConverters.PostOrgOwnerProjectNewRequestConfigLogVisibilitySettingJsonConverter(),

                    new global::G.JsonConverters.PostOrgOwnerProjectNewRequestConfigLogVisibilitySettingNullableJsonConverter(),

                    new global::G.JsonConverters.PostWebhookSubscriptionsRequestVersionJsonConverter(),

                    new global::G.JsonConverters.PostWebhookSubscriptionsRequestVersionNullableJsonConverter(),

                    new global::G.JsonConverters.PatchWebhookSubscriptionsByIdRequestVersionJsonConverter(),

                    new global::G.JsonConverters.PatchWebhookSubscriptionsByIdRequestVersionNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolkitsMultiRequestManagedByJsonConverter(),

                    new global::G.JsonConverters.PostToolkitsMultiRequestManagedByNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolkitsMultiRequestSortByJsonConverter(),

                    new global::G.JsonConverters.PostToolkitsMultiRequestSortByNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterInJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomAuthParamsParameterInNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestMethodJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestMethodNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestParameterTypeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestParameterTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant1AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant1AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant2AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant3AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant4AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant4AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant5AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant5AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant6AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant7AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant7AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant8AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant9AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant9AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant10AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolsExecuteProxyRequestCustomConnectionDataVariant11AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PatchTriggerInstancesManageByTriggerIdRequestStatusJsonConverter(),

                    new global::G.JsonConverters.PatchTriggerInstancesManageByTriggerIdRequestStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagsEnableItemJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagsEnableItemNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagsDisableItemJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagsDisableItemNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionRequestTagJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionRequestTagNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionRequestTagsEnableItemJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionRequestTagsEnableItemNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionRequestTagsDisableItemJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionRequestTagsDisableItemNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdExecuteMetaRequestSlugJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdExecuteMetaRequestSlugNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestMethodJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestMethodNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestParameterTypeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestParameterTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PatchAuthConfigsByNanoidByStatusStatusJsonConverter(),

                    new global::G.JsonConverters.PatchAuthConfigsByNanoidByStatusStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsStatuseJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsStatuseNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsOrderByJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsOrderByNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsOrderDirectionJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsOrderDirectionNullableJsonConverter(),

                    new global::G.JsonConverters.GetToolkitsManagedByJsonConverter(),

                    new global::G.JsonConverters.GetToolkitsManagedByNullableJsonConverter(),

                    new global::G.JsonConverters.GetToolkitsSortByJsonConverter(),

                    new global::G.JsonConverters.GetToolkitsSortByNullableJsonConverter(),

                    new global::G.JsonConverters.GetToolsImportantJsonConverter(),

                    new global::G.JsonConverters.GetToolsImportantNullableJsonConverter(),

                    new global::G.JsonConverters.GetMcpServersOrderByJsonConverter(),

                    new global::G.JsonConverters.GetMcpServersOrderByNullableJsonConverter(),

                    new global::G.JsonConverters.GetMcpServersOrderDirectionJsonConverter(),

                    new global::G.JsonConverters.GetMcpServersOrderDirectionNullableJsonConverter(),

                    new global::G.JsonConverters.GetMcpAppByAppKeyOrderByJsonConverter(),

                    new global::G.JsonConverters.GetMcpAppByAppKeyOrderByNullableJsonConverter(),

                    new global::G.JsonConverters.GetMcpAppByAppKeyOrderDirectionJsonConverter(),

                    new global::G.JsonConverters.GetMcpAppByAppKeyOrderDirectionNullableJsonConverter(),

                    new global::G.JsonConverters.GetMcpServersByServerIdInstancesOrderByJsonConverter(),

                    new global::G.JsonConverters.GetMcpServersByServerIdInstancesOrderByNullableJsonConverter(),

                    new global::G.JsonConverters.GetMcpServersByServerIdInstancesOrderDirectionJsonConverter(),

                    new global::G.JsonConverters.GetMcpServersByServerIdInstancesOrderDirectionNullableJsonConverter(),

                    new global::G.JsonConverters.GetMigrationGetNanoidTypeJsonConverter(),

                    new global::G.JsonConverters.GetMigrationGetNanoidTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetAuthSessionInfoResponseProjectWebhookVersionJsonConverter(),

                    new global::G.JsonConverters.GetAuthSessionInfoResponseProjectWebhookVersionNullableJsonConverter(),

                    new global::G.JsonConverters.GetAuthConfigsResponseItemTypeJsonConverter(),

                    new global::G.JsonConverters.GetAuthConfigsResponseItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetAuthConfigsResponseItemAuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetAuthConfigsResponseItemAuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetAuthConfigsResponseItemStatusJsonConverter(),

                    new global::G.JsonConverters.GetAuthConfigsResponseItemStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetAuthConfigsByNanoidResponseTypeJsonConverter(),

                    new global::G.JsonConverters.GetAuthConfigsByNanoidResponseTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetAuthConfigsByNanoidResponseAuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetAuthConfigsByNanoidResponseAuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetAuthConfigsByNanoidResponseStatusJsonConverter(),

                    new global::G.JsonConverters.GetAuthConfigsByNanoidResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostCliCreateSessionResponseStatusJsonConverter(),

                    new global::G.JsonConverters.PostCliCreateSessionResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostCliCreateSessionResponseScopeJsonConverter(),

                    new global::G.JsonConverters.PostCliCreateSessionResponseScopeNullableJsonConverter(),

                    new global::G.JsonConverters.GetCliGetSessionResponseStatusJsonConverter(),

                    new global::G.JsonConverters.GetCliGetSessionResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetCliGetSessionResponseScopeJsonConverter(),

                    new global::G.JsonConverters.GetCliGetSessionResponseScopeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemAuthConfigAuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemAuthConfigAuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant1ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant2ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant3AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant3AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant3ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant4AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant4AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant4ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant5AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant5AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant5ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant6AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant6AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant6ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant7ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant8ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant9ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant10ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant11AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant11AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant11ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant12ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant13ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsResponseItemStateVariant14ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant4ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant5ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant8ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant10ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant11ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant12ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant13ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant14ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseStatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseAuthConfigAuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseAuthConfigAuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant1ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant3ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant4ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant5ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant9ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant12ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant13ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14AuthSchemeJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14AuthSchemeNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6StatusJsonConverter(),

                    new global::G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant6StatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsByNanoidRefreshResponseStatusJsonConverter(),

                    new global::G.JsonConverters.PostConnectedAccountsByNanoidRefreshResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostInternalTriggerLogsResponseDataItemTypeJsonConverter(),

                    new global::G.JsonConverters.PostInternalTriggerLogsResponseDataItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PostInternalTriggerLogsResponseDataItemMetaTypeJsonConverter(),

                    new global::G.JsonConverters.PostInternalTriggerLogsResponseDataItemMetaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetInternalTriggerLogByIdResponseLogTypeJsonConverter(),

                    new global::G.JsonConverters.GetInternalTriggerLogByIdResponseLogTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetInternalTriggerLogByIdResponseLogMetaTypeJsonConverter(),

                    new global::G.JsonConverters.GetInternalTriggerLogByIdResponseLogMetaTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PostInternalActionExecutionLogsResponseDataItemStatusJsonConverter(),

                    new global::G.JsonConverters.PostInternalActionExecutionLogsResponseDataItemStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStatusJsonConverter(),

                    new global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStepTypeJsonConverter(),

                    new global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStepTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStepStatusJsonConverter(),

                    new global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStepStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStepLogTypeJsonConverter(),

                    new global::G.JsonConverters.GetInternalActionExecutionLogByIdResponseStepLogTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetOrgProjectConfigResponseLogVisibilitySettingJsonConverter(),

                    new global::G.JsonConverters.GetOrgProjectConfigResponseLogVisibilitySettingNullableJsonConverter(),

                    new global::G.JsonConverters.PatchOrgProjectConfigResponseLogVisibilitySettingJsonConverter(),

                    new global::G.JsonConverters.PatchOrgProjectConfigResponseLogVisibilitySettingNullableJsonConverter(),

                    new global::G.JsonConverters.GetOrgOwnerProjectListResponseDataItemWebhookVersionJsonConverter(),

                    new global::G.JsonConverters.GetOrgOwnerProjectListResponseDataItemWebhookVersionNullableJsonConverter(),

                    new global::G.JsonConverters.GetOrgOwnerProjectByNanoIdResponseWebhookVersionJsonConverter(),

                    new global::G.JsonConverters.GetOrgOwnerProjectByNanoIdResponseWebhookVersionNullableJsonConverter(),

                    new global::G.JsonConverters.DeleteOrgOwnerProjectByNanoIdResponseStatusJsonConverter(),

                    new global::G.JsonConverters.DeleteOrgOwnerProjectByNanoIdResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.PostOrgConsumerProjectResolveResponseProjectTypeJsonConverter(),

                    new global::G.JsonConverters.PostOrgConsumerProjectResolveResponseProjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PostWebhookSubscriptionsResponseVersionJsonConverter(),

                    new global::G.JsonConverters.PostWebhookSubscriptionsResponseVersionNullableJsonConverter(),

                    new global::G.JsonConverters.GetWebhookSubscriptionsResponseItemVersionJsonConverter(),

                    new global::G.JsonConverters.GetWebhookSubscriptionsResponseItemVersionNullableJsonConverter(),

                    new global::G.JsonConverters.GetWebhookSubscriptionsByIdResponseVersionJsonConverter(),

                    new global::G.JsonConverters.GetWebhookSubscriptionsByIdResponseVersionNullableJsonConverter(),

                    new global::G.JsonConverters.PatchWebhookSubscriptionsByIdResponseVersionJsonConverter(),

                    new global::G.JsonConverters.PatchWebhookSubscriptionsByIdResponseVersionNullableJsonConverter(),

                    new global::G.JsonConverters.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersionJsonConverter(),

                    new global::G.JsonConverters.GetWebhookSubscriptionsEventTypesResponseItemSupportedVersionNullableJsonConverter(),

                    new global::G.JsonConverters.PatchTriggerInstancesManageByTriggerIdResponseStatusJsonConverter(),

                    new global::G.JsonConverters.PatchTriggerInstancesManageByTriggerIdResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetTriggersTypesBySlugResponseTypeJsonConverter(),

                    new global::G.JsonConverters.GetTriggersTypesBySlugResponseTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetTriggersTypesResponseItemTypeJsonConverter(),

                    new global::G.JsonConverters.GetTriggersTypesResponseItemTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PostFilesUploadRequestResponseTypeJsonConverter(),

                    new global::G.JsonConverters.PostFilesUploadRequestResponseTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PostFilesUploadRequestResponseMetadataStorageBackendJsonConverter(),

                    new global::G.JsonConverters.PostFilesUploadRequestResponseMetadataStorageBackendNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionResponseMcpTypeJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionResponseMcpTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItemJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionResponseConfigToolsVariant3TagsEnabledItemNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItemJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItemNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionResponseConfigTagsEnabledItemJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionResponseConfigTagsEnabledItemNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionResponseConfigTagsDisabledItemJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionResponseConfigTagsDisabledItemNullableJsonConverter(),

                    new global::G.JsonConverters.GetToolRouterSessionBySessionIdResponseMcpTypeJsonConverter(),

                    new global::G.JsonConverters.GetToolRouterSessionBySessionIdResponseMcpTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemJsonConverter(),

                    new global::G.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemNullableJsonConverter(),

                    new global::G.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItemJsonConverter(),

                    new global::G.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItemNullableJsonConverter(),

                    new global::G.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItemJsonConverter(),

                    new global::G.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItemNullableJsonConverter(),

                    new global::G.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItemJsonConverter(),

                    new global::G.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigTagsDisabledItemNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelectionJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountSelectionNullableJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefToolJsonConverter(),

                    new global::G.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefToolNullableJsonConverter(),

                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// Authentication configuration management.
        /// </summary>
        public AuthConfigsClient AuthConfigs => new AuthConfigsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Authentication related endpoints.
        /// </summary>
        public AuthenticationClient Authentication => new AuthenticationClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// CLI integration endpoints.
        /// </summary>
        public CliClient Cli => new CliClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CliAuthenticationClient CliAuthentication => new CliAuthenticationClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Connected account management.
        /// </summary>
        public ConnectedAccountsClient ConnectedAccounts => new ConnectedAccountsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// File management.
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Logging and monitoring.
        /// </summary>
        public LogsClient Logs => new LogsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// MCP server management.
        /// </summary>
        public McpClient Mcp => new McpClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Endpoints to help with migration from v1 to v3.
        /// </summary>
        public MigrationClient Migration => new MigrationClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationManagementClient OrganizationManagement => new OrganizationManagementClient(HttpClient, authorizations: Authorizations, options: Options)
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
        /// (Labs) Tool router endpoints.
        /// </summary>
        public ToolRouterClient ToolRouter => new ToolRouterClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Toolkit and tool management.
        /// </summary>
        public ToolkitsClient Toolkits => new ToolkitsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Tool execution endpoints.
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Trigger management and execution.
        /// </summary>
        public TriggersClient Triggers => new TriggersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Webhook configuration.
        /// </summary>
        public WebhooksClient Webhooks => new WebhooksClient(HttpClient, authorizations: Authorizations, options: Options)
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