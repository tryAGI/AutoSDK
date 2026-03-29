//HintName: G.ISubpackageTextToSpeechClient.Generate.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageTextToSpeechClient
    {
        /// <summary>
        /// Synthesize Speech<br/>
        /// Returns a url to the generated audio file along with other associated properties.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateSpeechResponse> GenerateAsync(

            global::G.GenerateSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Synthesize Speech<br/>
        /// Returns a url to the generated audio file along with other associated properties.
        /// </summary>
        /// <param name="audioDuration">
        /// This parameter allows specifying the duration (in seconds) for the generated audio. If the value is 0, this parameter will be ignored. Only available for Gen2 model.
        /// </param>
        /// <param name="channelType">
        /// Valid values: STEREO, MONO<br/>
        /// Default Value: MONO
        /// </param>
        /// <param name="encodeAsBase64">
        /// Set to true to receive audio in response as a Base64 encoded string instead of a url. This enables zero retention of audio data on Murf's servers.
        /// </param>
        /// <param name="format">
        /// Format of the generated audio file. Valid values: MP3, WAV, FLAC, ALAW, ULAW, PCM, OGG<br/>
        /// Default Value: WAV
        /// </param>
        /// <param name="modelVersion">
        /// Valid values: GEN2. Audio will be generated using the new and advanced GEN2 model. Outputs from GEN2 sound more natural and high-quality compared to earlier models.<br/>
        /// Default Value: GEN2
        /// </param>
        /// <param name="multiNativeLocale">
        /// This field is superseded by `locale` field. Please migrate to `locale` field to ensure compatibility with future API versions.<br/>
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively. Only available in the Gen2 model.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </param>
        /// <param name="locale">
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively. Only available in the Gen2 model.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </param>
        /// <param name="pitch">
        /// Pitch of the voiceover
        /// </param>
        /// <param name="pronunciationDictionary">
        /// An object used to define custom pronunciations. <br/>
        ///  Example 1: {"live":{"type": "IPA", "pronunciation": "laɪv"}}. <br/>
        ///  Example 2: {"2022":{"type": "SAY_AS", "pronunciation": "twenty twenty two"}}
        /// </param>
        /// <param name="rate">
        /// Speed of the voiceover
        /// </param>
        /// <param name="sampleRate">
        /// Valid values are 8000, 24000, 44100, 48000<br/>
        /// Default Value: 44100
        /// </param>
        /// <param name="style">
        /// The voice style to be used for voiceover generation.
        /// </param>
        /// <param name="text">
        /// The text that is to be synthesised. e.g. 'Hello there [pause 1s] friend'
        /// </param>
        /// <param name="variation">
        /// Higher values will add more variation in terms of Pause, Pitch, and Speed to the voice. Only available for Gen2 model.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="voiceId">
        /// Use the GET /v1/speech/voices API to find supported voiceIds. You can use either the voiceId (e.g. en-US-natalie) or just the voice actor's name (e.g. natalie).
        /// </param>
        /// <param name="wordDurationsAsOriginalText">
        /// If set to true, the word durations in response will return words as the original input text. (English only)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GenerateSpeechResponse> GenerateAsync(
            string text,
            string voiceId,
            double? audioDuration = default,
            string? channelType = default,
            bool? encodeAsBase64 = default,
            string? format = default,
            global::G.GenerateSpeechRequestModelVersion? modelVersion = default,
            string? multiNativeLocale = default,
            string? locale = default,
            int? pitch = default,
            global::System.Collections.Generic.Dictionary<string, global::G.PronunciationDetail>? pronunciationDictionary = default,
            int? rate = default,
            double? sampleRate = default,
            string? style = default,
            int? variation = default,
            bool? wordDurationsAsOriginalText = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}