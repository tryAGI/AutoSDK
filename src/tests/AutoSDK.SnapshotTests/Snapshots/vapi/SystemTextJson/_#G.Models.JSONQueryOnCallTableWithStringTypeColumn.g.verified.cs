//HintName: G.Models.JSONQueryOnCallTableWithStringTypeColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JSONQueryOnCallTableWithStringTypeColumn
    {
        /// <summary>
        /// This is the type of query. Only allowed type is "vapiql-json".<br/>
        /// Example: vapiql-json
        /// </summary>
        /// <example>vapiql-json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnTypeJsonConverter))]
        public global::G.JSONQueryOnCallTableWithStringTypeColumnType Type { get; set; }

        /// <summary>
        /// This is the table that will be queried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnTableJsonConverter))]
        public global::G.JSONQueryOnCallTableWithStringTypeColumnTable Table { get; set; }

        /// <summary>
        /// This is the filters to apply to the insight.<br/>
        /// The discriminator automatically selects the correct filter type based on column and operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.FilterStringTypeColumnOnCallTable, global::G.FilterStringArrayTypeColumnOnCallTable, global::G.FilterNumberTypeColumnOnCallTable, global::G.FilterNumberArrayTypeColumnOnCallTable, global::G.FilterDateTypeColumnOnCallTable, global::G.FilterStructuredOutputColumnOnCallTable>>? Filters { get; set; }

        /// <summary>
        /// This is the column that will be queried in the selected table.<br/>
        /// Available columns depend on the selected table.<br/>
        /// String Type columns are columns where the rows store String data<br/>
        /// Example: id
        /// </summary>
        /// <example>id</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnColumnJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JSONQueryOnCallTableWithStringTypeColumnColumn Column { get; set; }

        /// <summary>
        /// This is the aggregation operation to perform on the column.<br/>
        /// When the column is a string type, the operation must be "count".<br/>
        /// Example: count
        /// </summary>
        /// <example>count</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnOperationJsonConverter))]
        public global::G.JSONQueryOnCallTableWithStringTypeColumnOperation Operation { get; set; }

        /// <summary>
        /// This is the name of the query.<br/>
        /// It will be used to label the query in the insight board on the UI.<br/>
        /// Example: Total Calls
        /// </summary>
        /// <example>Total Calls</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONQueryOnCallTableWithStringTypeColumn" /> class.
        /// </summary>
        /// <param name="column">
        /// This is the column that will be queried in the selected table.<br/>
        /// Available columns depend on the selected table.<br/>
        /// String Type columns are columns where the rows store String data<br/>
        /// Example: id
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
        /// <param name="operation">
        /// This is the aggregation operation to perform on the column.<br/>
        /// When the column is a string type, the operation must be "count".<br/>
        /// Example: count
        /// </param>
        /// <param name="name">
        /// This is the name of the query.<br/>
        /// It will be used to label the query in the insight board on the UI.<br/>
        /// Example: Total Calls
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JSONQueryOnCallTableWithStringTypeColumn(
            global::G.JSONQueryOnCallTableWithStringTypeColumnColumn column,
            global::G.JSONQueryOnCallTableWithStringTypeColumnType type,
            global::G.JSONQueryOnCallTableWithStringTypeColumnTable table,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.FilterStringTypeColumnOnCallTable, global::G.FilterStringArrayTypeColumnOnCallTable, global::G.FilterNumberTypeColumnOnCallTable, global::G.FilterNumberArrayTypeColumnOnCallTable, global::G.FilterDateTypeColumnOnCallTable, global::G.FilterStructuredOutputColumnOnCallTable>>? filters,
            global::G.JSONQueryOnCallTableWithStringTypeColumnOperation operation,
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
        /// Initializes a new instance of the <see cref="JSONQueryOnCallTableWithStringTypeColumn" /> class.
        /// </summary>
        public JSONQueryOnCallTableWithStringTypeColumn()
        {
        }
    }
}