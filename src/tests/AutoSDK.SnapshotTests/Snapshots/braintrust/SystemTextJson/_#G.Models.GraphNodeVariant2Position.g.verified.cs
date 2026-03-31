//HintName: G.Models.GraphNodeVariant2Position.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The position of the node
    /// </summary>
    public sealed partial class GraphNodeVariant2Position
    {
        /// <summary>
        /// The x position of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double X { get; set; }

        /// <summary>
        /// The y position of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Y { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant2Position" /> class.
        /// </summary>
        /// <param name="x">
        /// The x position of the node
        /// </param>
        /// <param name="y">
        /// The y position of the node
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphNodeVariant2Position(
            double x,
            double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant2Position" /> class.
        /// </summary>
        public GraphNodeVariant2Position()
        {
        }
    }
}