//HintName: G.Models.JsonSchemaSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specification wrapper for a named JSON schema.
    /// </summary>
    public sealed partial class JsonSchemaSpec
    {
        /// <summary>
        /// A description of what the response format is for, used by the model to determine how to respond in the format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A unique name identifier for this schema.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// When true, enforces strict schema adherence. The model will always follow the exact schema structure.<br/>
        /// When strict mode is enabled, the schema must follow these rules:<br/>
        /// - `additionalProperties: false` must be set on all object types<br/>
        /// - All properties must be listed in the `required` array<br/>
        /// - Maximum 100 properties total, with max 5 levels of nesting<br/>
        /// - Unsupported keywords: minLength, maxLength, pattern, minimum, maximum, minItems, maxItems<br/>
        /// - Root schema cannot use `anyOf` type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// A JSON Schema definition for specifying data structure. Supports recursive schemas for nested objects.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.JsonSchemaDefinition Schema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaSpec" /> class.
        /// </summary>
        /// <param name="name">
        /// A unique name identifier for this schema.
        /// </param>
        /// <param name="schema">
        /// A JSON Schema definition for specifying data structure. Supports recursive schemas for nested objects.
        /// </param>
        /// <param name="description">
        /// A description of what the response format is for, used by the model to determine how to respond in the format.
        /// </param>
        /// <param name="strict">
        /// When true, enforces strict schema adherence. The model will always follow the exact schema structure.<br/>
        /// When strict mode is enabled, the schema must follow these rules:<br/>
        /// - `additionalProperties: false` must be set on all object types<br/>
        /// - All properties must be listed in the `required` array<br/>
        /// - Maximum 100 properties total, with max 5 levels of nesting<br/>
        /// - Unsupported keywords: minLength, maxLength, pattern, minimum, maximum, minItems, maxItems<br/>
        /// - Root schema cannot use `anyOf` type
        /// </param>
        public JsonSchemaSpec(
            string name,
            global::G.JsonSchemaDefinition schema,
            string? description,
            bool? strict)
        {
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Strict = strict;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonSchemaSpec" /> class.
        /// </summary>
        public JsonSchemaSpec()
        {
        }
    }
}