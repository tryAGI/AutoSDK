//HintName: G.Models.FilterNumberArrayTypeColumnOnCallTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterNumberArrayTypeColumnOnCallTable
    {
        /// <summary>
        /// This is the column in the call table that will be filtered on.<br/>
        /// Number Array Type columns are the same as Number Type columns, but provides the ability to filter on multiple values provided as an array.<br/>
        /// Must be a valid column for the selected table.<br/>
        /// Example: duration
        /// </summary>
        /// <example>duration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterNumberArrayTypeColumnOnCallTableColumnJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterNumberArrayTypeColumnOnCallTableColumn Column { get; set; }

        /// <summary>
        /// This is the operator to use for the filter.<br/>
        /// The operator must be `in` or `not_in`.<br/>
        /// Example: "in" or "not_in"
        /// </summary>
        /// <example>"in" or "not_in"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterNumberArrayTypeColumnOnCallTableOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterNumberArrayTypeColumnOnCallTableOperator Operator { get; set; }

        /// <summary>
        /// This is the value to filter on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterNumberArrayTypeColumnOnCallTable" /> class.
        /// </summary>
        /// <param name="column">
        /// This is the column in the call table that will be filtered on.<br/>
        /// Number Array Type columns are the same as Number Type columns, but provides the ability to filter on multiple values provided as an array.<br/>
        /// Must be a valid column for the selected table.<br/>
        /// Example: duration
        /// </param>
        /// <param name="operator">
        /// This is the operator to use for the filter.<br/>
        /// The operator must be `in` or `not_in`.<br/>
        /// Example: "in" or "not_in"
        /// </param>
        /// <param name="value">
        /// This is the value to filter on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterNumberArrayTypeColumnOnCallTable(
            global::G.FilterNumberArrayTypeColumnOnCallTableColumn column,
            global::G.FilterNumberArrayTypeColumnOnCallTableOperator @operator,
            global::System.Collections.Generic.IList<double> value)
        {
            this.Column = column;
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterNumberArrayTypeColumnOnCallTable" /> class.
        /// </summary>
        public FilterNumberArrayTypeColumnOnCallTable()
        {
        }
    }
}