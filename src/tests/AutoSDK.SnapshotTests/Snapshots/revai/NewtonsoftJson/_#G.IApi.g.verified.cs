//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rev.ai provides quality speech-to-text recognition, sentiment analysis, topic extraction, <br/>
    /// and language identification via a RESTful API. All APIs use Bearer token authentication.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// Account information
        /// </summary>
        public AccountClient Account { get; }

        /// <summary>
        /// Retrieve caption output (SRT/VTT)
        /// </summary>
        public CaptionsClient Captions { get; }

        /// <summary>
        /// Language identification from audio
        /// </summary>
        public LanguageIdentificationJobsClient LanguageIdentificationJobs { get; }

        /// <summary>
        /// Retrieve language identification results
        /// </summary>
        public LanguageIdentificationResultsClient LanguageIdentificationResults { get; }

        /// <summary>
        /// Sentiment analysis on text or transcripts
        /// </summary>
        public SentimentAnalysisJobsClient SentimentAnalysisJobs { get; }

        /// <summary>
        /// Retrieve sentiment analysis results
        /// </summary>
        public SentimentAnalysisResultsClient SentimentAnalysisResults { get; }

        /// <summary>
        /// Topic extraction from text or transcripts
        /// </summary>
        public TopicExtractionJobsClient TopicExtractionJobs { get; }

        /// <summary>
        /// Retrieve topic extraction results
        /// </summary>
        public TopicExtractionResultsClient TopicExtractionResults { get; }

        /// <summary>
        /// Retrieve transcription results
        /// </summary>
        public TranscriptClient Transcript { get; }

        /// <summary>
        /// Async speech-to-text transcription
        /// </summary>
        public TranscriptionJobsClient TranscriptionJobs { get; }

    }
}