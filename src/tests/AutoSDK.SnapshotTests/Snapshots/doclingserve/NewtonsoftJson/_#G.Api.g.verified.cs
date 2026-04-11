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
        public const string DefaultBaseUrl = "http://localhost:5001/";

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

        /// <inheritdoc/>
        public global::G.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings
            {
                Converters =
                {
                    new global::G.JsonConverters.CodeLanguageLabelJsonConverter(),

                    new global::G.JsonConverters.CodeLanguageLabelNullableJsonConverter(),

                    new global::G.JsonConverters.ContentLayerJsonConverter(),

                    new global::G.JsonConverters.ContentLayerNullableJsonConverter(),

                    new global::G.JsonConverters.ConversionStatusJsonConverter(),

                    new global::G.JsonConverters.ConversionStatusNullableJsonConverter(),

                    new global::G.JsonConverters.ConvertDocumentsRequestSourceDiscriminatorKindJsonConverter(),

                    new global::G.JsonConverters.ConvertDocumentsRequestSourceDiscriminatorKindNullableJsonConverter(),

                    new global::G.JsonConverters.ConvertDocumentsRequestTargetDiscriminatorKindJsonConverter(),

                    new global::G.JsonConverters.ConvertDocumentsRequestTargetDiscriminatorKindNullableJsonConverter(),

                    new global::G.JsonConverters.CoordOriginJsonConverter(),

                    new global::G.JsonConverters.CoordOriginNullableJsonConverter(),

                    new global::G.JsonConverters.DoclingComponentTypeJsonConverter(),

                    new global::G.JsonConverters.DoclingComponentTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GraphCellLabelJsonConverter(),

                    new global::G.JsonConverters.GraphCellLabelNullableJsonConverter(),

                    new global::G.JsonConverters.GraphLinkLabelJsonConverter(),

                    new global::G.JsonConverters.GraphLinkLabelNullableJsonConverter(),

                    new global::G.JsonConverters.GroupLabelJsonConverter(),

                    new global::G.JsonConverters.GroupLabelNullableJsonConverter(),

                    new global::G.JsonConverters.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKindJsonConverter(),

                    new global::G.JsonConverters.HierarchicalChunkerOptionsDocumentsRequestSourceDiscriminatorKindNullableJsonConverter(),

                    new global::G.JsonConverters.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKindJsonConverter(),

                    new global::G.JsonConverters.HierarchicalChunkerOptionsDocumentsRequestTargetDiscriminatorKindNullableJsonConverter(),

                    new global::G.JsonConverters.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKindJsonConverter(),

                    new global::G.JsonConverters.HybridChunkerOptionsDocumentsRequestSourceDiscriminatorKindNullableJsonConverter(),

                    new global::G.JsonConverters.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKindJsonConverter(),

                    new global::G.JsonConverters.HybridChunkerOptionsDocumentsRequestTargetDiscriminatorKindNullableJsonConverter(),

                    new global::G.JsonConverters.ImageRefModeJsonConverter(),

                    new global::G.JsonConverters.ImageRefModeNullableJsonConverter(),

                    new global::G.JsonConverters.InferenceFrameworkJsonConverter(),

                    new global::G.JsonConverters.InferenceFrameworkNullableJsonConverter(),

                    new global::G.JsonConverters.InputFormatJsonConverter(),

                    new global::G.JsonConverters.InputFormatNullableJsonConverter(),

                    new global::G.JsonConverters.OutputFormatJsonConverter(),

                    new global::G.JsonConverters.OutputFormatNullableJsonConverter(),

                    new global::G.JsonConverters.PdfBackendJsonConverter(),

                    new global::G.JsonConverters.PdfBackendNullableJsonConverter(),

                    new global::G.JsonConverters.PictureClassificationLabelJsonConverter(),

                    new global::G.JsonConverters.PictureClassificationLabelNullableJsonConverter(),

                    new global::G.JsonConverters.ProcessingPipelineJsonConverter(),

                    new global::G.JsonConverters.ProcessingPipelineNullableJsonConverter(),

                    new global::G.JsonConverters.ProfilingScopeJsonConverter(),

                    new global::G.JsonConverters.ProfilingScopeNullableJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatJsonConverter(),

                    new global::G.JsonConverters.ResponseFormatNullableJsonConverter(),

                    new global::G.JsonConverters.ScriptJsonConverter(),

                    new global::G.JsonConverters.ScriptNullableJsonConverter(),

                    new global::G.JsonConverters.TableFormerModeJsonConverter(),

                    new global::G.JsonConverters.TableFormerModeNullableJsonConverter(),

                    new global::G.JsonConverters.TargetNameJsonConverter(),

                    new global::G.JsonConverters.TargetNameNullableJsonConverter(),

                    new global::G.JsonConverters.TaskTypeJsonConverter(),

                    new global::G.JsonConverters.TaskTypeNullableJsonConverter(),

                    new global::G.JsonConverters.TransformersModelTypeJsonConverter(),

                    new global::G.JsonConverters.TransformersModelTypeNullableJsonConverter(),

                    new global::G.JsonConverters.VlmEngineTypeJsonConverter(),

                    new global::G.JsonConverters.VlmEngineTypeNullableJsonConverter(),

                    new global::G.JsonConverters.VlmModelTypeJsonConverter(),

                    new global::G.JsonConverters.VlmModelTypeNullableJsonConverter(),

                    new global::G.JsonConverters.OcrEnginesEnumJsonConverter(),

                    new global::G.JsonConverters.OcrEnginesEnumNullableJsonConverter(),

                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public ChunkClient Chunk => new ChunkClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ClearClient Clear => new ClearClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ConvertClient Convert => new ConvertClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public HealthClient Health => new HealthClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ManagementClient Management => new ManagementClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TasksClient Tasks => new TasksClient(HttpClient, authorizations: Authorizations, options: Options)
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
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            global::G.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            Options = options ?? new global::G.AutoSDKClientOptions();
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