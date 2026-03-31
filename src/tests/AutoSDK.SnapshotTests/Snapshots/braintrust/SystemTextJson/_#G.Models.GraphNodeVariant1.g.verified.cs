//HintName: G.Models.GraphNodeVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphNodeVariant1
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
        public global::G.GraphNodeVariant1Position? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraphNodeVariant1TypeJsonConverter))]
        public global::G.GraphNodeVariant1Type Type { get; set; }

        /// <summary>
        /// Options for identifying a function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant1" /> class.
        /// </summary>
        /// <param name="function">
        /// Options for identifying a function
        /// </param>
        /// <param name="description">
        /// The description of the node
        /// </param>
        /// <param name="position">
        /// The position of the node
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphNodeVariant1(
            global::System.Collections.Generic.Dictionary<string, object?> function,
            string? description,
            global::G.GraphNodeVariant1Position? position,
            global::G.GraphNodeVariant1Type type)
        {
            this.Description = description;
            this.Position = position;
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant1" /> class.
        /// </summary>
        public GraphNodeVariant1()
        {
        }
    }
}