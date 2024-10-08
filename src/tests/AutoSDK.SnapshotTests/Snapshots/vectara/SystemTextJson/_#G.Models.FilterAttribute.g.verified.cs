//HintName: G.Models.FilterAttribute.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterAttribute
    {
        /// <summary>
        /// The JSON path of the filter attribute in a document or document part metadata.<br/>
        /// Example: Title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Indicates whether this is a document or document part metadata filter.<br/>
        /// Example: document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterAttributeLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterAttributeLevel Level { get; set; }

        /// <summary>
        /// Description of the filter. May be omitted.<br/>
        /// Example: The title of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Indicates whether an index should be created for the filter. Creating an index will improve query latency when using the filter.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexed")]
        public bool? Indexed { get; set; } = true;

        /// <summary>
        /// The value type of the filter.<br/>
        /// Example: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterAttributeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterAttributeType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}