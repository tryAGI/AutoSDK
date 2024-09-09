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
                    new global::AutoSDK.JsonConverters.PredictionRequestWebhookEventsFilterItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.PredictionRequestWebhookEventsFilterItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.TrainingRequestWebhookEventsFilterItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.TrainingRequestWebhookEventsFilterItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemJsonConverter(),
                    new global::AutoSDK.JsonConverters.VersionPredictionRequestWebhookEventsFilterItemNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ModelsCreateRequestVisibilityJsonConverter(),
                    new global::AutoSDK.JsonConverters.ModelsCreateRequestVisibilityNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AccountGetResponseTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.AccountGetResponseTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeploymentsListResponseResultCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeploymentsListResponseResultCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeploymentsCreateResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeploymentsGetResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeploymentsGetResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.DeploymentsUpdateResponseCurrentReleaseCreatedByTypeNullableJsonConverter(),
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