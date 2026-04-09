//HintName: G.Models.JSONQueryOnCallTableWithNumberTypeColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JSONQueryOnCallTableWithNumberTypeColumn
    {
        /// <summary>
        /// This is the type of query. Only allowed type is "vapiql-json".<br/>
        /// Example: vapiql-json
        /// </summary>
        /// <example>vapiql-json</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnTypeJsonConverter))]
        public global::G.JSONQueryOnCallTableWithNumberTypeColumnType Type { get; set; }

        /// <summary>
        /// This is the table that will be queried.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("table")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnTableJsonConverter))]
        public global::G.JSONQueryOnCallTableWithNumberTypeColumnTable Table { get; set; }

        /// <summary>
        /// This is the filters to apply to the insight.<br/>
        /// The discriminator automatically selects the correct filter type based on column and operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.FilterStringTypeColumnOnCallTable, global::G.FilterStringArrayTypeColumnOnCallTable, global::G.FilterNumberTypeColumnOnCallTable, global::G.FilterNumberArrayTypeColumnOnCallTable, global::G.FilterDateTypeColumnOnCallTable, global::G.FilterStructuredOutputColumnOnCallTable>>? Filters { get; set; }

        /// <summary>
        /// This is the column that will be queried in the selected table.<br/>
        /// Available columns depend on the selected table.<br/>
        /// Number Type columns are columns where the rows store Number data<br/>
        /// Example: duration
        /// </summary>
        /// <example>duration</example>
        [global::Newtonsoft.Json.JsonProperty("column", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnColumnJsonConverter))]
        public global::G.JSONQueryOnCallTableWithNumberTypeColumnColumn Column { get; set; } = default!;

        /// <summary>
        /// This is the aggregation operation to perform on the column.<br/>
        /// When the column is a number type, the operation must be one of the following:<br/>
        /// - average<br/>
        /// - sum<br/>
        /// - min<br/>
        /// - max<br/>
        /// Example: sum
        /// </summary>
        /// <example>sum</example>
        [global::Newtonsoft.Json.JsonProperty("operation", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnOperationJsonConverter))]
        public global::G.JSONQueryOnCallTableWithNumberTypeColumnOperation Operation { get; set; } = default!;

        /// <summary>
        /// This is the name of the query.<br/>
        /// It will be used to label the query in the insight board on the UI.<br/>
        /// Example: Total Calls
        /// </summary>
        /// <example>Total Calls</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONQueryOnCallTableWithNumberTypeColumn" /> class.
        /// </summary>
        /// <param name="column">
        /// This is the column that will be queried in the selected table.<br/>
        /// Available columns depend on the selected table.<br/>
        /// Number Type columns are columns where the rows store Number data<br/>
        /// Example: duration
        /// </param>
        /// <param name="operation">
        /// This is the aggregation operation to perform on the column.<br/>
        /// When the column is a number type, the operation must be one of the following:<br/>
        /// - average<br/>
        /// - sum<br/>
        /// - min<br/>
        /// - max<br/>
        /// Example: sum
        /// </param>
        /// <param name="type">
        /// This is the type of query. Only allowed type is "vapiql-json".<br/>
        /// Example: vapiql-json
        /// </param>
        /// <param name="table">
        /// This is the table that will be queried.
        /// </param>
        /// <param name="filters">
        /// This is the filters to apply to the insight.<br/>
        /// The discriminator automatically selects the correct filter type based on column and operator.
        /// </param>
        /// <param name="name">
        /// This is the name of the query.<br/>
        /// It will be used to label the query in the insight board on the UI.<br/>
        /// Example: Total Calls
        /// </param>
        public JSONQueryOnCallTableWithNumberTypeColumn(
            global::G.JSONQueryOnCallTableWithNumberTypeColumnColumn column,
            global::G.JSONQueryOnCallTableWithNumberTypeColumnOperation operation,
            global::G.JSONQueryOnCallTableWithNumberTypeColumnType type,
            global::G.JSONQueryOnCallTableWithNumberTypeColumnTable table,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.FilterStringTypeColumnOnCallTable, global::G.FilterStringArrayTypeColumnOnCallTable, global::G.FilterNumberTypeColumnOnCallTable, global::G.FilterNumberArrayTypeColumnOnCallTable, global::G.FilterDateTypeColumnOnCallTable, global::G.FilterStructuredOutputColumnOnCallTable>>? filters,
            string? name)
        {
            this.Type = type;
            this.Table = table;
            this.Filters = filters;
            this.Column = column;
            this.Operation = operation;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONQueryOnCallTableWithNumberTypeColumn" /> class.
        /// </summary>
        public JSONQueryOnCallTableWithNumberTypeColumn()
        {
        }
    }
}