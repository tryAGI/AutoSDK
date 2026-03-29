//HintName: G.Models.UploadedAudio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadedAudio
    {
        /// <summary>
        /// Default Value: uploaded_audio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Duration of the audio in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int DurationMs { get; set; } = default!;

        /// <summary>
        /// URL of the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Transcriptions of the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcriptions")]
        public global::System.Collections.Generic.IList<object>? Transcriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedAudio" /> class.
        /// </summary>
        /// <param name="durationMs">
        /// Duration of the audio in seconds.
        /// </param>
        /// <param name="url">
        /// URL of the audio.
        /// </param>
        /// <param name="type">
        /// Default Value: uploaded_audio
        /// </param>
        /// <param name="transcriptions">
        /// Transcriptions of the audio.
        /// </param>
        public UploadedAudio(
            int durationMs,
            string url,
            string? type,
            global::System.Collections.Generic.IList<object>? transcriptions)
        {
            this.Type = type;
            this.DurationMs = durationMs;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Transcriptions = transcriptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedAudio" /> class.
        /// </summary>
        public UploadedAudio()
        {
        }
    }
}