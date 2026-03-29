//HintName: G.IApi.TranslateSpeech.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Transcribe and translate speech to English<br/>
        /// Combines speech recognition and translation in a single step.<br/>
        /// Converts spoken Indian language directly into English text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpeechToTextTranslateResponse> TranslateSpeechAsync(

            global::G.TranslateSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe and translate speech to English<br/>
        /// Combines speech recognition and translation in a single step.<br/>
        /// Converts spoken Indian language directly into English text.
        /// </summary>
        /// <param name="file">
        /// Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)
        /// </param>
        /// <param name="filename">
        /// Audio file (WAV, MP3, AAC, AIFF, OGG, OPUS, FLAC, MP4/M4A, AMR, WMA, WebM, PCM)
        /// </param>
        /// <param name="model">
        /// Speech-to-text model<br/>
        /// Default Value: saaras:v3
        /// </param>
        /// <param name="languageCode">
        /// Language of the audio (BCP-47)
        /// </param>
        /// <param name="inputAudioCodec">
        /// Required for PCM format files
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpeechToTextTranslateResponse> TranslateSpeechAsync(
            byte[] file,
            string filename,
            global::G.TranslateSpeechRequestModel? model = default,
            global::G.TranslateSpeechRequestLanguageCode? languageCode = default,
            global::G.TranslateSpeechRequestInputAudioCodec? inputAudioCodec = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}