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
        [global::Newtonsoft.Json.JsonProperty("x")]
        public global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? X { get; set; }

        /// <summary>
        /// Skew the clip along it's y axis.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y")]
        public global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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