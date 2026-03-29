//HintName: G.Models.EvalResultsQueryRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalResultsQueryRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EvalResultsRow> Rows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::G.EvalResultsSummaryRes? Summary { get; set; }

        /// <summary>
        /// Non-fatal warnings (e.g. failed to resolve dataset row refs).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<string>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsQueryRes" /> class.
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="totalRows"></param>
        /// <param name="summary"></param>
        /// <param name="warnings">
        /// Non-fatal warnings (e.g. failed to resolve dataset row refs).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalResultsQueryRes(
            global::System.Collections.Generic.IList<global::G.EvalResultsRow> rows,
            int totalRows,
            global::G.EvalResultsSummaryRes? summary,
            global::System.Collections.Generic.IList<string>? warnings)
        {
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
            this.TotalRows = totalRows;
            this.Summary = summary;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsQueryRes" /> class.
        /// </summary>
        public EvalResultsQueryRes()
        {
        }
    }
}