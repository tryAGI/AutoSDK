//HintName: G.Models.EvaluationStatusRunning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationStatusRunning
    {
        /// <summary>
        /// Default Value: running
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completed_rows", Required = global::Newtonsoft.Json.Required.Always)]
        public int CompletedRows { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_rows", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalRows { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusRunning" /> class.
        /// </summary>
        /// <param name="completedRows"></param>
        /// <param name="totalRows"></param>
        /// <param name="code">
        /// Default Value: running
        /// </param>
        public EvaluationStatusRunning(
            int completedRows,
            int totalRows,
            string? code)
        {
            this.Code = code;
            this.CompletedRows = completedRows;
            this.TotalRows = totalRows;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusRunning" /> class.
        /// </summary>
        public EvaluationStatusRunning()
        {
        }
    }
}