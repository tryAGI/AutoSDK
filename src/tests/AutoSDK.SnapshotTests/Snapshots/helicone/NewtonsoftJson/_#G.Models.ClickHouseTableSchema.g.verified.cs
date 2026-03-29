//HintName: G.Models.ClickHouseTableSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClickHouseTableSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("table_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TableName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columns", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ClickHouseTableColumn> Columns { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickHouseTableSchema" /> class.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columns"></param>
        public ClickHouseTableSchema(
            string tableName,
            global::System.Collections.Generic.IList<global::G.ClickHouseTableColumn> columns)
        {
            this.TableName = tableName ?? throw new global::System.ArgumentNullException(nameof(tableName));
            this.Columns = columns ?? throw new global::System.ArgumentNullException(nameof(columns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickHouseTableSchema" /> class.
        /// </summary>
        public ClickHouseTableSchema()
        {
        }
    }
}