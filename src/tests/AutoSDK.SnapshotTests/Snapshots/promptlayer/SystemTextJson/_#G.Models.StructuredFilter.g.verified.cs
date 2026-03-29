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
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StructuredFilterFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StructuredFilterField Field { get; set; }

        /// <summary>
        /// The comparison operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StructuredFilterOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StructuredFilterOperator Operator { get; set; }

        /// <summary>
        /// The value to compare against. Type depends on the field and operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, double?, bool?, byte[], object>))]
        public global::G.OneOf<string, double?, bool?, byte[], object>? Value { get; set; }

        /// <summary>
        /// Required for nested fields (metadata, output, input_variables). Specifies which key within the nested object to filter on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nested_key")]
        public string? NestedKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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