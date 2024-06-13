//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A web service for running Replicate models
    /// If no httpClient is provided, a new one will be created.
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.replicate.com/v1";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
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
                    new global::OpenApiGenerator.JsonConverters.PredictionRequestWebhookEventsFilterJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PredictionRequestWebhookEventsFilterNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TrainingRequestWebhookEventsFilterJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TrainingRequestWebhookEventsFilterNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VersionPredictionRequestWebhookEventsFilterJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VersionPredictionRequestWebhookEventsFilterNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetAccountResponseTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetAccountResponseTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListDeploymentsResponseResultsCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListDeploymentsResponseResultsCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateDeploymentsResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateDeploymentsResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetDeploymentsResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.GetDeploymentsResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateDeploymentsResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UpdateDeploymentsResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModelsRequestVisibilityJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateModelsRequestVisibilityNullableJsonConverter(),
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