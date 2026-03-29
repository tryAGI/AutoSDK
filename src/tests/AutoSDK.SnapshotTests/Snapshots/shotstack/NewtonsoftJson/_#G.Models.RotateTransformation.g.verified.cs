//HintName: G.Models.RotateTransformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rotate a clip by the specified angle in degrees. Rotation origin is set based on the clips `position`.
    /// </summary>
    public sealed partial class RotateTransformation
    {
        /// <summary>
        /// Rotate a clip by the specified angle in degrees. Use a number or an array of [Tween](./#tocs_tween) objects to create a custom animation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("angle")]
        public global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? Angle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateTransformation" /> class.
        /// </summary>
        /// <param name="angle">
        /// Rotate a clip by the specified angle in degrees. Use a number or an array of [Tween](./#tocs_tween) objects to create a custom animation.
        /// </param>
        public RotateTransformation(
            global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? angle)
        {
            this.Angle = angle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateTransformation" /> class.
        /// </summary>
        public RotateTransformation()
        {
        }
    }
}