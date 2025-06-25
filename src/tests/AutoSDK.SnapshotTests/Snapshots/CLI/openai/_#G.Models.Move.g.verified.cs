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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MoveTypeJsonConverter))]
        public global::G.MoveType Type { get; set; } = global::G.MoveType.Move;

        /// <summary>
        /// The x-coordinate to move to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// The y-coordinate to move to.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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