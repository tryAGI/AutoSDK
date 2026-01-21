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
        public const string DefaultBaseUrl = "";

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
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.SuspendReasonJsonConverter(),
                    new global::G.JsonConverters.SuspendReasonNullableJsonConverter(),
                    new global::G.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2JsonConverter(),
                    new global::G.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostResponseFormat2NullableJsonConverter(),
                    new global::G.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitiesVariant1ItemJsonConverter(),
                    new global::G.JsonConverters.BodyOpenaiAudioTranscriptionsV1OpenaiAudioTranscriptionsPostTimestampGranularitiesVariant1ItemNullableJsonConverter(),
                    new global::G.JsonConverters.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2JsonConverter(),
                    new global::G.JsonConverters.BodyOpenaiAudioTranslationsV1OpenaiAudioTranslationsPostResponseFormat2NullableJsonConverter(),
                    new global::G.JsonConverters.InputAudioFormatJsonConverter(),
                    new global::G.JsonConverters.InputAudioFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ImageURLDetailJsonConverter(),
                    new global::G.JsonConverters.ImageURLDetailNullableJsonConverter(),
                    new global::G.JsonConverters.SourceTypeEnumJsonConverter(),
                    new global::G.JsonConverters.SourceTypeEnumNullableJsonConverter(),
                    new global::G.JsonConverters.DeployGPUsJsonConverter(),
                    new global::G.JsonConverters.DeployGPUsNullableJsonConverter(),
                    new global::G.JsonConverters.ModelProviderJsonConverter(),
                    new global::G.JsonConverters.ModelProviderNullableJsonConverter(),
                    new global::G.JsonConverters.DeployTypeJsonConverter(),
                    new global::G.JsonConverters.DeployTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TtsResponseFormatJsonConverter(),
                    new global::G.JsonConverters.TtsResponseFormatNullableJsonConverter(),
                    new global::G.JsonConverters.HFTasksEJsonConverter(),
                    new global::G.JsonConverters.HFTasksENullableJsonConverter(),
                    new global::G.JsonConverters.ModelDocBlockKeyJsonConverter(),
                    new global::G.JsonConverters.ModelDocBlockKeyNullableJsonConverter(),
                    new global::G.JsonConverters.SchemaVariantKeyJsonConverter(),
                    new global::G.JsonConverters.SchemaVariantKeyNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAIBatchesInEndpointJsonConverter(),
                    new global::G.JsonConverters.OpenAIBatchesInEndpointNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.OpenAIChatCompletionsInReasoningEffort2JsonConverter(),
                    new global::G.JsonConverters.OpenAIChatCompletionsInReasoningEffort2NullableJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ChatCompletionContentPartText>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.ChatCompletionContentPartText, global::G.ChatCompletionContentPartImage, global::G.ChatCompletionContentPartAudio>>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ChatCompletionContentPartText, global::G.ChatCompletionContentPartImage, global::G.ChatCompletionContentPartAudio>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ModelPricingTime, global::G.ModelPricingUptime, global::G.ModelPricingTokens, global::G.ModelPricingInputLength, global::G.ModelPricingInputTokens, global::G.ModelPricingInputCharacterLength, global::G.ModelPricingImageUnits>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ModelPricingTime, global::G.ModelPricingTokens, global::G.ModelPricingInputLength, global::G.ModelPricingInputTokens, global::G.ModelPricingUptime, global::G.ModelPricingInputCharacterLength, global::G.ModelPricingImageUnits>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ChatCompletionToolMessage, global::G.ChatCompletionAssistantMessage, global::G.ChatCompletionUserMessage, global::G.ChatCompletionSystemMessage>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
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