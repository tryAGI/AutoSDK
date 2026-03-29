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
        [global::Newtonsoft.Json.JsonProperty("column", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterStringTypeColumnOnCallTableColumn Column { get; set; } = default!;

        /// <summary>
        /// This is the operator to use for the filter.<br/>
        /// For string type columns, the operator must be "=", "!=", "contains", "not contains"<br/>
        /// Example: "=" or "!="
        /// </summary>
        /// <example>"=" or "!="</example>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterStringTypeColumnOnCallTableOperator Operator { get; set; } = default!;

        /// <summary>
        /// This is the value to filter on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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