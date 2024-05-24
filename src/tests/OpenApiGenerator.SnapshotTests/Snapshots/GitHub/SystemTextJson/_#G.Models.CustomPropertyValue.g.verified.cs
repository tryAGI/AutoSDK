//HintName: G.Models.CustomPropertyValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom property name and associated value
    /// </summary>
    public sealed partial class CustomPropertyValue
    {
        /// <summary>
        /// The name of the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PropertyName { get; set; }

        /// <summary>
        /// The value assigned to the property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}