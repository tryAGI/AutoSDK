//HintName: G.Models.ExperimentRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentRun
    {
        /// <summary>
        /// The ID of the dataset example used in the experiment run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_example_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetExampleId { get; set; }

        /// <summary>
        /// The output of the experiment task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Output { get; set; }

        /// <summary>
        /// The repetition number of the experiment run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetition_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RepetitionNumber { get; set; }

        /// <summary>
        /// The start time of the experiment run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// The end time of the experiment run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// The ID of the corresponding trace (if one exists)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Optional error message if the experiment run encountered an error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The ID of the experiment run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExperimentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentRun" /> class.
        /// </summary>
        /// <param name="datasetExampleId">
        /// The ID of the dataset example used in the experiment run
        /// </param>
        /// <param name="output">
        /// The output of the experiment task
        /// </param>
        /// <param name="repetitionNumber">
        /// The repetition number of the experiment run
        /// </param>
        /// <param name="startTime">
        /// The start time of the experiment run
        /// </param>
        /// <param name="endTime">
        /// The end time of the experiment run
        /// </param>
        /// <param name="id">
        /// The ID of the experiment run
        /// </param>
        /// <param name="experimentId">
        /// The ID of the experiment
        /// </param>
        /// <param name="traceId">
        /// The ID of the corresponding trace (if one exists)
        /// </param>
        /// <param name="error">
        /// Optional error message if the experiment run encountered an error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentRun(
            string datasetExampleId,
            object output,
            int repetitionNumber,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            string id,
            string experimentId,
            string? traceId,
            string? error)
        {
            this.DatasetExampleId = datasetExampleId ?? throw new global::System.ArgumentNullException(nameof(datasetExampleId));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.RepetitionNumber = repetitionNumber;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TraceId = traceId;
            this.Error = error;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ExperimentId = experimentId ?? throw new global::System.ArgumentNullException(nameof(experimentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentRun" /> class.
        /// </summary>
        public ExperimentRun()
        {
        }
    }
}