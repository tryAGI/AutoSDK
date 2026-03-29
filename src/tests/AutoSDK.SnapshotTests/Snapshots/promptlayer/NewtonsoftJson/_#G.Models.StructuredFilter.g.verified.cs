//HintName: G.Models.StructuredFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single filter condition on a request log field.
    /// </summary>
    public sealed partial class StructuredFilter
    {
        /// <summary>
        /// The request log field to filter on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StructuredFilterField Field { get; set; } = default!;

        /// <summary>
        /// The comparison operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StructuredFilterOperator Operator { get; set; } = default!;

        /// <summary>
        /// The value to compare against. Type depends on the field and operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public global::G.OneOf<string, double?, bool?, byte[], object>? Value { get; set; }

        /// <summary>
        /// Required for nested fields (metadata, output, input_variables). Specifies which key within the nested object to filter on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nested_key")]
        public string? NestedKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredFilter" /> class.
        /// </summary>
        /// <param name="field">
        /// The request log field to filter on.
        /// </param>
        /// <param name="operator">
        /// The comparison operator.
        /// </param>
        /// <param name="value">
        /// The value to compare against. Type depends on the field and operator.
        /// </param>
        /// <param name="nestedKey">
        /// Required for nested fields (metadata, output, input_variables). Specifies which key within the nested object to filter on.
        /// </param>
        public StructuredFilter(
            global::G.StructuredFilterField field,
            global::G.StructuredFilterOperator @operator,
            global::G.OneOf<string, double?, bool?, byte[], object>? value,
            string? nestedKey)
        {
            this.Field = field;
            this.Operator = @operator;
            this.Value = value;
            this.NestedKey = nestedKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredFilter" /> class.
        /// </summary>
        public StructuredFilter()
        {
        }
    }
}