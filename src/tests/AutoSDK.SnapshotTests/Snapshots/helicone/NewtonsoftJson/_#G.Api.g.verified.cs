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
        public const string DefaultBaseUrl = "https://api.helicone.ai/";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => ResolveDisplayedBaseUri();

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::G.AutoSDKClientOptions Options { get; }


        internal global::G.AutoSDKServerConfiguration AutoSDKServerConfiguration { get; set; } = new global::G.AutoSDKServerConfiguration();
        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings
            {
                Converters =
                {
                    new global::G.JsonConverters.DataEntryVariant1TypeJsonConverter(),

                    new global::G.JsonConverters.DataEntryVariant1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.DataEntryVariant2TypeJsonConverter(),

                    new global::G.JsonConverters.DataEntryVariant2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.DataEntryVariant3ContentJsonConverter(),

                    new global::G.JsonConverters.DataEntryVariant3ContentNullableJsonConverter(),

                    new global::G.JsonConverters.DataEntryVariant3TypeJsonConverter(),

                    new global::G.JsonConverters.DataEntryVariant3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.DataEntryVariant4ContentJsonConverter(),

                    new global::G.JsonConverters.DataEntryVariant4ContentNullableJsonConverter(),

                    new global::G.JsonConverters.DataEntryVariant4TypeJsonConverter(),

                    new global::G.JsonConverters.DataEntryVariant4TypeNullableJsonConverter(),

                    new global::G.JsonConverters.LastMileConfigFormVariant2Variant1TypeJsonConverter(),

                    new global::G.JsonConverters.LastMileConfigFormVariant2Variant1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.LastMileConfigFormVariant2Variant2TypeJsonConverter(),

                    new global::G.JsonConverters.LastMileConfigFormVariant2Variant2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.EvaluatorStatsRecentTrendJsonConverter(),

                    new global::G.JsonConverters.EvaluatorStatsRecentTrendNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIChatRequestMessageToolCallTypeJsonConverter(),

                    new global::G.JsonConverters.OpenAIChatRequestMessageToolCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIChatRequestToolTypeJsonConverter(),

                    new global::G.JsonConverters.OpenAIChatRequestToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIChatRequestToolChoiceEnumFunctionTypeJsonConverter(),

                    new global::G.JsonConverters.OpenAIChatRequestToolChoiceEnumFunctionTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIChatRequestToolChoiceEnum2JsonConverter(),

                    new global::G.JsonConverters.OpenAIChatRequestToolChoiceEnum2NullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIChatRequestReasoningEffortJsonConverter(),

                    new global::G.JsonConverters.OpenAIChatRequestReasoningEffortNullableJsonConverter(),

                    new global::G.JsonConverters.OpenAIChatRequestVerbosityJsonConverter(),

                    new global::G.JsonConverters.OpenAIChatRequestVerbosityNullableJsonConverter(),

                    new global::G.JsonConverters.Prompt2025VersionPromptBodyMessageToolCallTypeJsonConverter(),

                    new global::G.JsonConverters.Prompt2025VersionPromptBodyMessageToolCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.Prompt2025VersionPromptBodyToolTypeJsonConverter(),

                    new global::G.JsonConverters.Prompt2025VersionPromptBodyToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.Prompt2025VersionPromptBodyToolChoiceFunctionTypeJsonConverter(),

                    new global::G.JsonConverters.Prompt2025VersionPromptBodyToolChoiceFunctionTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PromptsFilterNodeEnumJsonConverter(),

                    new global::G.JsonConverters.PromptsFilterNodeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.PromptsFilterBranchOperatorJsonConverter(),

                    new global::G.JsonConverters.PromptsFilterBranchOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.PromptVersionsFilterNodeEnumJsonConverter(),

                    new global::G.JsonConverters.PromptVersionsFilterNodeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.PromptVersionsFilterBranchOperatorJsonConverter(),

                    new global::G.JsonConverters.PromptVersionsFilterBranchOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.UpgradeToProRequestUiModeJsonConverter(),

                    new global::G.JsonConverters.UpgradeToProRequestUiModeNullableJsonConverter(),

                    new global::G.JsonConverters.UpgradeToTeamBundleRequestUiModeJsonConverter(),

                    new global::G.JsonConverters.UpgradeToTeamBundleRequestUiModeNullableJsonConverter(),

                    new global::G.JsonConverters.RequestFilterNodeEnumJsonConverter(),

                    new global::G.JsonConverters.RequestFilterNodeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.RequestFilterBranchOperatorJsonConverter(),

                    new global::G.JsonConverters.RequestFilterBranchOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.SortDirectionJsonConverter(),

                    new global::G.JsonConverters.SortDirectionNullableJsonConverter(),

                    new global::G.JsonConverters.ProviderNameJsonConverter(),

                    new global::G.JsonConverters.ProviderNameNullableJsonConverter(),

                    new global::G.JsonConverters.ModelProviderNameJsonConverter(),

                    new global::G.JsonConverters.ModelProviderNameNullableJsonConverter(),

                    new global::G.JsonConverters.ProviderEnumJsonConverter(),

                    new global::G.JsonConverters.ProviderEnumNullableJsonConverter(),

                    new global::G.JsonConverters.LlmTypeJsonConverter(),

                    new global::G.JsonConverters.LlmTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageAnnotationTypeJsonConverter(),

                    new global::G.JsonConverters.MessageAnnotationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageTypeJsonConverter(),

                    new global::G.JsonConverters.MessageTypeNullableJsonConverter(),

                    new global::G.JsonConverters.MessageRoleJsonConverter(),

                    new global::G.JsonConverters.MessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.MessageType2JsonConverter(),

                    new global::G.JsonConverters.MessageType2NullableJsonConverter(),

                    new global::G.JsonConverters.HeliconeEventToolTypeJsonConverter(),

                    new global::G.JsonConverters.HeliconeEventToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.HeliconeEventVectorDBTypeJsonConverter(),

                    new global::G.JsonConverters.HeliconeEventVectorDBTypeNullableJsonConverter(),

                    new global::G.JsonConverters.HeliconeEventVectorDBOperationJsonConverter(),

                    new global::G.JsonConverters.HeliconeEventVectorDBOperationNullableJsonConverter(),

                    new global::G.JsonConverters.HeliconeEventDataTypeJsonConverter(),

                    new global::G.JsonConverters.HeliconeEventDataTypeNullableJsonConverter(),

                    new global::G.JsonConverters.LLMRequestBodyReasoningEffortJsonConverter(),

                    new global::G.JsonConverters.LLMRequestBodyReasoningEffortNullableJsonConverter(),

                    new global::G.JsonConverters.LLMRequestBodyVerbosityJsonConverter(),

                    new global::G.JsonConverters.LLMRequestBodyVerbosityNullableJsonConverter(),

                    new global::G.JsonConverters.LLMRequestBodyToolChoiceTypeJsonConverter(),

                    new global::G.JsonConverters.LLMRequestBodyToolChoiceTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseTypeJsonConverter(),

                    new global::G.JsonConverters.ResponseTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseRoleJsonConverter(),

                    new global::G.JsonConverters.ResponseRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseType2JsonConverter(),

                    new global::G.JsonConverters.ResponseType2NullableJsonConverter(),

                    new global::G.JsonConverters.LLMResponseBodyDataDetailsResponseTypeJsonConverter(),

                    new global::G.JsonConverters.LLMResponseBodyDataDetailsResponseTypeNullableJsonConverter(),

                    new global::G.JsonConverters.LLMResponseBodyVectorDBDetailsResponseTypeJsonConverter(),

                    new global::G.JsonConverters.LLMResponseBodyVectorDBDetailsResponseTypeNullableJsonConverter(),

                    new global::G.JsonConverters.LLMResponseBodyToolDetailsResponseTypeJsonConverter(),

                    new global::G.JsonConverters.LLMResponseBodyToolDetailsResponseTypeNullableJsonConverter(),

                    new global::G.JsonConverters.UserFilterNodeEnumJsonConverter(),

                    new global::G.JsonConverters.UserFilterNodeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.UserFilterBranchOperatorJsonConverter(),

                    new global::G.JsonConverters.UserFilterBranchOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.PSizeJsonConverter(),

                    new global::G.JsonConverters.PSizeNullableJsonConverter(),

                    new global::G.JsonConverters.StatsTimeFrameJsonConverter(),

                    new global::G.JsonConverters.StatsTimeFrameNullableJsonConverter(),

                    new global::G.JsonConverters.SessionFilterNodeEnumJsonConverter(),

                    new global::G.JsonConverters.SessionFilterNodeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.SessionFilterBranchOperatorJsonConverter(),

                    new global::G.JsonConverters.SessionFilterBranchOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.SessionNameQueryParamsPSizeJsonConverter(),

                    new global::G.JsonConverters.SessionNameQueryParamsPSizeNullableJsonConverter(),

                    new global::G.JsonConverters.SessionMetricsQueryParamsPSizeJsonConverter(),

                    new global::G.JsonConverters.SessionMetricsQueryParamsPSizeNullableJsonConverter(),

                    new global::G.JsonConverters.TimeFrameJsonConverter(),

                    new global::G.JsonConverters.TimeFrameNullableJsonConverter(),

                    new global::G.JsonConverters.FilterNodeEnum2JsonConverter(),

                    new global::G.JsonConverters.FilterNodeEnum2NullableJsonConverter(),

                    new global::G.JsonConverters.FilterBranchOperatorJsonConverter(),

                    new global::G.JsonConverters.FilterBranchOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.RequestClickhouseFilterNodeEnumJsonConverter(),

                    new global::G.JsonConverters.RequestClickhouseFilterNodeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.RequestClickhouseFilterBranchOperatorJsonConverter(),

                    new global::G.JsonConverters.RequestClickhouseFilterBranchOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.TimeIncrementJsonConverter(),

                    new global::G.JsonConverters.TimeIncrementNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageAnnotationTypeJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageAnnotationTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageFunctionToolCallTypeJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageFunctionToolCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageCustomToolCallTypeJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageCustomToolCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageRoleJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionObjectJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionServiceTierJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionServiceTierNullableJsonConverter(),

                    new global::G.JsonConverters.AuthorNameJsonConverter(),

                    new global::G.JsonConverters.AuthorNameNullableJsonConverter(),

                    new global::G.JsonConverters.StandardParameterJsonConverter(),

                    new global::G.JsonConverters.StandardParameterNullableJsonConverter(),

                    new global::G.JsonConverters.PluginIdJsonConverter(),

                    new global::G.JsonConverters.PluginIdNullableJsonConverter(),

                    new global::G.JsonConverters.BodyMappingTypeJsonConverter(),

                    new global::G.JsonConverters.BodyMappingTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatNullableJsonConverter(),

                    new global::G.JsonConverters.ModelProviderConfigQuantizationJsonConverter(),

                    new global::G.JsonConverters.ModelProviderConfigQuantizationNullableJsonConverter(),

                    new global::G.JsonConverters.InputModalityJsonConverter(),

                    new global::G.JsonConverters.InputModalityNullableJsonConverter(),

                    new global::G.JsonConverters.OutputModalityJsonConverter(),

                    new global::G.JsonConverters.OutputModalityNullableJsonConverter(),

                    new global::G.JsonConverters.ModelCapabilityJsonConverter(),

                    new global::G.JsonConverters.ModelCapabilityNullableJsonConverter(),

                    new global::G.JsonConverters.OAIModelObjectJsonConverter(),

                    new global::G.JsonConverters.OAIModelObjectNullableJsonConverter(),

                    new global::G.JsonConverters.OAIModelsResponseObjectJsonConverter(),

                    new global::G.JsonConverters.OAIModelsResponseObjectNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentFilterNodeEnumJsonConverter(),

                    new global::G.JsonConverters.ExperimentFilterNodeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ExperimentFilterBranchOperatorJsonConverter(),

                    new global::G.JsonConverters.ExperimentFilterBranchOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.NewDatasetParamsDatasetTypeJsonConverter(),

                    new global::G.JsonConverters.NewDatasetParamsDatasetTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetFilterNodeEnumJsonConverter(),

                    new global::G.JsonConverters.DatasetFilterNodeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.DatasetFilterBranchOperatorJsonConverter(),

                    new global::G.JsonConverters.DatasetFilterBranchOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.EvalFilterNodeEnumJsonConverter(),

                    new global::G.JsonConverters.EvalFilterNodeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.EvalFilterBranchOperatorJsonConverter(),

                    new global::G.JsonConverters.EvalFilterBranchOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.CreateAPIKeyRequestKeyPermissionsJsonConverter(),

                    new global::G.JsonConverters.CreateAPIKeyRequestKeyPermissionsNullableJsonConverter(),

                    new global::G.JsonConverters.TrackShareRequestPlatformJsonConverter(),

                    new global::G.JsonConverters.TrackShareRequestPlatformNullableJsonConverter(),

                    new global::G.JsonConverters.CreateNewExperimentHypothesisRequestStatusJsonConverter(),

                    new global::G.JsonConverters.CreateNewExperimentHypothesisRequestStatusNullableJsonConverter(),

                    new global::G.JsonConverters.AddOnsProductTypeJsonConverter(),

                    new global::G.JsonConverters.AddOnsProductTypeNullableJsonConverter(),

                    new global::G.JsonConverters.DeleteAddOnsProductTypeJsonConverter(),

                    new global::G.JsonConverters.DeleteAddOnsProductTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetSpendBreakdownTimeRangeJsonConverter(),

                    new global::G.JsonConverters.GetSpendBreakdownTimeRangeNullableJsonConverter(),

                    new global::G.JsonConverters.DeleteProviderKeyResponseVariant1ProviderNameJsonConverter(),

                    new global::G.JsonConverters.DeleteProviderKeyResponseVariant1ProviderNameNullableJsonConverter(),

                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public AdminAlertBannerClient AdminAlertBanner => new AdminAlertBannerClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public AgentClient Agent => new AgentClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeyClient ApiKey => new ApiKeyClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public ComparisonClient Comparison => new ComparisonClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public CreditsClient Credits => new CreditsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public CustomerClient Customer => new CustomerClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public DashboardClient Dashboard => new DashboardClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetClient Dataset => new DatasetClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvalsClient Evals => new EvalsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public EvaluatorClient Evaluator => new EvaluatorClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExperimentClient Experiment => new ExperimentClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public HeliconeSqlClient HeliconeSql => new HeliconeSqlClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public IntegrationClient Integration => new IntegrationClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetricsClient Metrics => new MetricsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelRegistryClient ModelRegistry => new ModelRegistryClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public PiClient Pi => new PiClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public PlaygroundClient Playground => new PlaygroundClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptClient Prompt => new PromptClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public Prompt2025Client Prompt2025 => new Prompt2025Client(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public Prompt2025V2Client Prompt2025V2 => new Prompt2025V2Client(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public PropertyClient Property => new PropertyClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProvidersClient Providers => new ProvidersClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public RequestClient Request => new RequestClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public SecurityClient Security => new SecurityClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public SessionClient Session => new SessionClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public StatsClient Stats => new StatsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public StatusClient Status => new StatusClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public StripeClient Stripe => new StripeClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public TestClient Test => new TestClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public TraceClient Trace => new TraceClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public UserClient User => new UserClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public VaultClient Vault => new VaultClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public WaitlistClient Waitlist => new WaitlistClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks => new WebhooksClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };

        /// <summary>
        /// 
        /// </summary>
        public WrappedClient Wrapped => new WrappedClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
            AutoSDKServerConfiguration = AutoSDKServerConfiguration,
        };


        private static readonly global::G.AutoSDKServer[] s_availableServers = new global::G.AutoSDKServer[]
        {            new global::G.AutoSDKServer(
                id: "https-api-helicone-ai",
                name: "api.helicone.ai",
                url: "https://api.helicone.ai/",
                description: ""),
            new global::G.AutoSDKServer(
                id: "http-localhost",
                name: "localhost",
                url: "http://localhost:8585/",
                description: ""),
        };

        /// <summary>
        /// The server options available for this client.
        /// </summary>
        public global::System.Collections.Generic.IReadOnlyList<global::G.AutoSDKServer> AvailableServers => s_availableServers;

        /// <summary>
        /// The currently selected server for this client, if any.
        /// </summary>
        public global::G.AutoSDKServer? SelectedServer
        {
            get => ResolveSelectedServer();
            set => SelectServer(value);
        }

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
        /// Creates a new instance of the Api with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations,
            global::G.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
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
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations,
            global::G.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            Options = options ?? new global::G.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            AutoSDKServerConfiguration.ExplicitBaseUri = baseUri ?? httpClient?.BaseAddress;

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


        /// <summary>
        /// Selects one of the generated server options by id.
        /// </summary>
        public bool TrySelectServer(string serverId)
        {
            if (string.IsNullOrWhiteSpace(serverId))
            {
                return false;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, serverId, global::System.StringComparison.OrdinalIgnoreCase))
                {
                    AutoSDKServerConfiguration.SelectedServer = server;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Clears the currently selected server.
        /// </summary>
        public void ClearSelectedServer()
        {
            AutoSDKServerConfiguration.SelectedServer = null;
        }

        private global::G.AutoSDKServer? ResolveSelectedServer()
        {
            var selectedServer = AutoSDKServerConfiguration.SelectedServer;
            if (selectedServer is null)
            {
                return null;
            }

            foreach (var server in s_availableServers)
            {
                if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                {
                    return server;
                }
            }

            return null;
        }

        private void SelectServer(global::G.AutoSDKServer? server)
        {
            if (server is null)
            {
                AutoSDKServerConfiguration.SelectedServer = null;
                return;
            }

            foreach (var candidate in s_availableServers)
            {
                if (string.Equals(candidate.Id, server.Id, global::System.StringComparison.Ordinal))
                {
                    AutoSDKServerConfiguration.SelectedServer = candidate;
                    AutoSDKServerConfiguration.ExplicitBaseUri = null;
                    return;
                }
            }

            throw new global::System.ArgumentException("The provided server is not available for this client.", nameof(server));
        }

        private global::System.Uri? ResolveDisplayedBaseUri()
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            return ResolveSelectedServer()?.Uri ?? HttpClient.BaseAddress;
        }

        private global::System.Uri? ResolveBaseUri(
            global::G.AutoSDKServer[] servers,
            string defaultBaseUrl)
        {
            if (AutoSDKServerConfiguration.ExplicitBaseUri is global::System.Uri explicitBaseUri)
            {
                return explicitBaseUri;
            }

            if (AutoSDKServerConfiguration.SelectedServer is global::G.AutoSDKServer selectedServer)
            {
                foreach (var server in servers)
                {
                    if (string.Equals(server.Id, selectedServer.Id, global::System.StringComparison.Ordinal))
                    {
                        return server.Uri;
                    }
                }
            }

            if (servers.Length > 0)
            {
                return servers[0].Uri;
            }

            return string.IsNullOrWhiteSpace(defaultBaseUrl)
                ? HttpClient.BaseAddress
                : new global::System.Uri(defaultBaseUrl, global::System.UriKind.RelativeOrAbsolute);
        }
    }
}