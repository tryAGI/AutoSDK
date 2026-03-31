//HintName: G.Models.GraphNodeVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphNodeVariant5
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
        public global::G.GraphNodeVariant5Position? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GraphNodeVariant5TypeJsonConverter))]
        public global::G.GraphNodeVariant5Type Type { get; set; }

        /// <summary>
        /// A BTQL expression to be evaluated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Expr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant5" /> class.
        /// </summary>
        /// <param name="expr">
        /// A BTQL expression to be evaluated
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
        public GraphNodeVariant5(
            string expr,
            string? description,
            global::G.GraphNodeVariant5Position? position,
            global::G.GraphNodeVariant5Type type)
        {
            this.Description = description;
            this.Position = position;
            this.Type = type;
            this.Expr = expr ?? throw new global::System.ArgumentNullException(nameof(expr));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphNodeVariant5" /> class.
        /// </summary>
        public GraphNodeVariant5()
        {
        }
    }
}