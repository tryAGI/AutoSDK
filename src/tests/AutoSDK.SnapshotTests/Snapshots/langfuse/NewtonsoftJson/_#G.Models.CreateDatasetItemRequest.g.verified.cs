//HintName: G.Models.CreateDatasetItemRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetItemRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public object? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expectedOutput")]
        public object? ExpectedOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceTraceId")]
        public string? SourceTraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceObservationId")]
        public string? SourceObservationId { get; set; }

        /// <summary>
        /// Dataset items are upserted on their id. Id needs to be unique (project-level) and cannot be reused across datasets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DatasetStatusJsonConverter))]
        public global::G.DatasetStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemRequest" /> class.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="input"></param>
        /// <param name="expectedOutput"></param>
        /// <param name="metadata"></param>
        /// <param name="sourceTraceId"></param>
        /// <param name="sourceObservationId"></param>
        /// <param name="id">
        /// Dataset items are upserted on their id. Id needs to be unique (project-level) and cannot be reused across datasets.
        /// </param>
        /// <param name="status"></param>
        public CreateDatasetItemRequest(
            string datasetName,
            object? input,
            object? expectedOutput,
            object? metadata,
            string? sourceTraceId,
            string? sourceObservationId,
            string? id,
            global::G.DatasetStatus? status)
        {
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.Input = input;
            this.ExpectedOutput = expectedOutput;
            this.Metadata = metadata;
            this.SourceTraceId = sourceTraceId;
            this.SourceObservationId = sourceObservationId;
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemRequest" /> class.
        /// </summary>
        public CreateDatasetItemRequest()
        {
        }
    }
}