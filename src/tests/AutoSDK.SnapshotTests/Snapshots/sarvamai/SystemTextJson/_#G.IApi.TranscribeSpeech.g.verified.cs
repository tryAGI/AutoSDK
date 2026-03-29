//HintName: G.IApi.TranscribeSpeech.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Transcribe speech to text<br/>
        /// Converts spoken language into written text. Supports multiple modes<br/>
        /// including transcribe, translate, verbatim, translit, and codemix.<br/>
        /// Audio files up to 30 seconds for synchronous processing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpeechToTextResponse> TranscribeSpeechAsync(

            global::G.TranscribeSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe speech to text<br/>
        /// Converts spoken language into written text. Supports multiple modes<br/>
        /// including transcribe, translate, verbatim, translit, and codemix.<br/>
        /// Audio files up to 30 seconds for synchronous processing.
        /// </summary>
        /// <param name="file">
        /// Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)
        /// </param>
        /// <param name="filename">
        /// Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)
        /// </param>
        /// <param name="model">
        /// Speech-to-text model<br/>
        /// Default Value: saarika:v2.5
        /// </param>
        /// <param name="mode">
        /// Operation mode (saaras:v3 only)<br/>
        /// Default Value: transcribe
        /// </param>
        /// <param name="languageCode">
        /// Language of the audio (BCP-47). Optional for saarika:v2.5.
        /// </param>
        /// <param name="inputAudioCodec">
        /// Required for PCM format files
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpeechToTextResponse> TranscribeSpeechAsync(
            byte[] file,
            string filename,
            global::G.TranscribeSpeechRequestModel? model = default,
            global::G.TranscribeSpeechRequestMode? mode = default,
            global::G.TranscribeSpeechRequestLanguageCode? languageCode = default,
            global::G.TranscribeSpeechRequestInputAudioCodec? inputAudioCodec = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}