//HintName: G.Models.GraphNodeVariant4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphNodeVariant4
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
        public global::G.GraphNodeVariant4Position? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GraphNodeVariant4Type Type { get; set; }

        /// <summary>
        /// A literal value to be returned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant4" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the node
        /// </param>
        /// <param name="position">
        /// The position of the node
        /// </param>
        /// <param name="type"></param>
        /// <param name="value">
        /// A literal value to be returned
        /// </param>
        public GraphNodeVariant4(
            string? description,
            global::G.GraphNodeVariant4Position? position,
            global::G.GraphNodeVariant4Type type,
            object? value)
        {
            this.Description = description;
            this.Position = position;
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant4" /> class.
        /// </summary>
        public GraphNodeVariant4()
        {
        }
    }
}