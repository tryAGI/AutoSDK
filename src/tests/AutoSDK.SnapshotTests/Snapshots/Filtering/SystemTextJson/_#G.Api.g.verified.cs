//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GitHub's v3 REST API.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.github.com";

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
                    new global::G.JsonConverters.RepositorySquashMergeCommitTitleJsonConverter(),
                    new global::G.JsonConverters.RepositorySquashMergeCommitTitleNullableJsonConverter(),
                    new global::G.JsonConverters.RepositorySquashMergeCommitMessageJsonConverter(),
                    new global::G.JsonConverters.RepositorySquashMergeCommitMessageNullableJsonConverter(),
                    new global::G.JsonConverters.RepositoryMergeCommitTitleJsonConverter(),
                    new global::G.JsonConverters.RepositoryMergeCommitTitleNullableJsonConverter(),
                    new global::G.JsonConverters.RepositoryMergeCommitMessageJsonConverter(),
                    new global::G.JsonConverters.RepositoryMergeCommitMessageNullableJsonConverter(),
                    new global::G.JsonConverters.SecurityAndAnalysisAdvancedSecurityStatusJsonConverter(),
                    new global::G.JsonConverters.SecurityAndAnalysisAdvancedSecurityStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SecurityAndAnalysisDependabotSecurityUpdatesStatusJsonConverter(),
                    new global::G.JsonConverters.SecurityAndAnalysisDependabotSecurityUpdatesStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SecurityAndAnalysisSecretScanningStatusJsonConverter(),
                    new global::G.JsonConverters.SecurityAndAnalysisSecretScanningStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SecurityAndAnalysisSecretScanningPushProtectionStatusJsonConverter(),
                    new global::G.JsonConverters.SecurityAndAnalysisSecretScanningPushProtectionStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SecurityAndAnalysisSecretScanningNonProviderPatternsStatusJsonConverter(),
                    new global::G.JsonConverters.SecurityAndAnalysisSecretScanningNonProviderPatternsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SecurityAndAnalysisSecretScanningAiDetectionStatusJsonConverter(),
                    new global::G.JsonConverters.SecurityAndAnalysisSecretScanningAiDetectionStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ImportStatusJsonConverter(),
                    new global::G.JsonConverters.ImportStatusNullableJsonConverter(),
                    new global::G.JsonConverters.MigrationsStartForOrgRequestExcludeItemJsonConverter(),
                    new global::G.JsonConverters.MigrationsStartForOrgRequestExcludeItemNullableJsonConverter(),
                    new global::G.JsonConverters.MigrationsStartImportRequestVcsJsonConverter(),
                    new global::G.JsonConverters.MigrationsStartImportRequestVcsNullableJsonConverter(),
                    new global::G.JsonConverters.MigrationsUpdateImportRequestVcsJsonConverter(),
                    new global::G.JsonConverters.MigrationsUpdateImportRequestVcsNullableJsonConverter(),
                    new global::G.JsonConverters.MigrationsSetLfsPreferenceRequestUseLfsJsonConverter(),
                    new global::G.JsonConverters.MigrationsSetLfsPreferenceRequestUseLfsNullableJsonConverter(),
                    new global::G.JsonConverters.MigrationsStartForAuthenticatedUserRequestExcludeItemJsonConverter(),
                    new global::G.JsonConverters.MigrationsStartForAuthenticatedUserRequestExcludeItemNullableJsonConverter(),
                    new global::G.JsonConverters.MigrationsListForOrgExcludeItemJsonConverter(),
                    new global::G.JsonConverters.MigrationsListForOrgExcludeItemNullableJsonConverter(),
                    new global::G.JsonConverters.MigrationsGetStatusForOrgExcludeItemJsonConverter(),
                    new global::G.JsonConverters.MigrationsGetStatusForOrgExcludeItemNullableJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverterFactory3(),
                }
            };


        /// <summary>
        /// Move projects to or from GitHub.
        /// </summary>
        public MigrationsClient Migrations => new MigrationsClient(_httpClient, authorizations: _authorizations)
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