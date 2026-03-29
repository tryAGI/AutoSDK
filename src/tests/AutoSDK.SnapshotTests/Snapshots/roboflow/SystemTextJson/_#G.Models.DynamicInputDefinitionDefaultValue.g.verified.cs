//HintName: G.Models.DynamicInputDefinitionDefaultValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Definition of default value for a field. Use in combination with, `has_default_value` to decide on default value if field is optional.
    /// </summary>
    public sealed partial class DynamicInputDefinitionDefaultValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}