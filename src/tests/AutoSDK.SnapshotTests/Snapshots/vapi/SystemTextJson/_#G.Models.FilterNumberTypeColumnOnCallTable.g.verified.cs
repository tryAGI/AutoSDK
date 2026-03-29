//HintName: G.Models.FilterNumberTypeColumnOnCallTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterNumberTypeColumnOnCallTable
    {
        /// <summary>
        /// This is the column in the call table that will be filtered on.<br/>
        /// Number Type columns are columns where the rows store data as a number.<br/>
        /// Must be a valid column for the selected table.<br/>
        /// Example: duration
        /// </summary>
        /// <example>duration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterNumberTypeColumnOnCallTableColumnJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterNumberTypeColumnOnCallTableColumn Column { get; set; }

        /// <summary>
        /// This is the operator to use for the filter.<br/>
        /// For number type columns, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="<br/>
        /// Example: "=" or "&gt;" or "&lt;" or "&gt;=" or "&lt;="
        /// </summary>
        /// <example>"=" or "&gt;" or "&lt;" or "&gt;=" or "&lt;="</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterNumberTypeColumnOnCallTableOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterNumberTypeColumnOnCallTableOperator Operator { get; set; }

        /// <summary>
        /// This is the value to filter on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterNumberTypeColumnOnCallTable" /> class.
        /// </summary>
        /// <param name="column">
        /// This is the column in the call table that will be filtered on.<br/>
        /// Number Type columns are columns where the rows store data as a number.<br/>
        /// Must be a valid column for the selected table.<br/>
        /// Example: duration
        /// </param>
        /// <param name="operator">
        /// This is the operator to use for the filter.<br/>
        /// For number type columns, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="<br/>
        /// Example: "=" or "&gt;" or "&lt;" or "&gt;=" or "&lt;="
        /// </param>
        /// <param name="value">
        /// This is the value to filter on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterNumberTypeColumnOnCallTable(
            global::G.FilterNumberTypeColumnOnCallTableColumn column,
            global::G.FilterNumberTypeColumnOnCallTableOperator @operator,
            double value)
        {
            this.Column = column;
            this.Operator = @operator;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterNumberTypeColumnOnCallTable" /> class.
        /// </summary>
        public FilterNumberTypeColumnOnCallTable()
        {
        }
    }
}