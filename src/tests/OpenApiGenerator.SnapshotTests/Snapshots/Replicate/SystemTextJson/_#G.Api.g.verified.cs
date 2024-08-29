//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A web service for running Replicate models<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
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
                    new global::OpenApiGenerator.JsonConverters.PredictionRequestWebhookEventsFilterItemJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PredictionRequestWebhookEventsFilterItemNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TrainingRequestWebhookEventsFilterItemJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TrainingRequestWebhookEventsFilterItemNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModelsCreateRequestVisibilityJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ModelsCreateRequestVisibilityNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AccountGetResponseTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AccountGetResponseTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeploymentsListResponseResultCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeploymentsListResponseResultCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeploymentsGetResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeploymentsGetResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
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