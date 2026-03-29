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
        [global::Newtonsoft.Json.JsonProperty("rows", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvalResultsRow> Rows { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_rows", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalRows { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public global::G.EvalResultsSummaryRes? Summary { get; set; }

        /// <summary>
        /// Non-fatal warnings (e.g. failed to resolve dataset row refs).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warnings")]
        public global::System.Collections.Generic.IList<string>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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