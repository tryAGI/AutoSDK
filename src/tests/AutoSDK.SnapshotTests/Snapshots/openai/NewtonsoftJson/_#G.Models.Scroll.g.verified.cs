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
        [global::Newtonsoft.Json.JsonProperty("scroll_x", Required = global::Newtonsoft.Json.Required.Always)]
        public int ScrollX { get; set; } = default!;

        /// <summary>
        /// The vertical scroll distance.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scroll_y", Required = global::Newtonsoft.Json.Required.Always)]
        public int ScrollY { get; set; } = default!;

        /// <summary>
        /// Specifies the event type. For a scroll action, this property is <br/>
        /// always set to `scroll`.<br/>
        /// Default Value: scroll
        /// </summary>
        /// <default>global::G.ScrollType.Scroll</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ScrollType Type { get; set; } = global::G.ScrollType.Scroll;

        /// <summary>
        /// The x-coordinate where the scroll occurred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x", Required = global::Newtonsoft.Json.Required.Always)]
        public int X { get; set; } = default!;

        /// <summary>
        /// The y-coordinate where the scroll occurred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y", Required = global::Newtonsoft.Json.Required.Always)]
        public int Y { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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