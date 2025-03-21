//HintName: G.Models.Move.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A mouse move action.
    /// </summary>
    public sealed partial class Move
    {
        /// <summary>
        /// Specifies the event type. For a move action, this property is <br/>
        /// always set to `move`.<br/>
        /// Default Value: move
        /// </summary>
        /// <default>global::G.MoveType.Move</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MoveType Type { get; set; } = global::G.MoveType.Move;

        /// <summary>
        /// The x-coordinate to move to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("x", Required = global::Newtonsoft.Json.Required.Always)]
        public int X { get; set; } = default!;

        /// <summary>
        /// The y-coordinate to move to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y", Required = global::Newtonsoft.Json.Required.Always)]
        public int Y { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Move" /> class.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. For a move action, this property is <br/>
        /// always set to `move`.<br/>
        /// Default Value: move
        /// </param>
        /// <param name="x">
        /// The x-coordinate to move to.
        /// </param>
        /// <param name="y">
        /// The y-coordinate to move to.
        /// </param>
        public Move(
            int x,
            int y,
            global::G.MoveType type = global::G.MoveType.Move)
        {
            this.X = x;
            this.Y = y;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Move" /> class.
        /// </summary>
        public Move()
        {
        }
    }
}