//HintName: G.Models.TTSRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for text-to-speech synthesis. Supports single-speaker synthesis on all compatible TTS models. Multi-speaker dialogue synthesis is only available with the S2-Pro model.<br/>
    /// ## Single Speaker<br/>
    /// Provide either `reference_id` (string) pointing to a voice model, or `references` (array of ReferenceAudio) for zero-shot cloning.<br/>
    /// ## Multiple Speakers (Dialogue, S2-Pro only)<br/>
    /// For multi-speaker synthesis, provide:<br/>
    /// - `reference_id`: array of voice model IDs, e.g., ["speaker-0-id", "speaker-1-id"]<br/>
    /// - `text`: use speaker tags `&lt;|speaker:0|&gt;`, `&lt;|speaker:1|&gt;`, etc. to indicate speaker changes, e.g., "&lt;|speaker:0|&gt;Hello!&lt;|speaker:1|&gt;Hi there!"<br/>
    /// Alternatively, for zero-shot multi-speaker:<br/>
    /// - `references`: 2D array where each inner array contains references for one speaker<br/>
    /// - `reference_id`: array of identifiers (can be arbitrary strings for zero-shot)<br/>
    /// ## Example (Multi-Speaker with Model IDs)<br/>
    /// ```json<br/>
    /// {<br/>
    ///   "text": "&lt;|speaker:0|&gt;Good morning!&lt;|speaker:1|&gt;Good morning! How are you?&lt;|speaker:0|&gt;I'm great, thanks!",<br/>
    ///   "reference_id": ["model-id-alice", "model-id-bob"]<br/>
    /// }<br/>
    /// ```
    /// </summary>
    public sealed partial class TTSRequest
    {
        /// <summary>
        /// Text to convert to speech.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Controls expressiveness. Higher is more varied, lower is more consistent.<br/>
        /// Default Value: 0.7F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Controls diversity via nucleus sampling.<br/>
        /// Default Value: 0.7F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        /// Inline voice references for zero-shot cloning. Requires MessagePack (not JSON). For single speaker, provide an array of ReferenceAudio objects. For multiple speakers, provide an array of arrays where each inner array contains references for one speaker. **Multi-speaker is only available with the S2-Pro model.** The speaker index corresponds to the index in reference_id array. Example for multi-speaker: [[{audio, text}], [{audio, text}, {audio, text}]] for 2 speakers where speaker 1 has 2 reference samples.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("references")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.ReferenceAudio>>, object>? References { get; set; }

        /// <summary>
        /// Voice model ID(s) from Fish Audio library or your custom models. For single-speaker synthesis, provide a string. For multi-speaker synthesis (dialogue), provide an array of model IDs. **Multi-speaker is only available with the S2-Pro model.** When using multiple speakers, use speaker tags in your text like `&lt;|speaker:0|&gt;` and `&lt;|speaker:1|&gt;` to indicate speaker changes. Example: `&lt;|speaker:0|&gt;Hello!&lt;|speaker:1|&gt;Hi there!&lt;|speaker:0|&gt;How are you?` with `reference_id: ["speaker-a-id", "speaker-b-id"]`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reference_id")]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? ReferenceId { get; set; }

        /// <summary>
        /// Speed and volume adjustments for the output.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prosody")]
        public global::G.ProsodyControl? Prosody { get; set; }

        /// <summary>
        /// Text segment size for processing.<br/>
        /// Default Value: 300
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_length")]
        public int? ChunkLength { get; set; }

        /// <summary>
        /// Normalizes text for English and Chinese, improving stability for numbers.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("normalize")]
        public bool? Normalize { get; set; }

        /// <summary>
        /// Output audio format.<br/>
        /// Default Value: mp3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format")]
        public global::G.TTSRequestFormat? Format { get; set; }

        /// <summary>
        /// Audio sample rate in Hz. When null, uses the format's default (44100 Hz for most formats, 48000 Hz for opus).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// MP3 bitrate in kbps. Only applies when format is mp3.<br/>
        /// Default Value: 128
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mp3_bitrate")]
        public int? Mp3Bitrate { get; set; }

        /// <summary>
        /// Opus bitrate in bps. -1000 for automatic. Only applies when format is opus.<br/>
        /// Default Value: -1000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("opus_bitrate")]
        public int? OpusBitrate { get; set; }

        /// <summary>
        /// Latency-quality trade-off. normal: best quality, balanced: reduced latency, low: lowest latency.<br/>
        /// Default Value: normal
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latency")]
        public global::G.TTSRequestLatency? Latency { get; set; }

        /// <summary>
        /// Maximum audio tokens to generate per text chunk.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_new_tokens")]
        public int? MaxNewTokens { get; set; }

        /// <summary>
        /// Penalty for repeating audio patterns. Values above 1.0 reduce repetition.<br/>
        /// Default Value: 1.2F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repetition_penalty")]
        public double? RepetitionPenalty { get; set; }

        /// <summary>
        /// Minimum characters before splitting into a new chunk.<br/>
        /// Default Value: 50
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_chunk_length")]
        public int? MinChunkLength { get; set; }

        /// <summary>
        /// Use previous audio as context for voice consistency.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition_on_previous_chunks")]
        public bool? ConditionOnPreviousChunks { get; set; }

        /// <summary>
        /// Early stopping threshold for batch processing.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("early_stop_threshold")]
        public double? EarlyStopThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSRequest" /> class.
        /// </summary>
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
        public TTSRequest(
            string text,
            double? temperature,
            double? topP,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.ReferenceAudio>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::G.ReferenceAudio>>, object>? references,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? referenceId,
            global::G.ProsodyControl? prosody,
            int? chunkLength,
            bool? normalize,
            global::G.TTSRequestFormat? format,
            int? sampleRate,
            int? mp3Bitrate,
            int? opusBitrate,
            global::G.TTSRequestLatency? latency,
            int? maxNewTokens,
            double? repetitionPenalty,
            int? minChunkLength,
            bool? conditionOnPreviousChunks,
            double? earlyStopThreshold)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Temperature = temperature;
            this.TopP = topP;
            this.References = references;
            this.ReferenceId = referenceId;
            this.Prosody = prosody;
            this.ChunkLength = chunkLength;
            this.Normalize = normalize;
            this.Format = format;
            this.SampleRate = sampleRate;
            this.Mp3Bitrate = mp3Bitrate;
            this.OpusBitrate = opusBitrate;
            this.Latency = latency;
            this.MaxNewTokens = maxNewTokens;
            this.RepetitionPenalty = repetitionPenalty;
            this.MinChunkLength = minChunkLength;
            this.ConditionOnPreviousChunks = conditionOnPreviousChunks;
            this.EarlyStopThreshold = earlyStopThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSRequest" /> class.
        /// </summary>
        public TTSRequest()
        {
        }
    }
}