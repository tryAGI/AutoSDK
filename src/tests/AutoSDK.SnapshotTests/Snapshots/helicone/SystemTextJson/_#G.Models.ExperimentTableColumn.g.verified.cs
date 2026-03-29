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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hypothesisId")]
        public string? HypothesisId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cells")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExperimentTableColumnCell> Cells { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.RecordStringAny? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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