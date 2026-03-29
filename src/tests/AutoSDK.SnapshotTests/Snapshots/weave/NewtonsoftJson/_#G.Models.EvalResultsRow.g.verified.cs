//HintName: G.Models.EvalResultsRow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalResultsRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("row_digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string RowDigest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw_data_row")]
        public object? RawDataRow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluations")]
        public global::System.Collections.Generic.IList<global::G.EvalResultsRowEvaluation>? Evaluations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsRow" /> class.
        /// </summary>
        /// <param name="rowDigest"></param>
        /// <param name="rawDataRow"></param>
        /// <param name="evaluations"></param>
        public EvalResultsRow(
            string rowDigest,
            object? rawDataRow,
            global::System.Collections.Generic.IList<global::G.EvalResultsRowEvaluation>? evaluations)
        {
            this.RowDigest = rowDigest ?? throw new global::System.ArgumentNullException(nameof(rowDigest));
            this.RawDataRow = rawDataRow;
            this.Evaluations = evaluations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalResultsRow" /> class.
        /// </summary>
        public EvalResultsRow()
        {
        }
    }
}