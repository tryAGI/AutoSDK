//HintName: G.Models.SkewTransformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Skew a clip so its edges are sheared at an angle. Use values between -100 and 100. Values over 3 or under -3 will skew the clip almost flat.
    /// </summary>
    public sealed partial class SkewTransformation
    {
        /// <summary>
        /// Skew the clip along it's x axis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::G.Tween>>))]
        public global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? X { get; set; }

        /// <summary>
        /// Skew the clip along it's y axis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<float?, global::System.Collections.Generic.IList<global::G.Tween>>))]
        public global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkewTransformation" /> class.
        /// </summary>
        /// <param name="x">
        /// Skew the clip along it's x axis.
        /// </param>
        /// <param name="y">
        /// Skew the clip along it's y axis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SkewTransformation(
            global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? x,
            global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkewTransformation" /> class.
        /// </summary>
        public SkewTransformation()
        {
        }
    }
}