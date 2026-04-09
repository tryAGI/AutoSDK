//HintName: G.ISubpackageVoiceChangerClient.Convert.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageVoiceChangerClient
    {
        /// <summary>
        /// Voice Changer<br/>
        /// Returns a url to the generated audio file along with other associated properties.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpeechToSpeechResponse> ConvertAsync(

            global::G.ConvertRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Voice Changer<br/>
        /// Returns a url to the generated audio file along with other associated properties.
        /// </summary>
        /// <param name="audioDuration">
        /// This parameter allows specifying the duration (in seconds) for the generated audio. If the value is 0, this parameter will be ignored. Only available for Gen2 model.
        /// </param>
        /// <param name="channelType">
        /// Valid values: STEREO, MONO<br/>
        /// Default Value: MONO
        /// </param>
        /// <param name="encodeOutputAsBase64">
        /// Set to true to receive audio in response as a Base64 encoded string along with a url.
        /// </param>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="filename">
        /// The file to upload
        /// </param>
        /// <param name="fileUrl"></param>
        /// <param name="format">
        /// Format of the generated audio file. Valid values: MP3, WAV, FLAC, ALAW, ULAW<br/>
        /// Default Value: WAV
        /// </param>
        /// <param name="multiNativeLocale">
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively. Only available in the Gen2 model.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc.<br/>
        /// Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </param>
        /// <param name="pitch">
        /// Pitch of the voiceover
        /// </param>
        /// <param name="pronunciationDictionary">
        /// A JSON string that defines custom pronunciations for specific words or phrases. Each key is a word or phrase, and its value is an object with `type` and `pronunciation`.<br/>
        /// Example 1: '{"live": {"type": "IPA", "pronunciation": "laɪv"}}'<br/>
        /// Example 2: '{"2022": {"type": "SAY_AS", "pronunciation": "twenty twenty two"}}'
        /// </param>
        /// <param name="rate">
        /// Speed of the voiceover
        /// </param>
        /// <param name="retainAccent">
        /// Set to true to retain the original accent of the speaker during voice generation.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="retainProsody">
        /// Indicates whether to retain the original prosody (intonation, rhythm, and stress) of the input voice in the generated output.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="returnTranscription">
        /// Set to true to include a textual transcription of the generated audio in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sampleRate">
        /// Valid values are 8000, 24000, 44100, 48000<br/>
        /// Default Value: 44100
        /// </param>
        /// <param name="style">
        /// The voice style to be used for voiceover generation.
        /// </param>
        /// <param name="transcription">
        /// This parameter allows specifying a transcription of the audio clip, which will then be used as input for the voice changer
        /// </param>
        /// <param name="variation">
        /// Higher values will add more variation in terms of Pause, Pitch, and Speed to the voice. Only available for Gen2 model.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="voiceId">
        /// Use the GET /v1/speech/voices API to find supported voiceIds. You can use either the voiceId (e.g. en-US-natalie) or just the voice actor's name (e.g. natalie).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SpeechToSpeechResponse> ConvertAsync(
            string voiceId,
            double? audioDuration = default,
            string? channelType = default,
            bool? encodeOutputAsBase64 = default,
            byte[]? file = default,
            string? filename = default,
            string? fileUrl = default,
            string? format = default,
            string? multiNativeLocale = default,
            int? pitch = default,
            string? pronunciationDictionary = default,
            int? rate = default,
            bool? retainAccent = default,
            bool? retainProsody = default,
            bool? returnTranscription = default,
            double? sampleRate = default,
            string? style = default,
            string? transcription = default,
            int? variation = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}