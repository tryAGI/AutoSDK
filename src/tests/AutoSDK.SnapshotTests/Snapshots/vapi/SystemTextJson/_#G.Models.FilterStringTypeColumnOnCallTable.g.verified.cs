//HintName: G.Models.FilterStringTypeColumnOnCallTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterStringTypeColumnOnCallTable
    {
        /// <summary>
        /// This is the column in the call table that will be filtered on.<br/>
        /// String Type columns are columns where the rows store data as a string.<br/>
        /// Must be a valid column for the selected table.<br/>
        /// Example: assistant_id
        /// </summary>
        /// <example>assistant_id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterStringTypeColumnOnCallTableColumnJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterStringTypeColumnOnCallTableColumn Column { get; set; }

        /// <summary>
        /// This is the operator to use for the filter.<br/>
        /// For string type columns, the operator must be "=", "!=", "contains", "not contains"<br/>
        /// Example: "=" or "!="
        /// </summary>
        /// <example>"=" or "!="</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilterStringTypeColumnOnCallTableOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FilterStringTypeColumnOnCallTableOperator Operator { get; set; }

        /// <summary>
        /// This is the value to filter on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterStringTypeColumnOnCallTable" /> class.
        /// </summary>
        /// <param name="column">
        /// This is the column in the call table that will be filtered on.<br/>
        /// String Type columns are columns where the rows store data as a string.<br/>
        /// Must be a valid column for the selected table.<br/>
        /// Example: assistant_id
        /// </param>
        /// <param name="operator">
        /// This is the operator to use for the filter.<br/>
        /// For string type columns, the operator must be "=", "!=", "contains", "not contains"<br/>
        /// Example: "=" or "!="
        /// </param>
        /// <param name="value">
        /// This is the value to filter on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FilterStringTypeColumnOnCallTable(
            global::G.FilterStringTypeColumnOnCallTableColumn column,
            global::G.FilterStringTypeColumnOnCallTableOperator @operator,
            string value)
        {
            this.Column = column;
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterStringTypeColumnOnCallTable" /> class.
        /// </summary>
        public FilterStringTypeColumnOnCallTable()
        {
        }
    }
}