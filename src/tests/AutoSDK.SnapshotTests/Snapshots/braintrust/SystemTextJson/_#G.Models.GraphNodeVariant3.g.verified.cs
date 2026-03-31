//HintName: G.Models.GraphNodeVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphNodeVariant3
    {
        /// <summary>
        /// The description of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The position of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public global::G.GraphNodeVariant3Position? Position { get; set; }

        /// <summary>
        /// The output of the graph
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraphNodeVariant3TypeJsonConverter))]
        public global::G.GraphNodeVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant3" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the node
        /// </param>
        /// <param name="position">
        /// The position of the node
        /// </param>
        /// <param name="type">
        /// The output of the graph
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphNodeVariant3(
            string? description,
            global::G.GraphNodeVariant3Position? position,
            global::G.GraphNodeVariant3Type type)
        {
            this.Description = description;
            this.Position = position;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant3" /> class.
        /// </summary>
        public GraphNodeVariant3()
        {
        }
    }
}