//HintName: G.Models.AudioTranscriptionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionRequest
    {
        /// <summary>
        /// The transcription model to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The audio file to upload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// The audio file to upload.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The language the audio is in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// An optional text to guide the model's style or continue a previous audio segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The temperature parameter for controlling randomness in transcription. Supports a range of 0.0-2.0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Sets whether timestamps are returned and at what granularity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamps_granularities[]")]
        public global::G.AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities? TimestampsGranularities { get; set; }

        /// <summary>
        /// Whether to diarize the audio and return speaker turns. Not currently supported in multi-tenant environments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diarization")]
        public bool? Diarization { get; set; }

        /// <summary>
        /// The format for the response object. Defaults to "json" and must be set to "verbose_json" when using diarization or timestamp granularities.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_format")]
        public string? ResponseFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The transcription model to use.
        /// </param>
        /// <param name="file">
        /// The audio file to upload.
        /// </param>
        /// <param name="filename">
        /// The audio file to upload.
        /// </param>
        /// <param name="language">
        /// The language the audio is in.
        /// </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio segment.
        /// </param>
        /// <param name="temperature">
        /// The temperature parameter for controlling randomness in transcription. Supports a range of 0.0-2.0.
        /// </param>
        /// <param name="timestampsGranularities">
        /// Sets whether timestamps are returned and at what granularity.
        /// </param>
        /// <param name="diarization">
        /// Whether to diarize the audio and return speaker turns. Not currently supported in multi-tenant environments.
        /// </param>
        /// <param name="responseFormat">
        /// The format for the response object. Defaults to "json" and must be set to "verbose_json" when using diarization or timestamp granularities.
        /// </param>
        public AudioTranscriptionRequest(
            string model,
            byte[] file,
            string filename,
            string? language,
            string? prompt,
            double? temperature,
            global::G.AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities? timestampsGranularities,
            bool? diarization,
            string? responseFormat)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Language = language;
            this.Prompt = prompt;
            this.Temperature = temperature;
            this.TimestampsGranularities = timestampsGranularities;
            this.Diarization = diarization;
            this.ResponseFormat = responseFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionRequest" /> class.
        /// </summary>
        public AudioTranscriptionRequest()
        {
        }
    }
}