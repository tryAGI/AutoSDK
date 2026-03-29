//HintName: G.Models.ExperimentTableColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentTableColumn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columnName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columnType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hypothesisId")]
        public string? HypothesisId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cells", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExperimentTableColumnCell> Cells { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.RecordStringAny? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentTableColumn" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="columnName"></param>
        /// <param name="columnType"></param>
        /// <param name="cells"></param>
        /// <param name="hypothesisId"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        public ExperimentTableColumn(
            string id,
            string columnName,
            string columnType,
            global::System.Collections.Generic.IList<global::G.ExperimentTableColumnCell> cells,
            string? hypothesisId,
            global::G.RecordStringAny? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ColumnName = columnName ?? throw new global::System.ArgumentNullException(nameof(columnName));
            this.ColumnType = columnType ?? throw new global::System.ArgumentNullException(nameof(columnType));
            this.HypothesisId = hypothesisId;
            this.Cells = cells ?? throw new global::System.ArgumentNullException(nameof(cells));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentTableColumn" /> class.
        /// </summary>
        public ExperimentTableColumn()
        {
        }
    }
}