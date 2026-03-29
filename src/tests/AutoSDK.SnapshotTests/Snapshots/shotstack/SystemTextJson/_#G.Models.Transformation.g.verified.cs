//HintName: G.Models.Transformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Apply one or more transformations to a clip. Transformations alter the visual properties of a clip and can be combined to create new shapes and effects.
    /// </summary>
    public sealed partial class Transformation
    {
        /// <summary>
        /// Rotate a clip by the specified angle in degrees. Rotation origin is set based on the clips `position`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotate")]
        public global::G.RotateTransformation? Rotate { get; set; }

        /// <summary>
        /// Skew a clip so its edges are sheared at an angle. Use values between -100 and 100. Values over 3 or under -3 will skew the clip almost flat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skew")]
        public global::G.SkewTransformation? Skew { get; set; }

        /// <summary>
        /// Flip a clip vertically or horizontally. Acts as a mirror effect of the clip along the selected plane.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flip")]
        public global::G.FlipTransformation? Flip { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Transformation" /> class.
        /// </summary>
        /// <param name="rotate">
        /// Rotate a clip by the specified angle in degrees. Rotation origin is set based on the clips `position`.
        /// </param>
        /// <param name="skew">
        /// Skew a clip so its edges are sheared at an angle. Use values between -100 and 100. Values over 3 or under -3 will skew the clip almost flat.
        /// </param>
        /// <param name="flip">
        /// Flip a clip vertically or horizontally. Acts as a mirror effect of the clip along the selected plane.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Transformation(
            global::G.RotateTransformation? rotate,
            global::G.SkewTransformation? skew,
            global::G.FlipTransformation? flip)
        {
            this.Rotate = rotate;
            this.Skew = skew;
            this.Flip = flip;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Transformation" /> class.
        /// </summary>
        public Transformation()
        {
        }
    }
}