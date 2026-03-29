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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::System.Collections.Generic.Dictionary<string, object>? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchema" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="strict"></param>
        /// <param name="schema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonSchema(
            string? name,
            bool? strict,
            global::System.Collections.Generic.Dictionary<string, object>? schema)
        {
            this.Name = name;
            this.Strict = strict;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchema" /> class.
        /// </summary>
        public JsonSchema()
        {
        }
    }
}