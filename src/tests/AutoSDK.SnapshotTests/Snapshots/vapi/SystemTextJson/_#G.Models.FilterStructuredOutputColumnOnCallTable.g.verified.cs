//HintName: G.Models.FilterStructuredOutputColumnOnCallTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterStructuredOutputColumnOnCallTable
    {
        /// <summary>
        /// This is the column in the call table that will be filtered on.<br/>
        /// Structured Output Type columns are only to filter on artifact.structuredOutputs[OutputID] column.<br/>
        /// Example: artifact.structuredOutputs[OutputID]
        /// </summary>
        /// <example>artifact.structuredOutputs[OutputID]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterStructuredOutputColumnOnCallTableColumnJsonConverter))]
        public global::G.FilterStructuredOutputColumnOnCallTableColumn Column { get; set; }

        /// <summary>
        /// This is the operator to use for the filter.<br/>
        /// The operator depends on the value type of the structured output.<br/>
        /// If the structured output is a string or boolean, the operator must be "=", "!="<br/>
        /// If the structured output is a number, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="<br/>
        /// If the structured output is an array, the operator must be "in" or "not_in"<br/>
        /// Example: "=" or "&gt;" or "&lt;" or "in" or "not_in"
        /// </summary>
        /// <example>"=" or "&gt;" or "&lt;" or "in" or "not_in"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterStructuredOutputColumnOnCallTableOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterStructuredOutputColumnOnCallTableOperator Operator { get; set; }

        /// <summary>
        /// This is the value to filter on.<br/>
        /// The value type depends on the structured output type being filtered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterStructuredOutputColumnOnCallTable" /> class.
        /// </summary>
        /// <param name="operator">
        /// This is the operator to use for the filter.<br/>
        /// The operator depends on the value type of the structured output.<br/>
        /// If the structured output is a string or boolean, the operator must be "=", "!="<br/>
        /// If the structured output is a number, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="<br/>
        /// If the structured output is an array, the operator must be "in" or "not_in"<br/>
        /// Example: "=" or "&gt;" or "&lt;" or "in" or "not_in"
        /// </param>
        /// <param name="value">
        /// This is the value to filter on.<br/>
        /// The value type depends on the structured output type being filtered.
        /// </param>
        /// <param name="column">
        /// This is the column in the call table that will be filtered on.<br/>
        /// Structured Output Type columns are only to filter on artifact.structuredOutputs[OutputID] column.<br/>
        /// Example: artifact.structuredOutputs[OutputID]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterStructuredOutputColumnOnCallTable(
            global::G.FilterStructuredOutputColumnOnCallTableOperator @operator,
            object value,
            global::G.FilterStructuredOutputColumnOnCallTableColumn column)
        {
            this.Column = column;
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterStructuredOutputColumnOnCallTable" /> class.
        /// </summary>
        public FilterStructuredOutputColumnOnCallTable()
        {
        }
    }
}