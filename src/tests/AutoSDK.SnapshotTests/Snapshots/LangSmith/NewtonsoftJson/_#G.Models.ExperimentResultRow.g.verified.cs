//HintName: G.Models.ExperimentResultRow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Class for a single row in the uploaded experiment results.
    /// </summary>
    public sealed partial class ExperimentResultRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("row_id")]
        public global::System.Guid? RowId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public object Inputs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expected_outputs")]
        public object? ExpectedOutputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actual_outputs")]
        public object? ActualOutputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackCreateCoreSchema>? EvaluationScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndTime { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_name")]
        public string? RunName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_metadata")]
        public object? RunMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentResultRow" /> class.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="inputs"></param>
        /// <param name="expectedOutputs"></param>
        /// <param name="actualOutputs"></param>
        /// <param name="evaluationScores"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="runName"></param>
        /// <param name="error"></param>
        /// <param name="runMetadata"></param>
        public ExperimentResultRow(
            object inputs,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Guid? rowId,
            object? expectedOutputs,
            object? actualOutputs,
            global::System.Collections.Generic.IList<global::G.FeedbackCreateCoreSchema>? evaluationScores,
            string? runName,
            string? error,
            object? runMetadata)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.RowId = rowId;
            this.ExpectedOutputs = expectedOutputs;
            this.ActualOutputs = actualOutputs;
            this.EvaluationScores = evaluationScores;
            this.RunName = runName;
            this.Error = error;
            this.RunMetadata = runMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentResultRow" /> class.
        /// </summary>
        public ExperimentResultRow()
        {
        }
    }
}