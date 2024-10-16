//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Our Chat Completion and Embeddings APIs specification. Create your account on [La Plateforme](https://console.mistral.ai) to get access and read the [docs](https://docs.mistral.ai) to learn how to use it.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Production server
        /// </summary>
        public const string BaseUrl = "https://api.mistral.ai";

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
                    new global::G.JsonConverters.TextChunkTypeJsonConverter(),
                    new global::G.JsonConverters.TextChunkTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ImageURLChunkTypeJsonConverter(),
                    new global::G.JsonConverters.ImageURLChunkTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ContentChunkDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ContentChunkDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UserMessageRoleJsonConverter(),
                    new global::G.JsonConverters.UserMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.AssistantMessageRoleJsonConverter(),
                    new global::G.JsonConverters.AssistantMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ToolTypesJsonConverter(),
                    new global::G.JsonConverters.ToolTypesNullableJsonConverter(),
                    new global::G.JsonConverters.ToolMessageRoleJsonConverter(),
                    new global::G.JsonConverters.ToolMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCompletionRequestMessageDiscriminatorRoleJsonConverter(),
                    new global::G.JsonConverters.AgentsCompletionRequestMessageDiscriminatorRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatsJsonConverter(),
                    new global::G.JsonConverters.ResponseFormatsNullableJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceEnumJsonConverter(),
                    new global::G.JsonConverters.ToolChoiceEnumNullableJsonConverter(),
                    new global::G.JsonConverters.ArchiveFTModelOutObjectJsonConverter(),
                    new global::G.JsonConverters.ArchiveFTModelOutObjectNullableJsonConverter(),
                    new global::G.JsonConverters.BaseModelCardTypeJsonConverter(),
                    new global::G.JsonConverters.BaseModelCardTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.SystemMessageRoleJsonConverter(),
                    new global::G.JsonConverters.SystemMessageRoleNullableJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionRequestMessageDiscriminatorRoleNullableJsonConverter(),
                    new global::G.JsonConverters.CompletionResponseStreamChoiceFinishReasonJsonConverter(),
                    new global::G.JsonConverters.CompletionResponseStreamChoiceFinishReasonNullableJsonConverter(),
                    new global::G.JsonConverters.WandbIntegrationOutTypeJsonConverter(),
                    new global::G.JsonConverters.WandbIntegrationOutTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DetailedJobOutIntegrationDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.DetailedJobOutIntegrationDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuneableModelJsonConverter(),
                    new global::G.JsonConverters.FineTuneableModelNullableJsonConverter(),
                    new global::G.JsonConverters.DetailedJobOutObjectJsonConverter(),
                    new global::G.JsonConverters.DetailedJobOutObjectNullableJsonConverter(),
                    new global::G.JsonConverters.GithubRepositoryOutTypeJsonConverter(),
                    new global::G.JsonConverters.GithubRepositoryOutTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DetailedJobOutRepositorieDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.DetailedJobOutRepositorieDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DetailedJobOutStatusJsonConverter(),
                    new global::G.JsonConverters.DetailedJobOutStatusNullableJsonConverter(),
                    new global::G.JsonConverters.FTModelCardTypeJsonConverter(),
                    new global::G.JsonConverters.FTModelCardTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FTModelOutObjectJsonConverter(),
                    new global::G.JsonConverters.FTModelOutObjectNullableJsonConverter(),
                    new global::G.JsonConverters.FileSchemaPurposeJsonConverter(),
                    new global::G.JsonConverters.FileSchemaPurposeNullableJsonConverter(),
                    new global::G.JsonConverters.SampleTypeJsonConverter(),
                    new global::G.JsonConverters.SampleTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SourceJsonConverter(),
                    new global::G.JsonConverters.SourceNullableJsonConverter(),
                    new global::G.JsonConverters.GithubRepositoryInTypeJsonConverter(),
                    new global::G.JsonConverters.GithubRepositoryInTypeNullableJsonConverter(),
                    new global::G.JsonConverters.WandbIntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.WandbIntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.JobInIntegrationDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.JobInIntegrationDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.JobInRepositorieDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.JobInRepositorieDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.JobOutIntegrationDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.JobOutIntegrationDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.JobOutObjectJsonConverter(),
                    new global::G.JsonConverters.JobOutObjectNullableJsonConverter(),
                    new global::G.JsonConverters.JobOutRepositorieDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.JobOutRepositorieDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.JobOutStatusJsonConverter(),
                    new global::G.JsonConverters.JobOutStatusNullableJsonConverter(),
                    new global::G.JsonConverters.JobsOutObjectJsonConverter(),
                    new global::G.JsonConverters.JobsOutObjectNullableJsonConverter(),
                    new global::G.JsonConverters.LegacyJobMetadataOutObjectJsonConverter(),
                    new global::G.JsonConverters.LegacyJobMetadataOutObjectNullableJsonConverter(),
                    new global::G.JsonConverters.ModelListDataItemDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.ModelListDataItemDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RetrieveFileOutPurposeJsonConverter(),
                    new global::G.JsonConverters.RetrieveFileOutPurposeNullableJsonConverter(),
                    new global::G.JsonConverters.UnarchiveFTModelOutObjectJsonConverter(),
                    new global::G.JsonConverters.UnarchiveFTModelOutObjectNullableJsonConverter(),
                    new global::G.JsonConverters.UploadFileOutPurposeJsonConverter(),
                    new global::G.JsonConverters.UploadFileOutPurposeNullableJsonConverter(),
                    new global::G.JsonConverters.FilesApiRoutesUploadFileRequestPurposeJsonConverter(),
                    new global::G.JsonConverters.FilesApiRoutesUploadFileRequestPurposeNullableJsonConverter(),
                    new global::G.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatusJsonConverter(),
                    new global::G.JsonConverters.JobsApiRoutesFineTuningGetFineTuningJobsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MessagesItemJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::G.JsonConverters.ContentChunkJsonConverter(),
                    new global::G.JsonConverters.MessagesItem2JsonConverter(),
                    new global::G.JsonConverters.ChatCompletionResponseJsonConverter(),
                    new global::G.JsonConverters.ChatCompletionResponseBaseJsonConverter(),
                    new global::G.JsonConverters.IntegrationsItemJsonConverter(),
                    new global::G.JsonConverters.RepositoriesItemJsonConverter(),
                    new global::G.JsonConverters.EmbeddingResponseJsonConverter(),
                    new global::G.JsonConverters.FIMCompletionResponseJsonConverter(),
                    new global::G.JsonConverters.IntegrationsItem2JsonConverter(),
                    new global::G.JsonConverters.RepositoriesItem2JsonConverter(),
                    new global::G.JsonConverters.IntegrationsItem3JsonConverter(),
                    new global::G.JsonConverters.RepositoriesItem3JsonConverter(),
                    new global::G.JsonConverters.DataItemJsonConverter(),
                    new global::G.JsonConverters.RetrieveModelV1ModelsModelIdGetResponseJsonConverter(),
                }
            };


        /// <summary>
        /// Chat Completion API.
        /// </summary>
        public ChatClient Chat => new ChatClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Fill-in-the-middle API.
        /// </summary>
        public FimClient Fim => new FimClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Agents API.
        /// </summary>
        public AgentsClient Agents => new AgentsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Embeddings API.
        /// </summary>
        public EmbeddingsClient Embeddings => new EmbeddingsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Files API
        /// </summary>
        public FilesClient Files => new FilesClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Fine-tuning API
        /// </summary>
        public FineTuningClient FineTuning => new FineTuningClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Model Management API
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient, authorizations: _authorizations)
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