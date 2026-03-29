//HintName: G.Models.GenerateVideoRequestInputAudioStartMs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Audio start offset in milliseconds. Negative values prepend silence (e.g., -1000 adds 1s silence before audio). Positive values crop from the beginning of the source audio (e.g., 2000 skips the first 2s). Use with generated_video_inputs.duration_ms to control total output length.
    /// </summary>
    public sealed partial class GenerateVideoRequestInputAudioStartMs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}