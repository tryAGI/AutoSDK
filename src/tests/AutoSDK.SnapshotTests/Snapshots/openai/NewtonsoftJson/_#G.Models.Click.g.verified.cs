//HintName: G.Models.Click.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A click action.
    /// </summary>
    public sealed partial class Click
    {
        /// <summary>
        /// Specifies the event type. For a click action, this property is <br/>
        /// always set to `click`.<br/>
        /// Default Value: click
        /// </summary>
        /// <default>global::G.ClickType.Click</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ClickType Type { get; set; } = global::G.ClickType.Click;

        /// <summary>
        /// Indicates which mouse button was pressed during the click. One of `left`, `right`, `wheel`, `back`, or `forward`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("button", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ClickButton Button { get; set; } = default!;

        /// <summary>
        /// The x-coordinate where the click occurred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x", Required = global::Newtonsoft.Json.Required.Always)]
        public int X { get; set; } = default!;

        /// <summary>
        /// The y-coordinate where the click occurred.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y", Required = global::Newtonsoft.Json.Required.Always)]
        public int Y { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Click" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a click action, this property is <br/>
        /// always set to `click`.<br/>
        /// Default Value: click
        /// </param>
        /// <param name="button">
        /// Indicates which mouse button was pressed during the click. One of `left`, `right`, `wheel`, `back`, or `forward`.
        /// </param>
        /// <param name="x">
        /// The x-coordinate where the click occurred.
        /// </param>
        /// <param name="y">
        /// The y-coordinate where the click occurred.
        /// </param>
        public Click(
            global::G.ClickButton button,
            int x,
            int y,
            global::G.ClickType type = global::G.ClickType.Click)
        {
            this.Button = button;
            this.X = x;
            this.Y = y;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Click" /> class.
        /// </summary>
        public Click()
        {
        }
    }
}