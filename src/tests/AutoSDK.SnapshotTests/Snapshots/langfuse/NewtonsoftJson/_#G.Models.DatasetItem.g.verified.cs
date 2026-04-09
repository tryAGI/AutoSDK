//HintName: G.Models.DatasetItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DatasetStatusJsonConverter))]
        public global::G.DatasetStatus Status { get; set; } = default!;

        /// <summary>
        /// Input data for the dataset item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public object Input { get; set; } = default!;

        /// <summary>
        /// Expected output for the dataset item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expectedOutput", Required = global::Newtonsoft.Json.Required.Always)]
        public object ExpectedOutput { get; set; } = default!;

        /// <summary>
        /// Metadata associated with the dataset item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object Metadata { get; set; } = default!;

        /// <summary>
        /// The trace ID that sourced this dataset item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceTraceId")]
        public string? SourceTraceId { get; set; }

        /// <summary>
        /// The observation ID that sourced this dataset item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sourceObservationId")]
        public string? SourceObservationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetId", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="input">
        /// Input data for the dataset item
        /// </param>
        /// <param name="expectedOutput">
        /// Expected output for the dataset item
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the dataset item
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="sourceTraceId">
        /// The trace ID that sourced this dataset item
        /// </param>
        /// <param name="sourceObservationId">
        /// The observation ID that sourced this dataset item
        /// </param>
        public DatasetItem(
            string id,
            global::G.DatasetStatus status,
            object input,
            object expectedOutput,
            object metadata,
            string datasetId,
            string datasetName,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? sourceTraceId,
            string? sourceObservationId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.ExpectedOutput = expectedOutput ?? throw new global::System.ArgumentNullException(nameof(expectedOutput));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.SourceTraceId = sourceTraceId;
            this.SourceObservationId = sourceObservationId;
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetItem" /> class.
        /// </summary>
        public DatasetItem()
        {
        }
    }
}