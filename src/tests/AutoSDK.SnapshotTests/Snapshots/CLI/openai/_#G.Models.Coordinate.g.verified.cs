//HintName: G.Models.Coordinate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An x/y coordinate pair, e.g. `{ x: 100, y: 200 }`.
    /// </summary>
    public sealed partial class Coordinate
    {
        /// <summary>
        /// The x-coordinate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// The y-coordinate.
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
        /// Initializes a new instance of the <see cref="Coordinate" /> class.
        /// </summary>
        /// <param name="x">
        /// The x-coordinate.
        /// </param>
        /// <param name="y">
        /// The y-coordinate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Coordinate(
            int x,
            int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinate" /> class.
        /// </summary>
        public Coordinate()
        {
        }
    }
}