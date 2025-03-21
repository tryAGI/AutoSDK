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
        [global::Newtonsoft.Json.JsonProperty("x", Required = global::Newtonsoft.Json.Required.Always)]
        public int X { get; set; } = default!;

        /// <summary>
        /// The y-coordinate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("y", Required = global::Newtonsoft.Json.Required.Always)]
        public int Y { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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