//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Speechmatics Automatic Speech Recognition REST API is used to submit ASR jobs and receive the results. The supported job type is transcription of audio files.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://asr.api.speechmatics.com/v2";

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
                    new global::G.JsonConverters.ErrorResponseErrorJsonConverter(),
                    new global::G.JsonConverters.ErrorResponseErrorNullableJsonConverter(),
                    new global::G.JsonConverters.TranslationErrorTypeJsonConverter(),
                    new global::G.JsonConverters.TranslationErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SummarizationErrorTypeJsonConverter(),
                    new global::G.JsonConverters.SummarizationErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SentimentAnalysisErrorTypeJsonConverter(),
                    new global::G.JsonConverters.SentimentAnalysisErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TopicDetectionErrorTypeJsonConverter(),
                    new global::G.JsonConverters.TopicDetectionErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AutoChaptersResultErrorTypeJsonConverter(),
                    new global::G.JsonConverters.AutoChaptersResultErrorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptionConfigDiarizationJsonConverter(),
                    new global::G.JsonConverters.TranscriptionConfigDiarizationNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptionConfigMaxDelayModeJsonConverter(),
                    new global::G.JsonConverters.TranscriptionConfigMaxDelayModeNullableJsonConverter(),
                    new global::G.JsonConverters.NotificationConfigContentJsonConverter(),
                    new global::G.JsonConverters.NotificationConfigContentNullableJsonConverter(),
                    new global::G.JsonConverters.NotificationConfigMethodJsonConverter(),
                    new global::G.JsonConverters.NotificationConfigMethodNullableJsonConverter(),
                    new global::G.JsonConverters.LanguagePackInfoWritingDirectionJsonConverter(),
                    new global::G.JsonConverters.LanguagePackInfoWritingDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.JobTypeJsonConverter(),
                    new global::G.JsonConverters.JobTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LanguageIdentificationConfigLowConfidenceActionJsonConverter(),
                    new global::G.JsonConverters.LanguageIdentificationConfigLowConfidenceActionNullableJsonConverter(),
                    new global::G.JsonConverters.SummarizationConfigContentTypeJsonConverter(),
                    new global::G.JsonConverters.SummarizationConfigContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SummarizationConfigSummaryLengthJsonConverter(),
                    new global::G.JsonConverters.SummarizationConfigSummaryLengthNullableJsonConverter(),
                    new global::G.JsonConverters.SummarizationConfigSummaryTypeJsonConverter(),
                    new global::G.JsonConverters.SummarizationConfigSummaryTypeNullableJsonConverter(),
                    new global::G.JsonConverters.JobDetailsStatusJsonConverter(),
                    new global::G.JsonConverters.JobDetailsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.RecognitionDisplayDirectionJsonConverter(),
                    new global::G.JsonConverters.RecognitionDisplayDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.RecognitionResultTypeJsonConverter(),
                    new global::G.JsonConverters.RecognitionResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RecognitionResultAttachesToJsonConverter(),
                    new global::G.JsonConverters.RecognitionResultAttachesToNullableJsonConverter(),
                    new global::G.JsonConverters.WrittenFormRecognitionResultTypeJsonConverter(),
                    new global::G.JsonConverters.WrittenFormRecognitionResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SpokenFormRecognitionResultTypeJsonConverter(),
                    new global::G.JsonConverters.SpokenFormRecognitionResultTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LanguageIdentificationResultErrorJsonConverter(),
                    new global::G.JsonConverters.LanguageIdentificationResultErrorNullableJsonConverter(),
                    new global::G.JsonConverters.OperatingPointJsonConverter(),
                    new global::G.JsonConverters.OperatingPointNullableJsonConverter(),
                    new global::G.JsonConverters.JobModeJsonConverter(),
                    new global::G.JsonConverters.JobModeNullableJsonConverter(),
                    new global::G.JsonConverters.GetJobsTranscriptFormatJsonConverter(),
                    new global::G.JsonConverters.GetJobsTranscriptFormatNullableJsonConverter(),
                    new global::G.JsonConverters.GetJobsAlignmentTagsJsonConverter(),
                    new global::G.JsonConverters.GetJobsAlignmentTagsNullableJsonConverter(),
                    new global::G.JsonConverters.GetJobsObjectUrlsUrlForItemJsonConverter(),
                    new global::G.JsonConverters.GetJobsObjectUrlsUrlForItemNullableJsonConverter(),
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