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
        [global::System.Text.Json.Serialization.JsonPropertyName("angle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::G.Tween>>))]
        public global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? Angle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateTransformation" /> class.
        /// </summary>
        /// <param name="angle">
        /// Rotate a clip by the specified angle in degrees. Use a number or an array of [Tween](./#tocs_tween) objects to create a custom animation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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