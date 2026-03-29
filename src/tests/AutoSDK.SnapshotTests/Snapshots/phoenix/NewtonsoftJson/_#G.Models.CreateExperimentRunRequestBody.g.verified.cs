//HintName: G.Models.CreateExperimentRunRequestBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExperimentRunRequestBody
    {
        /// <summary>
        /// The ID of the dataset example used in the experiment run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_example_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetExampleId { get; set; } = default!;

        /// <summary>
        /// The output of the experiment task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public object Output { get; set; } = default!;

        /// <summary>
        /// The repetition number of the experiment run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repetition_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int RepetitionNumber { get; set; } = default!;

        /// <summary>
        /// The start time of the experiment run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime StartTime { get; set; } = default!;

        /// <summary>
        /// The end time of the experiment run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime EndTime { get; set; } = default!;

        /// <summary>
        /// The ID of the corresponding trace (if one exists)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// Optional error message if the experiment run encountered an error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentRunRequestBody" /> class.
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
        /// <param name="traceId">
        /// The ID of the corresponding trace (if one exists)
        /// </param>
        /// <param name="error">
        /// Optional error message if the experiment run encountered an error
        /// </param>
        public CreateExperimentRunRequestBody(
            string datasetExampleId,
            object output,
            int repetitionNumber,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExperimentRunRequestBody" /> class.
        /// </summary>
        public CreateExperimentRunRequestBody()
        {
        }
    }
}