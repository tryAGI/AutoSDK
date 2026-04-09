//HintName: G.Models.FilterStringArrayTypeColumnOnCallTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FilterStringArrayTypeColumnOnCallTable
    {
        /// <summary>
        /// This is the column in the call table that will be filtered on.<br/>
        /// String Array Type columns are the same as String Type columns, but provides the ability to filter on multiple values provided as an array.<br/>
        /// Must be a valid column for the selected table.<br/>
        /// Example: assistant_id
        /// </summary>
        /// <example>assistant_id</example>
        [global::Newtonsoft.Json.JsonProperty("column", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FilterStringArrayTypeColumnOnCallTableColumnJsonConverter))]
        public global::G.FilterStringArrayTypeColumnOnCallTableColumn Column { get; set; } = default!;

        /// <summary>
        /// This is the operator to use for the filter.<br/>
        /// The operator must be `in` or `not_in`.<br/>
        /// Example: "in" or "not_in"
        /// </summary>
        /// <example>"in" or "not_in"</example>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FilterStringArrayTypeColumnOnCallTableOperatorJsonConverter))]
        public global::G.FilterStringArrayTypeColumnOnCallTableOperator Operator { get; set; } = default!;

        /// <summary>
        /// These are the values to filter on.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterStringArrayTypeColumnOnCallTable" /> class.
        /// </summary>
        /// <param name="column">
        /// This is the column in the call table that will be filtered on.<br/>
        /// String Array Type columns are the same as String Type columns, but provides the ability to filter on multiple values provided as an array.<br/>
        /// Must be a valid column for the selected table.<br/>
        /// Example: assistant_id
        /// </param>
        /// <param name="operator">
        /// This is the operator to use for the filter.<br/>
        /// The operator must be `in` or `not_in`.<br/>
        /// Example: "in" or "not_in"
        /// </param>
        /// <param name="value">
        /// These are the values to filter on.
        /// </param>
        public FilterStringArrayTypeColumnOnCallTable(
            global::G.FilterStringArrayTypeColumnOnCallTableColumn column,
            global::G.FilterStringArrayTypeColumnOnCallTableOperator @operator,
            global::System.Collections.Generic.IList<string> value)
        {
            this.Column = column;
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilterStringArrayTypeColumnOnCallTable" /> class.
        /// </summary>
        public FilterStringArrayTypeColumnOnCallTable()
        {
        }
    }
}