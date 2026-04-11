//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rev.ai provides quality speech-to-text recognition, sentiment analysis, topic extraction, <br/>
    /// and language identification via a RESTful API. All APIs use Bearer token authentication.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Rev.ai API
        /// </summary>
        public const string DefaultBaseUrl = "https://api.rev.ai/";

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
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.TranscriptionJobOptionsLanguageJsonConverter(),
                    new global::G.JsonConverters.TranscriptionJobOptionsLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.SubmitTranscriptionJobRequestLanguageJsonConverter(),
                    new global::G.JsonConverters.SubmitTranscriptionJobRequestLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptionJobStatusJsonConverter(),
                    new global::G.JsonConverters.TranscriptionJobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptionJobTypeJsonConverter(),
                    new global::G.JsonConverters.TranscriptionJobTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptionJobFailureJsonConverter(),
                    new global::G.JsonConverters.TranscriptionJobFailureNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptElementTypeJsonConverter(),
                    new global::G.JsonConverters.TranscriptElementTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SentimentAnalysisJobStatusJsonConverter(),
                    new global::G.JsonConverters.SentimentAnalysisJobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SentimentMessageSentimentJsonConverter(),
                    new global::G.JsonConverters.SentimentMessageSentimentNullableJsonConverter(),
                    new global::G.JsonConverters.TopicExtractionJobStatusJsonConverter(),
                    new global::G.JsonConverters.TopicExtractionJobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.LanguageIdentificationJobStatusJsonConverter(),
                    new global::G.JsonConverters.LanguageIdentificationJobStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetTranscriptAcceptJsonConverter(),
                    new global::G.JsonConverters.GetTranscriptAcceptNullableJsonConverter(),
                    new global::G.JsonConverters.GetCaptionsAcceptJsonConverter(),
                    new global::G.JsonConverters.GetCaptionsAcceptNullableJsonConverter(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Account information.
        /// </summary>
        public AccountClient Account => new AccountClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Retrieve caption output (SRT/VTT).
        /// </summary>
        public CaptionsClient Captions => new CaptionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Language identification from audio.
        /// </summary>
        public LanguageIdentificationJobsClient LanguageIdentificationJobs => new LanguageIdentificationJobsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Retrieve language identification results.
        /// </summary>
        public LanguageIdentificationResultsClient LanguageIdentificationResults => new LanguageIdentificationResultsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Sentiment analysis on text or transcripts.
        /// </summary>
        public SentimentAnalysisJobsClient SentimentAnalysisJobs => new SentimentAnalysisJobsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Retrieve sentiment analysis results.
        /// </summary>
        public SentimentAnalysisResultsClient SentimentAnalysisResults => new SentimentAnalysisResultsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Topic extraction from text or transcripts.
        /// </summary>
        public TopicExtractionJobsClient TopicExtractionJobs => new TopicExtractionJobsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Retrieve topic extraction results.
        /// </summary>
        public TopicExtractionResultsClient TopicExtractionResults => new TopicExtractionResultsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Retrieve transcription results.
        /// </summary>
        public TranscriptClient Transcript => new TranscriptClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Async speech-to-text transcription.
        /// </summary>
        public TranscriptionJobsClient TranscriptionJobs => new TranscriptionJobsClient(HttpClient, authorizations: Authorizations, options: Options)
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