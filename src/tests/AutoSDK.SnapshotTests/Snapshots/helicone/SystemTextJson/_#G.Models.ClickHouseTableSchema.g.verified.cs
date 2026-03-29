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
        [global::System.Text.Json.Serialization.JsonPropertyName("table_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TableName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ClickHouseTableColumn> Columns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClickHouseTableSchema" /> class.
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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