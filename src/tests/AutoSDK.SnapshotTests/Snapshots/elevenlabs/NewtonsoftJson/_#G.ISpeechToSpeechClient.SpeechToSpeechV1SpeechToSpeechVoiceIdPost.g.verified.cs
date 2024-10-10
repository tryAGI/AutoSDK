//HintName: G.ISpeechToSpeechClient.SpeechToSpeechV1SpeechToSpeechVoiceIdPost.g.cs
#nullable enable

namespace G
{
    public partial interface ISpeechToSpeechClient
    {
        /// <summary>
        /// Speech To Speech<br/>
        /// Create speech by combining the content and emotion of the uploaded audio with a voice of your choice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="enableLogging">
        /// When enable_logging is set to false full privacy mode will be used for the request. This will mean history features are unavailable for this request, including request stitching. Full privacy mode may only be used by enterprise customers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="optimizeStreamingLatency">
        /// You can turn on latency optimizations at some cost of quality. The best possible final latency varies by model. Possible values:<br/>
        /// 0 - default mode (no latency optimizations)<br/>
        /// 1 - normal latency optimizations (about 50% of possible latency improvement of option 3)<br/>
        /// 2 - strong latency optimizations (about 75% of possible latency improvement of option 3)<br/>
        /// 3 - max latency optimizations<br/>
        /// 4 - max latency optimizations, but also with text normalizer turned off for even more latency savings (best latency, but can mispronounce eg numbers and dates).<br/>
        /// Defaults to None.
        /// </param>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Must be one of:<br/>
        /// mp3_22050_32 - output format, mp3 with 22.05kHz sample rate at 32kbps.<br/>
        /// mp3_44100_32 - output format, mp3 with 44.1kHz sample rate at 32kbps.<br/>
        /// mp3_44100_64 - output format, mp3 with 44.1kHz sample rate at 64kbps.<br/>
        /// mp3_44100_96 - output format, mp3 with 44.1kHz sample rate at 96kbps.<br/>
        /// mp3_44100_128 - default output format, mp3 with 44.1kHz sample rate at 128kbps.<br/>
        /// mp3_44100_192 - output format, mp3 with 44.1kHz sample rate at 192kbps. Requires you to be subscribed to Creator tier or above.<br/>
        /// pcm_16000 - PCM format (S16LE) with 16kHz sample rate.<br/>
        /// pcm_22050 - PCM format (S16LE) with 22.05kHz sample rate.<br/>
        /// pcm_24000 - PCM format (S16LE) with 24kHz sample rate.<br/>
        /// pcm_44100 - PCM format (S16LE) with 44.1kHz sample rate. Requires you to be subscribed to Pro tier or above.<br/>
        /// ulaw_8000 - μ-law format (sometimes written mu-law, often approximated as u-law) with 8kHz sample rate. Note that this format is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.HTTPValidationError> SpeechToSpeechV1SpeechToSpeechVoiceIdPostAsync(
            string voiceId,
            global::G.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPost request,
            bool? enableLogging = true,
            int? optimizeStreamingLatency = default,
            string? outputFormat = "mp3_44100_128",
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Speech To Speech<br/>
        /// Create speech by combining the content and emotion of the uploaded audio with a voice of your choice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="enableLogging">
        /// When enable_logging is set to false full privacy mode will be used for the request. This will mean history features are unavailable for this request, including request stitching. Full privacy mode may only be used by enterprise customers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="optimizeStreamingLatency">
        /// You can turn on latency optimizations at some cost of quality. The best possible final latency varies by model. Possible values:<br/>
        /// 0 - default mode (no latency optimizations)<br/>
        /// 1 - normal latency optimizations (about 50% of possible latency improvement of option 3)<br/>
        /// 2 - strong latency optimizations (about 75% of possible latency improvement of option 3)<br/>
        /// 3 - max latency optimizations<br/>
        /// 4 - max latency optimizations, but also with text normalizer turned off for even more latency savings (best latency, but can mispronounce eg numbers and dates).<br/>
        /// Defaults to None.
        /// </param>
        /// <param name="outputFormat">
        /// Output format of the generated audio. Must be one of:<br/>
        /// mp3_22050_32 - output format, mp3 with 22.05kHz sample rate at 32kbps.<br/>
        /// mp3_44100_32 - output format, mp3 with 44.1kHz sample rate at 32kbps.<br/>
        /// mp3_44100_64 - output format, mp3 with 44.1kHz sample rate at 64kbps.<br/>
        /// mp3_44100_96 - output format, mp3 with 44.1kHz sample rate at 96kbps.<br/>
        /// mp3_44100_128 - default output format, mp3 with 44.1kHz sample rate at 128kbps.<br/>
        /// mp3_44100_192 - output format, mp3 with 44.1kHz sample rate at 192kbps. Requires you to be subscribed to Creator tier or above.<br/>
        /// pcm_16000 - PCM format (S16LE) with 16kHz sample rate.<br/>
        /// pcm_22050 - PCM format (S16LE) with 22.05kHz sample rate.<br/>
        /// pcm_24000 - PCM format (S16LE) with 24kHz sample rate.<br/>
        /// pcm_44100 - PCM format (S16LE) with 44.1kHz sample rate. Requires you to be subscribed to Pro tier or above.<br/>
        /// ulaw_8000 - μ-law format (sometimes written mu-law, often approximated as u-law) with 8kHz sample rate. Note that this format is commonly used for Twilio audio inputs.<br/>
        /// Default Value: mp3_44100_128
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="audio">
        /// The audio file which holds the content and emotion that will control the generated speech.
        /// </param>
        /// <param name="audioname">
        /// The audio file which holds the content and emotion that will control the generated speech.
        /// </param>
        /// <param name="modelId">
        /// Identifier of the model that will be used, you can query them using GET /v1/models. The model needs to have support for speech to speech, you can check this using the can_do_voice_conversion property.<br/>
        /// Default Value: eleven_english_sts_v2
        /// </param>
        /// <param name="voiceSettings">
        /// Voice settings overriding stored setttings for the given voice. They are applied only on the given request. Needs to be send as a JSON encoded string.
        /// </param>
        /// <param name="seed">
        /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.HTTPValidationError> SpeechToSpeechV1SpeechToSpeechVoiceIdPostAsync(
            string voiceId,
            byte[] audio,
            string audioname,
            bool? enableLogging = true,
            int? optimizeStreamingLatency = default,
            string? outputFormat = "mp3_44100_128",
            string? xiApiKey = default,
            string? modelId = "eleven_english_sts_v2",
            string? voiceSettings = default,
            int? seed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}