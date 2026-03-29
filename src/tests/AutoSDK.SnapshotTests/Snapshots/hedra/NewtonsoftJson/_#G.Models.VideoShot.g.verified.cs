//HintName: G.Models.VideoShot.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single shot in a multi-shot video generation.
    /// </summary>
    public sealed partial class VideoShot
    {
        /// <summary>
        /// Prompt for this shot.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Duration of this shot in milliseconds (3000-15000).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int DurationMs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoShot" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Prompt for this shot.
        /// </param>
        /// <param name="durationMs">
        /// Duration of this shot in milliseconds (3000-15000).
        /// </param>
        public VideoShot(
            string prompt,
            int durationMs)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoShot" /> class.
        /// </summary>
        public VideoShot()
        {
        }
    }
}