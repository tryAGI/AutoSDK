//HintName: G.ISubpackageTextToSpeechClient.Stream.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageTextToSpeechClient
    {
        /// <summary>
        /// Stream Speech<br/>
        /// Synthesize speech with ultra-low latency over a streaming connection.<br/>
        /// Choose the `Base URL` from the URL dropdown (Global URL or a pinned Region)<br/>
        /// **Note**: Global URL auto-routes to the nearest region.<br/>
        /// | Region         | URL                                       | Default Concurrency |<br/>
        /// | ------------------------- | ---------------------------------------------- | -------------------- |<br/>
        /// | Global (Routes to the nearest server) | `https://global.api.murf.ai/v1/speech/stream`     | Region specific concurrency |<br/>
        /// | US-East                   | `https://us-east.api.murf.ai/v1/speech/stream`    | 15 |<br/>
        /// | US-West                   | `https://us-west.api.murf.ai/v1/speech/stream`    | 2 |<br/>
        /// | India                     | `https://in.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | Canada                    | `https://ca.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | South Korea               | `https://kr.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | UAE                       | `https://me.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | Japan                     | `https://jp.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | Australia                 | `https://au.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | EU (Central)              | `https://eu-central.api.murf.ai/v1/speech/stream` | 2 |<br/>
        /// | UK                        | `https://uk.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | South America (São Paulo) | `https://sa-east.api.murf.ai/v1/speech/stream`    | 2 |
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TextToSpeechStreamResponse200> StreamAsync(

            global::G.GenerateSpeechStreamingRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stream Speech<br/>
        /// Synthesize speech with ultra-low latency over a streaming connection.<br/>
        /// Choose the `Base URL` from the URL dropdown (Global URL or a pinned Region)<br/>
        /// **Note**: Global URL auto-routes to the nearest region.<br/>
        /// | Region         | URL                                       | Default Concurrency |<br/>
        /// | ------------------------- | ---------------------------------------------- | -------------------- |<br/>
        /// | Global (Routes to the nearest server) | `https://global.api.murf.ai/v1/speech/stream`     | Region specific concurrency |<br/>
        /// | US-East                   | `https://us-east.api.murf.ai/v1/speech/stream`    | 15 |<br/>
        /// | US-West                   | `https://us-west.api.murf.ai/v1/speech/stream`    | 2 |<br/>
        /// | India                     | `https://in.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | Canada                    | `https://ca.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | South Korea               | `https://kr.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | UAE                       | `https://me.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | Japan                     | `https://jp.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | Australia                 | `https://au.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | EU (Central)              | `https://eu-central.api.murf.ai/v1/speech/stream` | 2 |<br/>
        /// | UK                        | `https://uk.api.murf.ai/v1/speech/stream`         | 2 |<br/>
        /// | South America (São Paulo) | `https://sa-east.api.murf.ai/v1/speech/stream`    | 2 |
        /// </summary>
        /// <param name="model">
        /// The model to use for audio output. Defaults to FALCON for all the regions except US-East. Valid values: FALCON, GEN2
        /// </param>
        /// <param name="channelType">
        /// Valid values: STEREO, MONO<br/>
        /// Default Value: MONO
        /// </param>
        /// <param name="format">
        /// Format of the generated audio file.Valid values: MP3, FLAC, WAV, ALAW, ULAW, OGG, PCM<br/>
        /// Default Value: WAV
        /// </param>
        /// <param name="multiNativeLocale">
        /// This field is superseded by `locale` field. Please migrate to `locale` field to ensure compatibility with future API versions.<br/>
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively.<br/>
        /// Valid values: "en-US", "en-UK", "es-ES", etc. Use the GET /v1/speech/voices endpoint to retrieve the list of available voices and languages.
        /// </param>
        /// <param name="locale">
        /// Specifies the language for the generated audio, enabling a voice to speak in multiple languages natively.<br/>
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
        /// Valid values are 8000, 16000, 24000, 44100, 48000. Defaults to 24000 for Falcon model and 44100 for Gen2 model.<br/>
        /// Default Value: 24000
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TextToSpeechStreamResponse200> StreamAsync(
            string text,
            string voiceId,
            string? model = default,
            string? channelType = default,
            string? format = default,
            string? multiNativeLocale = default,
            string? locale = default,
            int? pitch = default,
            global::System.Collections.Generic.Dictionary<string, global::G.PronunciationDetail>? pronunciationDictionary = default,
            int? rate = default,
            double? sampleRate = default,
            string? style = default,
            int? variation = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}