//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Our REST API provides seamless access to Tavily Search, a powerful search engine for LLM agents, and Tavily Extract, an advanced web scraping solution optimized for LLMs.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.tavily.com/";

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
                    new global::G.JsonConverters.ResearchTaskCompletedStatusJsonConverter(),
                    new global::G.JsonConverters.ResearchTaskCompletedStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ResearchTaskFailedStatusJsonConverter(),
                    new global::G.JsonConverters.ResearchTaskFailedStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSearchRequestSearchDepthJsonConverter(),
                    new global::G.JsonConverters.CreateSearchRequestSearchDepthNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSearchRequestTopicJsonConverter(),
                    new global::G.JsonConverters.CreateSearchRequestTopicNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSearchRequestTimeRangeJsonConverter(),
                    new global::G.JsonConverters.CreateSearchRequestTimeRangeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSearchRequestIncludeAnswerJsonConverter(),
                    new global::G.JsonConverters.CreateSearchRequestIncludeAnswerNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSearchRequestIncludeRawContentJsonConverter(),
                    new global::G.JsonConverters.CreateSearchRequestIncludeRawContentNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSearchRequestCountryJsonConverter(),
                    new global::G.JsonConverters.CreateSearchRequestCountryNullableJsonConverter(),
                    new global::G.JsonConverters.CreateExtractRequestExtractDepthJsonConverter(),
                    new global::G.JsonConverters.CreateExtractRequestExtractDepthNullableJsonConverter(),
                    new global::G.JsonConverters.CreateExtractRequestFormatJsonConverter(),
                    new global::G.JsonConverters.CreateExtractRequestFormatNullableJsonConverter(),
                    new global::G.JsonConverters.CreateCrawlRequestExtractDepthJsonConverter(),
                    new global::G.JsonConverters.CreateCrawlRequestExtractDepthNullableJsonConverter(),
                    new global::G.JsonConverters.CreateCrawlRequestFormatJsonConverter(),
                    new global::G.JsonConverters.CreateCrawlRequestFormatNullableJsonConverter(),
                    new global::G.JsonConverters.CreateResearchRequestModelJsonConverter(),
                    new global::G.JsonConverters.CreateResearchRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateResearchRequestOutputSchemaPropertiesTypeJsonConverter(),
                    new global::G.JsonConverters.CreateResearchRequestOutputSchemaPropertiesTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateResearchRequestCitationFormatJsonConverter(),
                    new global::G.JsonConverters.CreateResearchRequestCitationFormatNullableJsonConverter(),
                    new global::G.JsonConverters.GetResearchResponseDiscriminatorStatusJsonConverter(),
                    new global::G.JsonConverters.GetResearchResponseDiscriminatorStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetResearchResponseStatusJsonConverter(),
                    new global::G.JsonConverters.GetResearchResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetResearchResponseJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, object>(),
                    new global::G.JsonConverters.OneOfJsonConverter<bool?, global::G.CreateSearchRequestIncludeAnswer?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<bool?, global::G.CreateSearchRequestIncludeRawContent?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


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