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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DoubleClickTypeJsonConverter))]
        public global::G.DoubleClickType Type { get; set; } = global::G.DoubleClickType.DoubleClick;

        /// <summary>
        /// The x-coordinate where the double click occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// The y-coordinate where the double click occurred.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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