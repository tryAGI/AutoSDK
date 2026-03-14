//HintName: G.Models.FilterAttributeValue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single distinct value and its occurrence count within the faceted field.
    /// </summary>
    public sealed partial class FilterAttributeValue
    {
        /// <summary>
        /// The actual value from the metadata field. Type depends on the filter attribute type (string for text, number for integer/real_number, boolean for boolean).<br/>
        /// Example: contract
        /// </summary>
        /// <example>contract</example>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public object Value { get; set; } = default!;

        /// <summary>
        /// Number of documents or parts (depending on the filter attribute level) that contain this value. For list-type attributes, a single document may contribute to multiple value counts.<br/>
        /// Example: 42
        /// </summary>
        /// <example>42</example>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public long Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttributeValue" /> class.
        /// </summary>
        /// <param name="value">
        /// The actual value from the metadata field. Type depends on the filter attribute type (string for text, number for integer/real_number, boolean for boolean).<br/>
        /// Example: contract
        /// </param>
        /// <param name="count">
        /// Number of documents or parts (depending on the filter attribute level) that contain this value. For list-type attributes, a single document may contribute to multiple value counts.<br/>
        /// Example: 42
        /// </param>
        public FilterAttributeValue(
            object value,
            long count)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterAttributeValue" /> class.
        /// </summary>
        public FilterAttributeValue()
        {
        }
    }
}