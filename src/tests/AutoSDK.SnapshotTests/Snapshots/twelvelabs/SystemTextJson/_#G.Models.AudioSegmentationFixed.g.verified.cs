//HintName: G.Models.AudioSegmentationFixed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for fixed segmentation.<br/>
    /// This object is required when the `strategy` field is `fixed`.
    /// </summary>
    public sealed partial class AudioSegmentationFixed
    {
        /// <summary>
        /// The duration in seconds for each segment. The platform divides the audio into segments of this exact length. The final segment may be shorter if the audio duration is not evenly divisible.<br/>
        ///  **Example**: With `duration_sec: 5`, a 12-second audio file produces segments: [0-5s], [5-10s], [10-12s].<br/>
        /// Default Value: 6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSegmentationFixed" /> class.
        /// </summary>
        /// <param name="durationSec">
        /// The duration in seconds for each segment. The platform divides the audio into segments of this exact length. The final segment may be shorter if the audio duration is not evenly divisible.<br/>
        ///  **Example**: With `duration_sec: 5`, a 12-second audio file produces segments: [0-5s], [5-10s], [10-12s].<br/>
        /// Default Value: 6
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioSegmentationFixed(
            int durationSec)
        {
            this.DurationSec = durationSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioSegmentationFixed" /> class.
        /// </summary>
        public AudioSegmentationFixed()
        {
        }
    }
}