//HintName: G.Models.ProsodyControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls for adjusting the prosody (rhythm and intonation) of generated speech.
    /// </summary>
    public sealed partial class ProsodyControl
    {
        /// <summary>
        /// Speaking rate multiplier. Valid range: 0.5 to 2.0. 1.0 = normal speed, 0.5 = half speed, 2.0 = double speed. Useful for adjusting pacing without regenerating audio.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Volume adjustment in decibels (dB). 0 = no change, positive values = louder, negative values = quieter.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public double? Volume { get; set; }

        /// <summary>
        /// Normalize output loudness for more consistent perceived volume. **S2-Pro only.**<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalize_loudness")]
        public bool? NormalizeLoudness { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProsodyControl" /> class.
        /// </summary>
        /// <param name="speed">
        /// Speaking rate multiplier. Valid range: 0.5 to 2.0. 1.0 = normal speed, 0.5 = half speed, 2.0 = double speed. Useful for adjusting pacing without regenerating audio.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="volume">
        /// Volume adjustment in decibels (dB). 0 = no change, positive values = louder, negative values = quieter.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="normalizeLoudness">
        /// Normalize output loudness for more consistent perceived volume. **S2-Pro only.**<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProsodyControl(
            double? speed,
            double? volume,
            bool? normalizeLoudness)
        {
            this.Speed = speed;
            this.Volume = volume;
            this.NormalizeLoudness = normalizeLoudness;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProsodyControl" /> class.
        /// </summary>
        public ProsodyControl()
        {
        }
    }
}