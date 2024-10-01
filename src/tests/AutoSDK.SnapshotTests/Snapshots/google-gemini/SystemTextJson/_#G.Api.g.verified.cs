//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Gemini API allows developers to build generative AI applications using Gemini models. Gemini is our most capable model, built from the ground up to be multimodal. It can generalize and seamlessly understand, operate across, and combine different types of information. including language, images, audio, video, and code. You can use the Gemini API for use cases like reasoning across text and images, content generation, dialogue agents, summarization and classification systems, and more.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://generativelanguage.googleapis.com/v1";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::G.EndPointAuthorization? _authorization;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.CandidateFinishReasonJsonConverter(),
                    new global::G.JsonConverters.CandidateFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.SafetyRatingCategoryJsonConverter(),
                    new global::G.JsonConverters.SafetyRatingCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.SafetyRatingProbabilityJsonConverter(),
                    new global::G.JsonConverters.SafetyRatingProbabilityNullableJsonConverter(),
                    new global::G.JsonConverters.EmbedContentRequestTaskTypeJsonConverter(),
                    new global::G.JsonConverters.EmbedContentRequestTaskTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SafetySettingCategoryJsonConverter(),
                    new global::G.JsonConverters.SafetySettingCategoryNullableJsonConverter(),
                    new global::G.JsonConverters.SafetySettingThresholdJsonConverter(),
                    new global::G.JsonConverters.SafetySettingThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.PromptFeedbackBlockReasonJsonConverter(),
                    new global::G.JsonConverters.PromptFeedbackBlockReasonNullableJsonConverter(),
                }
            };


        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="authorization"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::G.EndPointAuthorization? authorization = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorization = authorization;

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