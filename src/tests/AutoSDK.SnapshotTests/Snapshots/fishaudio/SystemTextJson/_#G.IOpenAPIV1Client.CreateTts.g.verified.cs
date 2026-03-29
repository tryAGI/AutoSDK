//HintName: G.IOpenAPIV1Client.CreateTts.g.cs
#nullable enable

namespace G
{
    public partial interface IOpenAPIV1Client
    {
        /// <summary>
        /// Text to Speech
        /// </summary>
        /// <param name="model">
        /// Default Value: s2-pro
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        ///   --url https://api.fish.audio/v1/tts \<br/>
        ///   --header 'Authorization: Bearer &lt;token&gt;' \<br/>
        ///   --header 'Content-Type: application/json' \<br/>
        ///   --header 'model: s2-pro' \<br/>
        ///   --data '{<br/>
        ///     "text": "Hello! Welcome to Fish Audio.",<br/>
        ///     "reference_id": "model-id",<br/>
        ///     "temperature": 0.7,<br/>
        ///     "top_p": 0.7,<br/>
        ///     "prosody": {<br/>
        ///       "speed": 1,<br/>
        ///       "volume": 0,<br/>
        ///       "normalize_loudness": true<br/>
        ///     },<br/>
        ///     "chunk_length": 300,<br/>
        ///     "normalize": true,<br/>
        ///     "format": "mp3",<br/>
        ///     "sample_rate": 44100,<br/>
        ///     "mp3_bitrate": 128,<br/>
        ///     "latency": "normal",<br/>
        ///     "max_new_tokens": 1024,<br/>
        ///     "repetition_penalty": 1.2,<br/>
        ///     "min_chunk_length": 50,<br/>
        ///     "condition_on_previous_chunks": true,<br/>
        ///     "early_stop_threshold": 1<br/>
        ///   }'
        /// </remarks>
        global::System.Threading.Tasks.Task CreateTtsAsync(

            global::G.TTSRequest request,
            global::G.CreateTtsModel model = global::G.CreateTtsModel.S2Pro,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to Speech
        /// </summary>
        /// <param name="model">
        /// Default Value: s2-pro
        /// </param>
        /// <param name="text">
        /// Text to convert to speech.
        /// </param>
        /// <param name="temperature">
        /// Controls expressiveness. Higher is more varied, lower is more consistent.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="topP">
        /// Controls diversity via nucleus sampling.<br/>
        /// Default Value: 0.7F
        /// </param>
        /// <param name="references">
        /// Inline voice references for zero-shot cloning. Requires MessagePack (not JSON). For single speaker, provide an array of ReferenceAudio objects. For multiple speakers, provide an array of arrays where each inner array contains references for one speaker. **Multi-speaker is only available with the S2-Pro model.** The speaker index corresponds to the index in reference_id array. Example for multi-speaker: [[{audio, text}], [{audio, text}, {audio, text}]] for 2 speakers where speaker 1 has 2 reference samples.
        /// </param>
        /// <param name="referenceId">
        /// Voice model ID(s) from Fish Audio library or your custom models. For single-speaker synthesis, provide a string. For multi-speaker synthesis (dialogue), provide an array of model IDs. **Multi-speaker is only available with the S2-Pro model.** When using multiple speakers, use speaker tags in your text like `&lt;|speaker:0|&gt;` and `&lt;|speaker:1|&gt;` to indicate speaker changes. Example: `&lt;|speaker:0|&gt;Hello!&lt;|speaker:1|&gt;Hi there!&lt;|speaker:0|&gt;How are you?` with `reference_id: ["speaker-a-id", "speaker-b-id"]`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="prosody">
        /// Speed and volume adjustments for the output.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chunkLength">
        /// Text segment size for processing.<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="normalize">
        /// Normalizes text for English and Chinese, improving stability for numbers.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="format">
        /// Output audio format.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="sampleRate">
        /// Audio sample rate in Hz. When null, uses the format's default (44100 Hz for most formats, 48000 Hz for opus).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="mp3Bitrate">
        /// MP3 bitrate in kbps. Only applies when format is mp3.<br/>
        /// Default Value: 128
        /// </param>
        /// <param name="opusBitrate">
        /// Opus bitrate in bps. -1000 for automatic. Only applies when format is opus.<br/>
        /// Default Value: -1000
        /// </param>
        /// <param name="latency">
        /// Latency-quality trade-off. normal: best quality, balanced: reduced latency, low: lowest latency.<br/>
        /// Default Value: normal
        /// </param>
        /// <param name="maxNewTokens">
        /// Maximum audio tokens to generate per text chunk.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="repetitionPenalty">
        /// Penalty for repeating audio patterns. Values above 1.0 reduce repetition.<br/>
        /// Default Value: 1.2F
        /// </param>
        /// <param name="minChunkLength">
        /// Minimum characters before splitting into a new chunk.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="conditionOnPreviousChunks">
        /// Use previous audio as context for voice consistency.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="earlyStopThreshold">
        /// Early stopping threshold for batch processing.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateTtsAsync(
            string text,
            global::G.CreateTtsModel model = global::G.CreateTtsModel.S2Pro,
            double? temperature = default,
            double? topP = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.ReferenceAudio>>, object>? references = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? referenceId = default,
            global::G.ProsodyControl? prosody = default,
            int? chunkLength = default,
            bool? normalize = default,
            global::G.TTSRequestFormat? format = default,
            int? sampleRate = default,
            int? mp3Bitrate = default,
            int? opusBitrate = default,
            global::G.TTSRequestLatency? latency = default,
            int? maxNewTokens = default,
            double? repetitionPenalty = default,
            int? minChunkLength = default,
            bool? conditionOnPreviousChunks = default,
            double? earlyStopThreshold = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}