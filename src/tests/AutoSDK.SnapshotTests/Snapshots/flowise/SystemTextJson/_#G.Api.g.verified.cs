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
                    new global::G.JsonConverters.ChatMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ChatMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageChatTypeJsonConverter(),
                    new global::G.JsonConverters.ChatMessageChatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatflowTypeJsonConverter(),
                    new global::G.JsonConverters.ChatflowTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PredictionHistoryItemRoleJsonConverter(),
                    new global::G.JsonConverters.PredictionHistoryItemRoleNullableJsonConverter(),
                    new global::G.JsonConverters.PredictionUploadTypeJsonConverter(),
                    new global::G.JsonConverters.PredictionUploadTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PredictionUploadMimeJsonConverter(),
                    new global::G.JsonConverters.PredictionUploadMimeNullableJsonConverter(),
                    new global::G.JsonConverters.PredictionHumanInputTypeJsonConverter(),
                    new global::G.JsonConverters.PredictionHumanInputTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DocumentStoreStatusJsonConverter(),
                    new global::G.JsonConverters.DocumentStoreStatusNullableJsonConverter(),
                    new global::G.JsonConverters.DocumentStoreLoaderForPreviewStatusJsonConverter(),
                    new global::G.JsonConverters.DocumentStoreLoaderForPreviewStatusNullableJsonConverter(),
                    new global::G.JsonConverters.DocumentStoreLoaderFileStatusJsonConverter(),
                    new global::G.JsonConverters.DocumentStoreLoaderFileStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageFeedbackRatingJsonConverter(),
                    new global::G.JsonConverters.ChatMessageFeedbackRatingNullableJsonConverter(),
                    new global::G.JsonConverters.GetAllChatMessagesChatTypeJsonConverter(),
                    new global::G.JsonConverters.GetAllChatMessagesChatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetAllChatMessagesOrderJsonConverter(),
                    new global::G.JsonConverters.GetAllChatMessagesOrderNullableJsonConverter(),
                    new global::G.JsonConverters.GetAllChatMessagesFeedbackTypeJsonConverter(),
                    new global::G.JsonConverters.GetAllChatMessagesFeedbackTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RemoveAllChatMessagesChatTypeJsonConverter(),
                    new global::G.JsonConverters.RemoveAllChatMessagesChatTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RemoveAllChatMessagesFeedbackTypeJsonConverter(),
                    new global::G.JsonConverters.RemoveAllChatMessagesFeedbackTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetAllChatMessageFeedbackSortOrderJsonConverter(),
                    new global::G.JsonConverters.GetAllChatMessageFeedbackSortOrderNullableJsonConverter(),
                    new global::G.JsonConverters.GetAllUpsertHistoryOrderJsonConverter(),
                    new global::G.JsonConverters.GetAllUpsertHistoryOrderNullableJsonConverter(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public AssistantsClient Assistants => new AssistantsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AttachmentsClient Attachments => new AttachmentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatflowsClient Chatflows => new ChatflowsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChatmessageClient Chatmessage => new ChatmessageClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DocumentStoreClient DocumentStore => new DocumentStoreClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeedbackClient Feedback => new FeedbackClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LeadsClient Leads => new LeadsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PingClient Ping => new PingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PredictionClient Prediction => new PredictionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools => new ToolsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UpsertHistoryClient UpsertHistory => new UpsertHistoryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VariablesClient Variables => new VariablesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VectorClient Vector => new VectorClient(HttpClient, authorizations: Authorizations)
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