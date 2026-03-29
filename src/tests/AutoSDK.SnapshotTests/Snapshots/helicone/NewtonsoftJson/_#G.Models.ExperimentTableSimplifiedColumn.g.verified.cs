//HintName: G.Models.ExperimentTableSimplifiedColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentTableSimplifiedColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columnType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columnName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentTableSimplifiedColumn" /> class.
        /// </summary>
        /// <param name="columnType"></param>
        /// <param name="columnName"></param>
        /// <param name="id"></param>
        public ExperimentTableSimplifiedColumn(
            string columnType,
            string columnName,
            string id)
        {
            this.ColumnType = columnType ?? throw new global::System.ArgumentNullException(nameof(columnType));
            this.ColumnName = columnName ?? throw new global::System.ArgumentNullException(nameof(columnName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentTableSimplifiedColumn" /> class.
        /// </summary>
        public ExperimentTableSimplifiedColumn()
        {
        }
    }
}