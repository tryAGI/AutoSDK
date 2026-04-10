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
        [global::Newtonsoft.Json.JsonProperty("column", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FilterNumberArrayTypeColumnOnCallTableColumnJsonConverter))]
        public global::G.FilterNumberArrayTypeColumnOnCallTableColumn Column { get; set; } = default!;

        /// <summary>
        /// This is the operator to use for the filter.<br/>
        /// The operator must be `in` or `not_in`.<br/>
        /// Example: "in" or "not_in"
        /// </summary>
        /// <example>"in" or "not_in"</example>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FilterNumberArrayTypeColumnOnCallTableOperatorJsonConverter))]
        public global::G.FilterNumberArrayTypeColumnOnCallTableOperator Operator { get; set; } = default!;

        /// <summary>
        /// This is the value to filter on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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