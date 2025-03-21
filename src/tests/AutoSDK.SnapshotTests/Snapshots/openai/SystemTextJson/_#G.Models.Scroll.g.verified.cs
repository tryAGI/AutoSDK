//HintName: G.Models.Scroll.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A scroll action.
    /// </summary>
    public sealed partial class Scroll
    {
        /// <summary>
        /// The horizontal scroll distance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scroll_x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScrollX { get; set; }

        /// <summary>
        /// The vertical scroll distance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scroll_y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ScrollY { get; set; }

        /// <summary>
        /// Specifies the event type. For a scroll action, this property is <br/>
        /// always set to `scroll`.<br/>
        /// Default Value: scroll
        /// </summary>
        /// <default>global::G.ScrollType.Scroll</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ScrollTypeJsonConverter))]
        public global::G.ScrollType Type { get; set; } = global::G.ScrollType.Scroll;

        /// <summary>
        /// The x-coordinate where the scroll occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// The y-coordinate where the scroll occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Scroll" /> class.
        /// </summary>
        /// <param name="scrollX">
        /// The horizontal scroll distance.
        /// </param>
        /// <param name="scrollY">
        /// The vertical scroll distance.
        /// </param>
        /// <param name="type">
        /// Specifies the event type. For a scroll action, this property is <br/>
        /// always set to `scroll`.<br/>
        /// Default Value: scroll
        /// </param>
        /// <param name="x">
        /// The x-coordinate where the scroll occurred.
        /// </param>
        /// <param name="y">
        /// The y-coordinate where the scroll occurred.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Scroll(
            int scrollX,
            int scrollY,
            int x,
            int y,
            global::G.ScrollType type = global::G.ScrollType.Scroll)
        {
            this.ScrollX = scrollX;
            this.ScrollY = scrollY;
            this.X = x;
            this.Y = y;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Scroll" /> class.
        /// </summary>
        public Scroll()
        {
        }
    }
}