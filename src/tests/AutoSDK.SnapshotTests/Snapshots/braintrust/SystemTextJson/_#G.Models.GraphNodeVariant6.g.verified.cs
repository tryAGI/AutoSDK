//HintName: G.Models.GraphNodeVariant6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphNodeVariant6
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
        public global::G.GraphNodeVariant6Position? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraphNodeVariant6TypeJsonConverter))]
        public global::G.GraphNodeVariant6Type Type { get; set; }

        /// <summary>
        /// A BTQL expression to be evaluated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public string? Condition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant6" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the node
        /// </param>
        /// <param name="position">
        /// The position of the node
        /// </param>
        /// <param name="type"></param>
        /// <param name="condition">
        /// A BTQL expression to be evaluated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GraphNodeVariant6(
            string? description,
            global::G.GraphNodeVariant6Position? position,
            global::G.GraphNodeVariant6Type type,
            string? condition)
        {
            this.Description = description;
            this.Position = position;
            this.Type = type;
            this.Condition = condition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant6" /> class.
        /// </summary>
        public GraphNodeVariant6()
        {
        }
    }
}