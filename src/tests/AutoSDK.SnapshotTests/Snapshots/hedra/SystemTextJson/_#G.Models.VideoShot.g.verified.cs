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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Duration of this shot in milliseconds (3000-15000).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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