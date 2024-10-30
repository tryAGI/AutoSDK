//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Interact with Instill AI through its public API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.instill.tech";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.ApiTokenStateJsonConverter(),
                    new global::G.JsonConverters.ApiTokenStateNullableJsonConverter(),
                    new global::G.JsonConverters.AppTypeJsonConverter(),
                    new global::G.JsonConverters.AppTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OnboardingStatusJsonConverter(),
                    new global::G.JsonConverters.OnboardingStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CatalogRunActionJsonConverter(),
                    new global::G.JsonConverters.CatalogRunActionNullableJsonConverter(),
                    new global::G.JsonConverters.RunStatusJsonConverter(),
                    new global::G.JsonConverters.RunStatusNullableJsonConverter(),
                    new global::G.JsonConverters.RunSourceJsonConverter(),
                    new global::G.JsonConverters.RunSourceNullableJsonConverter(),
                    new global::G.JsonConverters.CheckNamespaceAdminResponseNamespaceJsonConverter(),
                    new global::G.JsonConverters.CheckNamespaceAdminResponseNamespaceNullableJsonConverter(),
                    new global::G.JsonConverters.CheckNamespaceByUIDAdminResponseNamespaceJsonConverter(),
                    new global::G.JsonConverters.CheckNamespaceByUIDAdminResponseNamespaceNullableJsonConverter(),
                    new global::G.JsonConverters.CheckNamespaceResponseNamespaceJsonConverter(),
                    new global::G.JsonConverters.CheckNamespaceResponseNamespaceNullableJsonConverter(),
                    new global::G.JsonConverters.ChunkTypeJsonConverter(),
                    new global::G.JsonConverters.ChunkTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RoleJsonConverter(),
                    new global::G.JsonConverters.RoleNullableJsonConverter(),
                    new global::G.JsonConverters.ComponentTypeJsonConverter(),
                    new global::G.JsonConverters.ComponentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ComponentDefinitionReleaseStageJsonConverter(),
                    new global::G.JsonConverters.ComponentDefinitionReleaseStageNullableJsonConverter(),
                    new global::G.JsonConverters.ComponentDefinitionViewJsonConverter(),
                    new global::G.JsonConverters.ComponentDefinitionViewNullableJsonConverter(),
                    new global::G.JsonConverters.MethodJsonConverter(),
                    new global::G.JsonConverters.MethodNullableJsonConverter(),
                    new global::G.JsonConverters.PipelineV1betaViewJsonConverter(),
                    new global::G.JsonConverters.PipelineV1betaViewNullableJsonConverter(),
                    new global::G.JsonConverters.MessageTypeJsonConverter(),
                    new global::G.JsonConverters.MessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AITaskJsonConverter(),
                    new global::G.JsonConverters.AITaskNullableJsonConverter(),
                    new global::G.JsonConverters.ModelVisibilityJsonConverter(),
                    new global::G.JsonConverters.ModelVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.PipelineVisibilityJsonConverter(),
                    new global::G.JsonConverters.PipelineVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.FileTypeJsonConverter(),
                    new global::G.JsonConverters.FileTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FileProcessStatusJsonConverter(),
                    new global::G.JsonConverters.FileProcessStatusNullableJsonConverter(),
                    new global::G.JsonConverters.UserSubscriptionPlanJsonConverter(),
                    new global::G.JsonConverters.UserSubscriptionPlanNullableJsonConverter(),
                    new global::G.JsonConverters.StripeSubscriptionDetailStatusJsonConverter(),
                    new global::G.JsonConverters.StripeSubscriptionDetailStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ReleaseStageJsonConverter(),
                    new global::G.JsonConverters.ReleaseStageNullableJsonConverter(),
                    new global::G.JsonConverters.MembershipStateJsonConverter(),
                    new global::G.JsonConverters.MembershipStateNullableJsonConverter(),
                    new global::G.JsonConverters.OrganizationSubscriptionPlanJsonConverter(),
                    new global::G.JsonConverters.OrganizationSubscriptionPlanNullableJsonConverter(),
                    new global::G.JsonConverters.StateJsonConverter(),
                    new global::G.JsonConverters.StateNullableJsonConverter(),
                    new global::G.JsonConverters.ModeJsonConverter(),
                    new global::G.JsonConverters.ModeNullableJsonConverter(),
                    new global::G.JsonConverters.StatusJsonConverter(),
                    new global::G.JsonConverters.StatusNullableJsonConverter(),
                    new global::G.JsonConverters.PipelineViewJsonConverter(),
                    new global::G.JsonConverters.PipelineViewNullableJsonConverter(),
                    new global::G.JsonConverters.TraceStatusJsonConverter(),
                    new global::G.JsonConverters.TraceStatusNullableJsonConverter(),
                    new global::G.JsonConverters.MgmtV1betaViewJsonConverter(),
                    new global::G.JsonConverters.MgmtV1betaViewNullableJsonConverter(),
                    new global::G.JsonConverters.ViewJsonConverter(),
                    new global::G.JsonConverters.ViewNullableJsonConverter(),
                    new global::G.JsonConverters.ListUsersViewJsonConverter(),
                    new global::G.JsonConverters.ListUsersViewNullableJsonConverter(),
                    new global::G.JsonConverters.GetUserViewJsonConverter(),
                    new global::G.JsonConverters.GetUserViewNullableJsonConverter(),
                    new global::G.JsonConverters.ListOrganizationsViewJsonConverter(),
                    new global::G.JsonConverters.ListOrganizationsViewNullableJsonConverter(),
                    new global::G.JsonConverters.GetOrganizationViewJsonConverter(),
                    new global::G.JsonConverters.GetOrganizationViewNullableJsonConverter(),
                    new global::G.JsonConverters.GetUserMembershipViewJsonConverter(),
                    new global::G.JsonConverters.GetUserMembershipViewNullableJsonConverter(),
                    new global::G.JsonConverters.GetOrganizationMembershipViewJsonConverter(),
                    new global::G.JsonConverters.GetOrganizationMembershipViewNullableJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceListModelDefinitionsViewJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceListModelDefinitionsViewNullableJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceGetModelDefinitionViewJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceGetModelDefinitionViewNullableJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceListModelsViewJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceListModelsViewNullableJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceListModelsVisibilityJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceListModelsVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceListNamespaceModelsViewJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceListNamespaceModelsViewNullableJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceListNamespaceModelsVisibilityJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceListNamespaceModelsVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceGetNamespaceModelViewJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceGetNamespaceModelViewNullableJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceGetNamespaceModelOperationViewJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceGetNamespaceModelOperationViewNullableJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceGetNamespaceLatestModelOperationViewJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceGetNamespaceLatestModelOperationViewNullableJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceGetModelOperationViewJsonConverter(),
                    new global::G.JsonConverters.ModelPublicServiceGetModelOperationViewNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListPipelinesViewJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListPipelinesViewNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListPipelinesVisibilityJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListPipelinesVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListNamespacePipelinesViewJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListNamespacePipelinesViewNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListNamespacePipelinesVisibilityJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListNamespacePipelinesVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceGetNamespacePipelineViewJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceGetNamespacePipelineViewNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListNamespacePipelineReleasesViewJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListNamespacePipelineReleasesViewNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceGetNamespacePipelineReleaseViewJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceGetNamespacePipelineReleaseViewNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListComponentDefinitionsViewJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListComponentDefinitionsViewNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListComponentRunsViewJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceListComponentRunsViewNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceGetNamespaceConnectionViewJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceGetNamespaceConnectionViewNullableJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceGetIntegrationViewJsonConverter(),
                    new global::G.JsonConverters.PipelinePublicServiceGetIntegrationViewNullableJsonConverter(),
                }
            };


        /// <summary>
        /// Namespaces (e.g. User, Organization) that structure the resource hierarchy.
        /// </summary>
        public NamespaceClient Namespace => new NamespaceClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Pipeline orchestration in VDP (Versatile Data Pipeline).
        /// </summary>
        public VDPClient VDP => new VDPClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// AI Model resources for MLOps/LLMOps.
        /// </summary>
        public ModelClient Model => new ModelClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Data orchestration for unified unstructured data representation.
        /// </summary>
        public ArtifactClient Artifact => new ArtifactClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Ready-to-use AI applications.
        /// </summary>
        public AppClient App => new AppClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Resource usage metrics.
        /// </summary>
        public MetricsClient Metrics => new MetricsClient(HttpClient, authorizations: Authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Pricing plans on Instill Cloud.
        /// </summary>
        public SubscriptionClient Subscription => new SubscriptionClient(HttpClient, authorizations: Authorizations)
        {
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