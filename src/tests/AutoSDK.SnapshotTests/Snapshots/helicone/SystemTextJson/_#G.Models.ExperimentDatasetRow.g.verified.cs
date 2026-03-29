//HintName: G.Models.ExperimentDatasetRow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentDatasetRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputRecord")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExperimentDatasetRowInputRecord InputRecord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowIndex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RowIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ColumnId { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.Score2> Scores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentDatasetRow" /> class.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="inputRecord"></param>
        /// <param name="rowIndex"></param>
        /// <param name="columnId"></param>
        /// <param name="scores">
        /// Construct a type with a set of properties K of type T
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentDatasetRow(
            string rowId,
            global::G.ExperimentDatasetRowInputRecord inputRecord,
            double rowIndex,
            string columnId,
            global::System.Collections.Generic.Dictionary<string, global::G.Score2> scores)
        {
            this.RowId = rowId ?? throw new global::System.ArgumentNullException(nameof(rowId));
            this.InputRecord = inputRecord ?? throw new global::System.ArgumentNullException(nameof(inputRecord));
            this.RowIndex = rowIndex;
            this.ColumnId = columnId ?? throw new global::System.ArgumentNullException(nameof(columnId));
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentDatasetRow" /> class.
        /// </summary>
        public ExperimentDatasetRow()
        {
        }
    }
}