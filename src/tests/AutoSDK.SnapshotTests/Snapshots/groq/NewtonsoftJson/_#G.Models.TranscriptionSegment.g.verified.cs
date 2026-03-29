//HintName: G.Models.TranscriptionSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriptionSegment
    {
        /// <summary>
        /// Unique identifier of the segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Seek offset of the segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seek", Required = global::Newtonsoft.Json.Required.Always)]
        public int Seek { get; set; } = default!;

        /// <summary>
        /// Start time of the segment in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public float Start { get; set; } = default!;

        /// <summary>
        /// End time of the segment in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public float End { get; set; } = default!;

        /// <summary>
        /// Text content of the segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Array of token IDs for the text content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> Tokens { get; set; } = default!;

        /// <summary>
        /// Temperature parameter used for generating the segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Average logprob of the segment. If the value is lower than -1, consider the logprobs failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_logprob")]
        public float? AvgLogprob { get; set; }

        /// <summary>
        /// Compression ratio of the segment. If the value is greater than 2.4, consider the compression failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compression_ratio")]
        public float? CompressionRatio { get; set; }

        /// <summary>
        /// Probability of no speech in the segment. If the value is higher than 1.0 and the `avg_logprob` is below -1, consider this segment silent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("no_speech_prob")]
        public float? NoSpeechProb { get; set; }

        /// <summary>
        /// Transcribed text for the entire chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_text")]
        public string? AudioText { get; set; }

        /// <summary>
        /// Token-level scores.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_scores")]
        public global::System.Collections.Generic.IList<float>? TokenScores { get; set; }

        /// <summary>
        /// Start chunk timestamp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_start")]
        public int? ChunkStart { get; set; }

        /// <summary>
        /// End chunk timestamp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_end")]
        public int? ChunkEnd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionSegment" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the segment.
        /// </param>
        /// <param name="seek">
        /// Seek offset of the segment.
        /// </param>
        /// <param name="start">
        /// Start time of the segment in seconds.
        /// </param>
        /// <param name="end">
        /// End time of the segment in seconds.
        /// </param>
        /// <param name="text">
        /// Text content of the segment.
        /// </param>
        /// <param name="tokens">
        /// Array of token IDs for the text content.
        /// </param>
        /// <param name="temperature">
        /// Temperature parameter used for generating the segment.
        /// </param>
        /// <param name="avgLogprob">
        /// Average logprob of the segment. If the value is lower than -1, consider the logprobs failed.
        /// </param>
        /// <param name="compressionRatio">
        /// Compression ratio of the segment. If the value is greater than 2.4, consider the compression failed.
        /// </param>
        /// <param name="noSpeechProb">
        /// Probability of no speech in the segment. If the value is higher than 1.0 and the `avg_logprob` is below -1, consider this segment silent.
        /// </param>
        /// <param name="audioText">
        /// Transcribed text for the entire chunk
        /// </param>
        /// <param name="tokenScores">
        /// Token-level scores.
        /// </param>
        /// <param name="chunkStart">
        /// Start chunk timestamp.
        /// </param>
        /// <param name="chunkEnd">
        /// End chunk timestamp.
        /// </param>
        public TranscriptionSegment(
            int id,
            int seek,
            float start,
            float end,
            string text,
            global::System.Collections.Generic.IList<int> tokens,
            float? temperature,
            float? avgLogprob,
            float? compressionRatio,
            float? noSpeechProb,
            string? audioText,
            global::System.Collections.Generic.IList<float>? tokenScores,
            int? chunkStart,
            int? chunkEnd)
        {
            this.Id = id;
            this.Seek = seek;
            this.Start = start;
            this.End = end;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
            this.Temperature = temperature;
            this.AvgLogprob = avgLogprob;
            this.CompressionRatio = compressionRatio;
            this.NoSpeechProb = noSpeechProb;
            this.AudioText = audioText;
            this.TokenScores = tokenScores;
            this.ChunkStart = chunkStart;
            this.ChunkEnd = chunkEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionSegment" /> class.
        /// </summary>
        public TranscriptionSegment()
        {
        }
    }
}