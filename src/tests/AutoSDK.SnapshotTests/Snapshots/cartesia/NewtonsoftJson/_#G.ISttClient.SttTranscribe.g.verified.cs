//HintName: G.ISttClient.SttTranscribe.g.cs
#nullable enable

namespace G
{
    public partial interface ISttClient
    {
        /// <summary>
        /// Speech-to-Text (Batch)<br/>
        /// Transcribes audio files into text using Cartesia's Speech-to-Text API.<br/>
        /// Upload an audio file and receive a complete transcription response. Supports arbitrarily long audio files with automatic intelligent chunking for longer audio.<br/>
        /// **Supported audio formats:** flac, m4a, mp3, mp4, mpeg, mpga, oga, ogg, wav, webm<br/>
        /// **Response format:** Returns JSON with transcribed text, duration, and language. Include `timestamp_granularities: ["word"]` to get word-level timestamps.<br/>
        /// **Pricing:** Batch transcription is priced at **1 credit per 2 seconds** of audio processed.<br/>
        /// &lt;Note&gt;<br/>
        /// For migrating from the OpenAI SDK, see our [OpenAI Whisper to Cartesia Ink Migration Guide](/api-reference/stt/migrate-from-open-ai).<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="encoding">
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranscriptionResponse> SttTranscribeAsync(
            global::G.SttTranscribeCartesiaVersion cartesiaVersion,

            global::G.SttTranscribeRequest request,
            global::G.STTEncoding? encoding = default,
            int? sampleRate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Speech-to-Text (Batch)<br/>
        /// Transcribes audio files into text using Cartesia's Speech-to-Text API.<br/>
        /// Upload an audio file and receive a complete transcription response. Supports arbitrarily long audio files with automatic intelligent chunking for longer audio.<br/>
        /// **Supported audio formats:** flac, m4a, mp3, mp4, mpeg, mpga, oga, ogg, wav, webm<br/>
        /// **Response format:** Returns JSON with transcribed text, duration, and language. Include `timestamp_granularities: ["word"]` to get word-level timestamps.<br/>
        /// **Pricing:** Batch transcription is priced at **1 credit per 2 seconds** of audio processed.<br/>
        /// &lt;Note&gt;<br/>
        /// For migrating from the OpenAI SDK, see our [OpenAI Whisper to Cartesia Ink Migration Guide](/api-reference/stt/migrate-from-open-ai).<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="encoding">
        /// The encoding format for audio data sent to the STT WebSocket.
        /// </param>
        /// <param name="sampleRate"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="model">
        /// ID of the model to use for transcription. Use `ink-whisper` for the latest Cartesia Whisper model.
        /// </param>
        /// <param name="language">
        /// The language of the input audio in ISO-639-1 format. Defaults to `en`.
        /// </param>
        /// <param name="timestampGranularities">
        /// The timestamp granularities to populate for this transcription. Currently only `word` level timestamps are supported.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranscriptionResponse> SttTranscribeAsync(
            global::G.SttTranscribeCartesiaVersion cartesiaVersion,
            global::G.STTEncoding? encoding = default,
            int? sampleRate = default,
            byte[]? file = default,
            string? filename = default,
            string? model = default,
            global::G.SttTranscribeRequestLanguage? language = default,
            global::System.Collections.Generic.IList<global::G.TimestampGranularity>? timestampGranularities = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}