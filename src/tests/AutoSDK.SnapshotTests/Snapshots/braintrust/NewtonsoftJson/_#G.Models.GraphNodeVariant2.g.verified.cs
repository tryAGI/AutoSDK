//HintName: G.Models.GraphNodeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphNodeVariant2
    {
        /// <summary>
        /// The description of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The position of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("position")]
        public global::G.GraphNodeVariant2Position? Position { get; set; }

        /// <summary>
        /// The input to the graph
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GraphNodeVariant2TypeJsonConverter))]
        public global::G.GraphNodeVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant2" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the node
        /// </param>
        /// <param name="position">
        /// The position of the node
        /// </param>
        /// <param name="type">
        /// The input to the graph
        /// </param>
        public GraphNodeVariant2(
            string? description,
            global::G.GraphNodeVariant2Position? position,
            global::G.GraphNodeVariant2Type type)
        {
            this.Description = description;
            this.Position = position;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant2" /> class.
        /// </summary>
        public GraphNodeVariant2()
        {
        }
    }
}