//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Core endpoints to manage user resources<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.instill.tech";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::System.Collections.Generic.List<global::G.EndPointAuthorization> _authorizations;

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
                    new global::G.JsonConverters.Mgmtv1betaStatusJsonConverter(),
                    new global::G.JsonConverters.Mgmtv1betaStatusNullableJsonConverter(),
                    new global::G.JsonConverters.OnboardingStatusJsonConverter(),
                    new global::G.JsonConverters.OnboardingStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CheckNamespaceAdminResponseNamespaceJsonConverter(),
                    new global::G.JsonConverters.CheckNamespaceAdminResponseNamespaceNullableJsonConverter(),
                    new global::G.JsonConverters.CheckNamespaceByUIDAdminResponseNamespaceJsonConverter(),
                    new global::G.JsonConverters.CheckNamespaceByUIDAdminResponseNamespaceNullableJsonConverter(),
                    new global::G.JsonConverters.CheckNamespaceResponseNamespaceJsonConverter(),
                    new global::G.JsonConverters.CheckNamespaceResponseNamespaceNullableJsonConverter(),
                    new global::G.JsonConverters.UserSubscriptionPlanJsonConverter(),
                    new global::G.JsonConverters.UserSubscriptionPlanNullableJsonConverter(),
                    new global::G.JsonConverters.StripeSubscriptionDetailStatusJsonConverter(),
                    new global::G.JsonConverters.StripeSubscriptionDetailStatusNullableJsonConverter(),
                    new global::G.JsonConverters.MembershipStateJsonConverter(),
                    new global::G.JsonConverters.MembershipStateNullableJsonConverter(),
                    new global::G.JsonConverters.OrganizationSubscriptionPlanJsonConverter(),
                    new global::G.JsonConverters.OrganizationSubscriptionPlanNullableJsonConverter(),
                    new global::G.JsonConverters.ModeJsonConverter(),
                    new global::G.JsonConverters.ModeNullableJsonConverter(),
                    new global::G.JsonConverters.ViewJsonConverter(),
                    new global::G.JsonConverters.ViewNullableJsonConverter(),
                    new global::G.JsonConverters.GetFileCatalogResponseChunkTypeJsonConverter(),
                    new global::G.JsonConverters.GetFileCatalogResponseChunkTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FileTypeJsonConverter(),
                    new global::G.JsonConverters.FileTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FileProcessStatusJsonConverter(),
                    new global::G.JsonConverters.FileProcessStatusNullableJsonConverter(),
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
                }
            };


        /// <summary>
        /// User endpoints
        /// </summary>
        public UserClient User => new UserClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Organization endpoints
        /// </summary>
        public OrganizationClient Organization => new OrganizationClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Membership endpoints
        /// </summary>
        public MembershipClient Membership => new MembershipClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Token endpoints
        /// </summary>
        public TokenClient Token => new TokenClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Subscription endpoints
        /// </summary>
        public SubscriptionClient Subscription => new SubscriptionClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Credit endpoints
        /// </summary>
        public CreditClient Credit => new CreditClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Metric endpoints
        /// </summary>
        public MetricClient Metric => new MetricClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Util endpoints
        /// </summary>
        public UtilsClient Utils => new UtilsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CatalogClient Catalog => new CatalogClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="authorizations"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
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