//HintName: G.Models.FilterDateTypeColumnOnCallTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterDateTypeColumnOnCallTable
    {
        /// <summary>
        /// This is the column in the call table that will be filtered on.<br/>
        /// Date Type columns are columns where the rows store data as a date.<br/>
        /// Must be a valid column for the selected table.<br/>
        /// Example: created_at
        /// </summary>
        /// <example>created_at</example>
        [global::Newtonsoft.Json.JsonProperty("column", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterDateTypeColumnOnCallTableColumn Column { get; set; } = default!;

        /// <summary>
        /// This is the operator to use for the filter.<br/>
        /// For date type columns, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="<br/>
        /// Example: "=" or "&gt;" or "&lt;" or "&gt;=" or "&lt;="
        /// </summary>
        /// <example>"=" or "&gt;" or "&lt;" or "&gt;=" or "&lt;="</example>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterDateTypeColumnOnCallTableOperator Operator { get; set; } = default!;

        /// <summary>
        /// This is the value to filter on.<br/>
        /// Must be a valid ISO 8601 date-time string.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </summary>
        /// <example>2025-01-01T00:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterDateTypeColumnOnCallTable" /> class.
        /// </summary>
        /// <param name="column">
        /// This is the column in the call table that will be filtered on.<br/>
        /// Date Type columns are columns where the rows store data as a date.<br/>
        /// Must be a valid column for the selected table.<br/>
        /// Example: created_at
        /// </param>
        /// <param name="operator">
        /// This is the operator to use for the filter.<br/>
        /// For date type columns, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="<br/>
        /// Example: "=" or "&gt;" or "&lt;" or "&gt;=" or "&lt;="
        /// </param>
        /// <param name="value">
        /// This is the value to filter on.<br/>
        /// Must be a valid ISO 8601 date-time string.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        public FilterDateTypeColumnOnCallTable(
            global::G.FilterDateTypeColumnOnCallTableColumn column,
            global::G.FilterDateTypeColumnOnCallTableOperator @operator,
            string value)
        {
            this.Column = column;
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterDateTypeColumnOnCallTable" /> class.
        /// </summary>
        public FilterDateTypeColumnOnCallTable()
        {
        }
    }
}