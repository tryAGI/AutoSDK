//HintName: G.Models.CreateResearchRequestOutputSchemaProperties2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResearchRequestOutputSchemaProperties2
    {
        /// <summary>
        /// The type of the property. Must be one of: object, string, integer, number, or array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateResearchRequestOutputSchemaPropertiesTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateResearchRequestOutputSchemaPropertiesType Type { get; set; }

        /// <summary>
        /// A description of the property.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Required when type is 'object'. Recursive definition of object properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// Required when type is 'array'. Defines the schema for array items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public object? Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResearchRequestOutputSchemaProperties2" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the property. Must be one of: object, string, integer, number, or array.
        /// </param>
        /// <param name="description">
        /// A description of the property.
        /// </param>
        /// <param name="properties">
        /// Required when type is 'object'. Recursive definition of object properties.
        /// </param>
        /// <param name="items">
        /// Required when type is 'array'. Defines the schema for array items.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResearchRequestOutputSchemaProperties2(
            global::G.CreateResearchRequestOutputSchemaPropertiesType type,
            string description,
            object? properties,
            object? items)
        {
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Properties = properties;
            this.Items = items;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResearchRequestOutputSchemaProperties2" /> class.
        /// </summary>
        public CreateResearchRequestOutputSchemaProperties2()
        {
        }
    }
}