//HintName: G.Models.Offset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Offsets the position of an asset horizontally or vertically by a relative distance.
    /// </summary>
    public sealed partial class Offset
    {
        /// <summary>
        /// Offset an asset on the horizontal axis (left or right). Use a number or an array of [Tween](./#tocs_tween) objects to create a custom animation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x")]
        public global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? X { get; set; }

        /// <summary>
        /// Offset an asset on the vertical axis (up or down). Use a number or an array of [Tween](./#tocs_tween) objects to create a custom animation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y")]
        public global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Offset" /> class.
        /// </summary>
        /// <param name="x">
        /// Offset an asset on the horizontal axis (left or right). Use a number or an array of [Tween](./#tocs_tween) objects to create a custom animation.
        /// </param>
        /// <param name="y">
        /// Offset an asset on the vertical axis (up or down). Use a number or an array of [Tween](./#tocs_tween) objects to create a custom animation.
        /// </param>
        public Offset(
            global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? x,
            global::G.OneOf<float?, global::System.Collections.Generic.IList<global::G.Tween>>? y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Offset" /> class.
        /// </summary>
        public Offset()
        {
        }
    }
}