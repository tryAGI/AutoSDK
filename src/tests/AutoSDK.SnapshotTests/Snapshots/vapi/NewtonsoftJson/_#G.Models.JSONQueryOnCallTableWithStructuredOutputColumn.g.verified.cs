//HintName: G.Models.JSONQueryOnCallTableWithStructuredOutputColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JSONQueryOnCallTableWithStructuredOutputColumn
    {
        /// <summary>
        /// This is the type of query. Only allowed type is "vapiql-json".<br/>
        /// Example: vapiql-json
        /// </summary>
        /// <example>vapiql-json</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnTypeJsonConverter))]
        public global::G.JSONQueryOnCallTableWithStructuredOutputColumnType Type { get; set; }

        /// <summary>
        /// This is the table that will be queried.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("table")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnTableJsonConverter))]
        public global::G.JSONQueryOnCallTableWithStructuredOutputColumnTable Table { get; set; }

        /// <summary>
        /// This is the filters to apply to the insight.<br/>
        /// The discriminator automatically selects the correct filter type based on column and operator.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filters")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.FilterStringTypeColumnOnCallTable, global::G.FilterStringArrayTypeColumnOnCallTable, global::G.FilterNumberTypeColumnOnCallTable, global::G.FilterNumberArrayTypeColumnOnCallTable, global::G.FilterDateTypeColumnOnCallTable, global::G.FilterStructuredOutputColumnOnCallTable>>? Filters { get; set; }

        /// <summary>
        /// This is the column that will be queried in the call table.<br/>
        /// Structured Output Type columns are only to query on artifact.structuredOutputs[OutputID] column.<br/>
        /// Example: artifact.structuredOutputs[OutputID]
        /// </summary>
        /// <example>artifact.structuredOutputs[OutputID]</example>
        [global::Newtonsoft.Json.JsonProperty("column")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnColumnJsonConverter))]
        public global::G.JSONQueryOnCallTableWithStructuredOutputColumnColumn Column { get; set; }

        /// <summary>
        /// This is the aggregation operation to perform on the column.<br/>
        /// When the column is a structured output type, the operation depends on the value of the structured output.<br/>
        /// If the structured output is a string or boolean, the operation must be "count".<br/>
        /// If the structured output is a number, the operation can be "average", "sum", "min", or "max".<br/>
        /// Example: count
        /// </summary>
        /// <example>count</example>
        [global::Newtonsoft.Json.JsonProperty("operation", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnOperationJsonConverter))]
        public global::G.JSONQueryOnCallTableWithStructuredOutputColumnOperation Operation { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="JSONQueryOnCallTableWithStructuredOutputColumn" /> class.
        /// </summary>
        /// <param name="operation">
        /// This is the aggregation operation to perform on the column.<br/>
        /// When the column is a structured output type, the operation depends on the value of the structured output.<br/>
        /// If the structured output is a string or boolean, the operation must be "count".<br/>
        /// If the structured output is a number, the operation can be "average", "sum", "min", or "max".<br/>
        /// Example: count
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
        /// <param name="column">
        /// This is the column that will be queried in the call table.<br/>
        /// Structured Output Type columns are only to query on artifact.structuredOutputs[OutputID] column.<br/>
        /// Example: artifact.structuredOutputs[OutputID]
        /// </param>
        /// <param name="name">
        /// This is the name of the query.<br/>
        /// It will be used to label the query in the insight board on the UI.<br/>
        /// Example: Total Calls
        /// </param>
        public JSONQueryOnCallTableWithStructuredOutputColumn(
            global::G.JSONQueryOnCallTableWithStructuredOutputColumnOperation operation,
            global::G.JSONQueryOnCallTableWithStructuredOutputColumnType type,
            global::G.JSONQueryOnCallTableWithStructuredOutputColumnTable table,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.FilterStringTypeColumnOnCallTable, global::G.FilterStringArrayTypeColumnOnCallTable, global::G.FilterNumberTypeColumnOnCallTable, global::G.FilterNumberArrayTypeColumnOnCallTable, global::G.FilterDateTypeColumnOnCallTable, global::G.FilterStructuredOutputColumnOnCallTable>>? filters,
            global::G.JSONQueryOnCallTableWithStructuredOutputColumnColumn column,
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
        /// Initializes a new instance of the <see cref="JSONQueryOnCallTableWithStructuredOutputColumn" /> class.
        /// </summary>
        public JSONQueryOnCallTableWithStructuredOutputColumn()
        {
        }
    }
}