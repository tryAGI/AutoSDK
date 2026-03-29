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
        [global::Newtonsoft.Json.JsonProperty("rowId", Required = global::Newtonsoft.Json.Required.Always)]
        public string RowId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputRecord", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExperimentDatasetRowInputRecord InputRecord { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rowIndex", Required = global::Newtonsoft.Json.Required.Always)]
        public double RowIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("columnId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ColumnId { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.Score2> Scores { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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