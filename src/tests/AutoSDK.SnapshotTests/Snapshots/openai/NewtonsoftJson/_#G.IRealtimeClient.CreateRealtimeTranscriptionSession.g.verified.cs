//HintName: G.IRealtimeClient.CreateRealtimeTranscriptionSession.g.cs
#nullable enable

namespace G
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Create an ephemeral API token for use in client-side applications with the<br/>
        /// Realtime API specifically for realtime transcriptions. <br/>
        /// Can be configured with the same session parameters as the `transcription_session.update` client event.<br/>
        /// It responds with a session object, plus a `client_secret` key which contains<br/>
        /// a usable ephemeral API token that can be used to authenticate browser clients<br/>
        /// for the Realtime API.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RealtimeTranscriptionSessionCreateResponse> CreateRealtimeTranscriptionSessionAsync(
            global::G.RealtimeTranscriptionSessionCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an ephemeral API token for use in client-side applications with the<br/>
        /// Realtime API specifically for realtime transcriptions. <br/>
        /// Can be configured with the same session parameters as the `transcription_session.update` client event.<br/>
        /// It responds with a session object, plus a `client_secret` key which contains<br/>
        /// a usable ephemeral API token that can be used to authenticate browser clients<br/>
        /// for the Realtime API.
        /// </summary>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate,<br/>
        /// single channel (mono), and little-endian byte order.<br/>
        /// Default Value: pcm16
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration for input audio transcription. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection, ether Server VAD or Semantic VAD. This can be set to `null` to turn off, in which case the client must manually trigger model response.<br/>
        /// Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.<br/>
        /// Semantic VAD is more advanced and uses a turn detection model (in conjuction with VAD) to semantically estimate whether the user has finished speaking, then dynamically sets a timeout based on this probability. For example, if user audio trails off with "uhhm", the model will score a low probability of turn end and wait longer for the user to continue speaking. This can be useful for more natural conversations, but may have a higher latency.
        /// </param>
        /// <param name="inputAudioNoiseReduction">
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.
        /// </param>
        /// <param name="include">
        /// The set of items to include in the transcription. Current available items are:<br/>
        /// - `item.input_audio_transcription.logprobs`
        /// </param>
        /// <param name="clientSecret">
        /// Configuration options for the generated client secret.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RealtimeTranscriptionSessionCreateResponse> CreateRealtimeTranscriptionSessionAsync(
            global::System.Collections.Generic.IList<global::G.RealtimeTranscriptionSessionCreateRequestModalitie>? modalities = default,
            global::G.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? inputAudioFormat = default,
            global::G.RealtimeTranscriptionSessionCreateRequestInputAudioTranscription? inputAudioTranscription = default,
            global::G.RealtimeTranscriptionSessionCreateRequestTurnDetection? turnDetection = default,
            global::G.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? inputAudioNoiseReduction = default,
            global::System.Collections.Generic.IList<string>? include = default,
            global::G.RealtimeTranscriptionSessionCreateRequestClientSecret? clientSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}