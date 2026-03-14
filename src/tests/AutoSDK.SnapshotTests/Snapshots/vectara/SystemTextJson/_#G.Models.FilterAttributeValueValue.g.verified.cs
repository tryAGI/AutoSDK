//HintName: G.Models.FilterAttributeValueValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The actual value from the metadata field. Type depends on the filter attribute type (string for text, number for integer/real_number, boolean for boolean).<br/>
    /// Example: contract
    /// </summary>
    public sealed partial class FilterAttributeValueValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}