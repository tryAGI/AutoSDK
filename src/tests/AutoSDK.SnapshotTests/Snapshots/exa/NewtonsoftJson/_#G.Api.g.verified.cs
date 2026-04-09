//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A comprehensive API for internet-scale search, allowing users to perform queries and retrieve results from a wide variety of sources using embeddings-based and traditional search.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.exa.ai/";

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
                    new global::G.JsonConverters.ContentsRequestLivecrawlJsonConverter(),

                    new global::G.JsonConverters.ContentsRequestLivecrawlNullableJsonConverter(),

                    new global::G.JsonConverters.CompanyEntityTypeJsonConverter(),

                    new global::G.JsonConverters.CompanyEntityTypeNullableJsonConverter(),

                    new global::G.JsonConverters.PersonEntityTypeJsonConverter(),

                    new global::G.JsonConverters.PersonEntityTypeNullableJsonConverter(),

                    new global::G.JsonConverters.EntityDiscriminatorTypeJsonConverter(),

                    new global::G.JsonConverters.EntityDiscriminatorTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchCreateRequestDtoClassModelJsonConverter(),

                    new global::G.JsonConverters.ResearchCreateRequestDtoClassModelNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant1ModelJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant1ModelNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant1StatusJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant1StatusNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant2ModelJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant2ModelNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant2StatusJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant2StatusNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant3ModelJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant3ModelNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant3StatusJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant3StatusNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant4ModelJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant4ModelNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant4StatusJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant4StatusNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant5ModelJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant5ModelNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant5StatusJsonConverter(),

                    new global::G.JsonConverters.ResearchDtoClassVariant5StatusNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchOperationDtoClassVariant1TypeJsonConverter(),

                    new global::G.JsonConverters.ResearchOperationDtoClassVariant1TypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchOperationDtoClassVariant2TypeJsonConverter(),

                    new global::G.JsonConverters.ResearchOperationDtoClassVariant2TypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchOperationDtoClassVariant2SearchTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchOperationDtoClassVariant2SearchTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchOperationDtoClassVariant3TypeJsonConverter(),

                    new global::G.JsonConverters.ResearchOperationDtoClassVariant3TypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant1Variant1EventTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant1Variant1EventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant1Variant2EventTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant1Variant2EventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant1Variant2OutputVariant1OutputTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant1Variant2OutputVariant1OutputTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant1Variant2OutputVariant2OutputTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant1Variant2OutputVariant2OutputTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant2Variant1EventTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant2Variant1EventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant2Variant2EventTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant2Variant2EventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant2Variant3EventTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant2Variant3EventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant2Variant3OutputVariant1OutputTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant2Variant3OutputVariant1OutputTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant2Variant3OutputVariant2OutputTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant2Variant3OutputVariant2OutputTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant3Variant1EventTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant3Variant1EventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant3Variant2EventTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant3Variant2EventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant3Variant3EventTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant3Variant3EventTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant3Variant3OutputOutputTypeJsonConverter(),

                    new global::G.JsonConverters.ResearchEventDtoClassVariant3Variant3OutputOutputTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SearchRequestTypeJsonConverter(),

                    new global::G.JsonConverters.SearchRequestTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SearchRequestCategoryJsonConverter(),

                    new global::G.JsonConverters.SearchRequestCategoryNullableJsonConverter(),

                    new global::G.JsonConverters.SearchResponseSearchTypeJsonConverter(),

                    new global::G.JsonConverters.SearchResponseSearchTypeNullableJsonConverter(),

                    new global::G.JsonConverters.GetContentsResponseStatuseStatusJsonConverter(),

                    new global::G.JsonConverters.GetContentsResponseStatuseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.GetContentsResponseStatuseErrorTagJsonConverter(),

                    new global::G.JsonConverters.GetContentsResponseStatuseErrorTagNullableJsonConverter(),

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