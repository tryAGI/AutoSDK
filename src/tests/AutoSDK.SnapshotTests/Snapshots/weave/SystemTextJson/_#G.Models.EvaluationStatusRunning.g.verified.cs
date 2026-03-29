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
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletedRows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRows { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusRunning" /> class.
        /// </summary>
        /// <param name="completedRows"></param>
        /// <param name="totalRows"></param>
        /// <param name="code">
        /// Default Value: running
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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