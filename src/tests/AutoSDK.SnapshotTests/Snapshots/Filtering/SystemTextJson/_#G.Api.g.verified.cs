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
                    new global::AutoSDK.JsonConverters.RepositorySquashMergeCommitTitleJsonConverter(),
                    new global::AutoSDK.JsonConverters.RepositorySquashMergeCommitTitleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RepositorySquashMergeCommitMessageJsonConverter(),
                    new global::AutoSDK.JsonConverters.RepositorySquashMergeCommitMessageNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RepositoryMergeCommitTitleJsonConverter(),
                    new global::AutoSDK.JsonConverters.RepositoryMergeCommitTitleNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RepositoryMergeCommitMessageJsonConverter(),
                    new global::AutoSDK.JsonConverters.RepositoryMergeCommitMessageNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SecurityAndAnalysisAdvancedSecurityStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.SecurityAndAnalysisAdvancedSecurityStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SecurityAndAnalysisDependabotSecurityUpdatesStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.SecurityAndAnalysisDependabotSecurityUpdatesStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SecurityAndAnalysisSecretScanningStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.SecurityAndAnalysisSecretScanningStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SecurityAndAnalysisSecretScanningPushProtectionStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.SecurityAndAnalysisSecretScanningPushProtectionStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ImportStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.ImportStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsStartForOrgRequestExcludeItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsStartForOrgRequestExcludeItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsStartImportRequestVcsJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsStartImportRequestVcsNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsUpdateImportRequestVcsJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsUpdateImportRequestVcsNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsSetLfsPreferenceRequestUseLfsJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsSetLfsPreferenceRequestUseLfsNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsStartForAuthenticatedUserRequestExcludeItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsStartForAuthenticatedUserRequestExcludeItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsListForOrgExcludeItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsListForOrgExcludeItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsGetStatusForOrgExcludeItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.MigrationsGetStatusForOrgExcludeItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory3(),
                }
            };

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