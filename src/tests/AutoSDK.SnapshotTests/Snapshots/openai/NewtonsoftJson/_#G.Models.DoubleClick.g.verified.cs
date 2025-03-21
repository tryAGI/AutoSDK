//HintName: G.Models.DoubleClick.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A double click action.
    /// </summary>
    public sealed partial class DoubleClick
    {
        /// <summary>
        /// Specifies the event type. For a double click action, this property is <br/>
        /// always set to `double_click`.<br/>
        /// Default Value: double_click
        /// </summary>
        /// <default>global::G.DoubleClickType.DoubleClick</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DoubleClickType Type { get; set; } = global::G.DoubleClickType.DoubleClick;

        /// <summary>
        /// The x-coordinate where the double click occurred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x", Required = global::Newtonsoft.Json.Required.Always)]
        public int X { get; set; } = default!;

        /// <summary>
        /// The y-coordinate where the double click occurred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y", Required = global::Newtonsoft.Json.Required.Always)]
        public int Y { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleClick" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a double click action, this property is <br/>
        /// always set to `double_click`.<br/>
        /// Default Value: double_click
        /// </param>
        /// <param name="x">
        /// The x-coordinate where the double click occurred.
        /// </param>
        /// <param name="y">
        /// The y-coordinate where the double click occurred.
        /// </param>
        public DoubleClick(
            int x,
            int y,
            global::G.DoubleClickType type = global::G.DoubleClickType.DoubleClick)
        {
            this.X = x;
            this.Y = y;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DoubleClick" /> class.
        /// </summary>
        public DoubleClick()
        {
        }
    }
}