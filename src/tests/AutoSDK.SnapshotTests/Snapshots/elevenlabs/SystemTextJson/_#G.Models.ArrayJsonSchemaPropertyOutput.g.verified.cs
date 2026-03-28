//HintName: G.Models.ArrayJsonSchemaPropertyOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArrayJsonSchemaPropertyOutput
    {
        /// <summary>
        /// Default Value: array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyOutput, global::G.ArrayJsonSchemaPropertyOutput>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyOutput, global::G.ArrayJsonSchemaPropertyOutput> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayJsonSchemaPropertyOutput" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="type">
        /// Default Value: array
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArrayJsonSchemaPropertyOutput(
            global::G.OneOf<global::G.LiteralJsonSchemaProperty, global::G.ObjectJsonSchemaPropertyOutput, global::G.ArrayJsonSchemaPropertyOutput> items,
            string? type,
            string? description)
        {
            this.Type = type;
            this.Description = description;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayJsonSchemaPropertyOutput" /> class.
        /// </summary>
        public ArrayJsonSchemaPropertyOutput()
        {
        }
    }
}