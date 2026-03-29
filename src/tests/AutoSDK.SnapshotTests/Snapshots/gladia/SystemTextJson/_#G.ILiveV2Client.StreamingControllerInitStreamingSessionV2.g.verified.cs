//HintName: G.ILiveV2Client.StreamingControllerInitStreamingSessionV2.g.cs
#nullable enable

namespace G
{
    public partial interface ILiveV2Client
    {
        /// <summary>
        /// Initiate a new live job
        /// </summary>
        /// <param name="region"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.InitStreamingResponse> StreamingControllerInitStreamingSessionV2Async(

            global::G.StreamingRequest request,
            global::G.StreamingSupportedRegions? region = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initiate a new live job
        /// </summary>
        /// <param name="region"></param>
        /// <param name="encoding">
        /// The encoding format of the audio stream. Supported formats: <br/>
        /// - PCM: 8, 16, 24, and 32 bits <br/>
        /// - A-law: 8 bits <br/>
        /// - μ-law: 8 bits <br/>
        /// Note: No need to add WAV headers to raw audio as the API supports both formats.<br/>
        /// Default Value: wav/pcm
        /// </param>
        /// <param name="bitDepth">
        /// The bit depth of the audio stream<br/>
        /// Default Value: 16
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate of the audio stream<br/>
        /// Default Value: 16000
        /// </param>
        /// <param name="channels">
        /// The number of channels of the audio stream<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata you can attach to this live transcription<br/>
        /// Example: {"user":"John Doe"}
        /// </param>
        /// <param name="model">
        /// The model used to process the audio. "solaria-1" is used by default.<br/>
        /// Default Value: solaria-1
        /// </param>
        /// <param name="endpointing">
        /// The endpointing duration in seconds. Endpointing is the duration of silence which will cause an utterance to be considered as finished<br/>
        /// Default Value: 0.05F
        /// </param>
        /// <param name="maximumDurationWithoutEndpointing">
        /// The maximum duration in seconds without endpointing. If endpointing is not detected after this duration, current utterance will be considered as finished<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="languageConfig">
        /// Specify the language configuration
        /// </param>
        /// <param name="preProcessing">
        /// Specify the pre-processing configuration
        /// </param>
        /// <param name="realtimeProcessing">
        /// Specify the realtime processing configuration
        /// </param>
        /// <param name="postProcessing">
        /// Specify the post-processing configuration
        /// </param>
        /// <param name="messagesConfig">
        /// Specify the websocket messages configuration
        /// </param>
        /// <param name="callback">
        /// If true, messages will be sent to configured url.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="callbackConfig">
        /// Specify the callback configuration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.InitStreamingResponse> StreamingControllerInitStreamingSessionV2Async(
            global::G.StreamingSupportedRegions? region = default,
            global::G.StreamingSupportedEncodingEnum? encoding = default,
            double? bitDepth = default,
            double? sampleRate = default,
            int? channels = default,
            object? customMetadata = default,
            global::G.StreamingSupportedModels? model = default,
            double? endpointing = default,
            double? maximumDurationWithoutEndpointing = default,
            global::G.LanguageConfig? languageConfig = default,
            global::G.PreProcessingConfig? preProcessing = default,
            global::G.RealtimeProcessingConfig? realtimeProcessing = default,
            global::G.PostProcessingConfig? postProcessing = default,
            global::G.MessagesConfig? messagesConfig = default,
            bool? callback = default,
            global::G.CallbackConfig? callbackConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}