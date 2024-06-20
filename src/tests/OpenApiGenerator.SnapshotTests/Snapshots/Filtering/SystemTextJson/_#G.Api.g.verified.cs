//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GitHub's v3 REST API.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.github.com";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// Move projects to or from GitHub.
        /// </summary>
        public MigrationsClient Migrations => new MigrationsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="jsonSerializerOptions"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _jsonSerializerOptions = _jsonSerializerOptions ?? new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::OpenApiGenerator.JsonConverters.RepositorySquashMergeCommitTitleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RepositorySquashMergeCommitTitleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RepositorySquashMergeCommitMessageJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RepositorySquashMergeCommitMessageNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RepositoryMergeCommitTitleJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RepositoryMergeCommitTitleNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RepositoryMergeCommitMessageJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RepositoryMergeCommitMessageNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SecurityAndAnalysisAdvancedSecurityStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SecurityAndAnalysisAdvancedSecurityStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SecurityAndAnalysisDependabotSecurityUpdatesStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SecurityAndAnalysisDependabotSecurityUpdatesStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SecurityAndAnalysisSecretScanningStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SecurityAndAnalysisSecretScanningStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SecurityAndAnalysisSecretScanningPushProtectionStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SecurityAndAnalysisSecretScanningPushProtectionStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ImportStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ImportStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PagesHttpsCertificateStateJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PagesHttpsCertificateStateNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PageStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PageStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PageProtectedDomainStateJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PageProtectedDomainStateNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PageBuildTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PageBuildTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsListForOrgExcludeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsListForOrgExcludeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsStartForOrgRequestExcludeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsStartForOrgRequestExcludeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsGetStatusForOrgExcludeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsGetStatusForOrgExcludeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsStartImportRequestVcsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsStartImportRequestVcsNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsUpdateImportRequestVcsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsUpdateImportRequestVcsNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsSetLfsPreferenceRequestUseLfsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsSetLfsPreferenceRequestUseLfsNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsStartForAuthenticatedUserRequestExcludeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.MigrationsStartForAuthenticatedUserRequestExcludeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory3(),
                }
            };
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}