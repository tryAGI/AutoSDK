//HintName: G.Models.ChromaKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Chroma key is a technique that replaces a specific color in a video with a different background image or video, enabling seamless integration of diverse environments. Commonly used for green screen and blue screen effects.
    /// </summary>
    public sealed partial class ChromaKey
    {
        /// <summary>
        /// The chroma key color as a hex value. Use green (#00b140) for green screens or blue (#0000FF) for blue screens. Any valid hex color can be used as the key color.<br/>
        /// Example: #00b140
        /// </summary>
        /// <example>#00b140</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Pixels within this distance from the key color are eliminated by setting their alpha values to zero.<br/>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public int? Threshold { get; set; }

        /// <summary>
        /// Pixels within the halo distance from the threshold boundary are given an increasing alpha value based on their distance from the threshold.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("halo")]
        public int? Halo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChromaKey" /> class.
        /// </summary>
        /// <param name="color">
        /// The chroma key color as a hex value. Use green (#00b140) for green screens or blue (#0000FF) for blue screens. Any valid hex color can be used as the key color.<br/>
        /// Example: #00b140
        /// </param>
        /// <param name="threshold">
        /// Pixels within this distance from the key color are eliminated by setting their alpha values to zero.<br/>
        /// Example: 150
        /// </param>
        /// <param name="halo">
        /// Pixels within the halo distance from the threshold boundary are given an increasing alpha value based on their distance from the threshold.<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChromaKey(
            string color,
            int? threshold,
            int? halo)
        {
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
            this.Threshold = threshold;
            this.Halo = halo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChromaKey" /> class.
        /// </summary>
        public ChromaKey()
        {
        }
    }
}