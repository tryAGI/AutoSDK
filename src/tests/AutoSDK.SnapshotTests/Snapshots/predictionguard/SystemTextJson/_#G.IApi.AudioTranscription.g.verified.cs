//HintName: G.IApi.AudioTranscription.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Audio Transcription<br/>
        /// This endpoint allows you to transcribe audio.
        /// </summary>
        /// <param name="toxicity"></param>
        /// <param name="pii"></param>
        /// <param name="replaceMethod"></param>
        /// <param name="entityList"></param>
        /// <param name="injection"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AudioTranscriptionResponse200> AudioTranscriptionAsync(

            global::G.AudioTranscriptionRequest request,
            bool? toxicity = default,
            string? pii = default,
            string? replaceMethod = default,
            global::System.Collections.Generic.IList<string>? entityList = default,
            bool? injection = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Audio Transcription<br/>
        /// This endpoint allows you to transcribe audio.
        /// </summary>
        /// <param name="toxicity"></param>
        /// <param name="pii"></param>
        /// <param name="replaceMethod"></param>
        /// <param name="entityList"></param>
        /// <param name="injection"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AudioTranscriptionResponse200> AudioTranscriptionAsync(
            string model,
            byte[] file,
            string filename,
            bool? toxicity = default,
            string? pii = default,
            string? replaceMethod = default,
            global::System.Collections.Generic.IList<string>? entityList = default,
            bool? injection = default,
            string? language = default,
            string? prompt = default,
            double? temperature = default,
            global::G.AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities? timestampsGranularities = default,
            bool? diarization = default,
            string? responseFormat = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}