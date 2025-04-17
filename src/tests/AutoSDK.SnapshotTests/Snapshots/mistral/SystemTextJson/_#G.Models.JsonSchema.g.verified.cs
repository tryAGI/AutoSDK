//HintName: G.Models.JsonSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchema" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="name"></param>
        /// <param name="schema"></param>
        /// <param name="strict">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonSchema(
            string name,
            object schema,
            string? description,
            bool? strict)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Description = description;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchema" /> class.
        /// </summary>
        public JsonSchema()
        {
        }
    }
}