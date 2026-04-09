//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Hume AI API for emotion recognition, expression measurement, empathic voice interface (EVI), and text-to-speech (TTS).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Production
        /// </summary>
        public const string DefaultBaseUrl = "https://api.hume.ai/";

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
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.ProsodyModelConfigGranularityJsonConverter(),
                    new global::G.JsonConverters.ProsodyModelConfigGranularityNullableJsonConverter(),
                    new global::G.JsonConverters.LanguageModelConfigGranularityJsonConverter(),
                    new global::G.JsonConverters.LanguageModelConfigGranularityNullableJsonConverter(),
                    new global::G.JsonConverters.InferenceJobTypeJsonConverter(),
                    new global::G.JsonConverters.InferenceJobTypeNullableJsonConverter(),
                    new global::G.JsonConverters.JobStateStatusJsonConverter(),
                    new global::G.JsonConverters.JobStateStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SourceTypeJsonConverter(),
                    new global::G.JsonConverters.SourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PostedUtteranceVoiceProviderJsonConverter(),
                    new global::G.JsonConverters.PostedUtteranceVoiceProviderNullableJsonConverter(),
                    new global::G.JsonConverters.AudioFormatTypeJsonConverter(),
                    new global::G.JsonConverters.AudioFormatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnVoiceProviderJsonConverter(),
                    new global::G.JsonConverters.ReturnVoiceProviderNullableJsonConverter(),
                    new global::G.JsonConverters.PostedLanguageModelModelProviderJsonConverter(),
                    new global::G.JsonConverters.PostedLanguageModelModelProviderNullableJsonConverter(),
                    new global::G.JsonConverters.PostedBuiltinToolNameJsonConverter(),
                    new global::G.JsonConverters.PostedBuiltinToolNameNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnToolItemToolTypeJsonConverter(),
                    new global::G.JsonConverters.ReturnToolItemToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnUserDefinedToolToolTypeJsonConverter(),
                    new global::G.JsonConverters.ReturnUserDefinedToolToolTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnChatStatusJsonConverter(),
                    new global::G.JsonConverters.ReturnChatStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnPagedChatsPaginationDirectionJsonConverter(),
                    new global::G.JsonConverters.ReturnPagedChatsPaginationDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnChatEventRoleJsonConverter(),
                    new global::G.JsonConverters.ReturnChatEventRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnChatEventTypeJsonConverter(),
                    new global::G.JsonConverters.ReturnChatEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnChatPagedEventsPaginationDirectionJsonConverter(),
                    new global::G.JsonConverters.ReturnChatPagedEventsPaginationDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnChatAudioReconstructionStatusJsonConverter(),
                    new global::G.JsonConverters.ReturnChatAudioReconstructionStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnPagedChatGroupsPaginationDirectionJsonConverter(),
                    new global::G.JsonConverters.ReturnPagedChatGroupsPaginationDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnChatGroupPagedChatsPaginationDirectionJsonConverter(),
                    new global::G.JsonConverters.ReturnChatGroupPagedChatsPaginationDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnChatGroupPagedEventsPaginationDirectionJsonConverter(),
                    new global::G.JsonConverters.ReturnChatGroupPagedEventsPaginationDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ReturnChatGroupPagedAudioReconstructionsPaginationDirectionJsonConverter(),
                    new global::G.JsonConverters.ReturnChatGroupPagedAudioReconstructionsPaginationDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ListBatchJobsStatusJsonConverter(),
                    new global::G.JsonConverters.ListBatchJobsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ListBatchJobsSortByJsonConverter(),
                    new global::G.JsonConverters.ListBatchJobsSortByNullableJsonConverter(),
                    new global::G.JsonConverters.ListBatchJobsDirectionJsonConverter(),
                    new global::G.JsonConverters.ListBatchJobsDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ListVoicesProviderJsonConverter(),
                    new global::G.JsonConverters.ListVoicesProviderNullableJsonConverter(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public BatchClient Batch => new BatchClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatGroupsClient ChatGroups => new ChatGroupsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatsClient Chats => new ChatsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ConfigsClient Configs => new ConfigsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EviToolsClient EviTools => new EviToolsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TtsClient Tts => new TtsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VoicesClient Voices => new VoicesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
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