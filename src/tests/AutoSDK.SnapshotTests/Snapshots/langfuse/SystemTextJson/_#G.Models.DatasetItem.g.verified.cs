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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DatasetStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DatasetStatus Status { get; set; }

        /// <summary>
        /// Input data for the dataset item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// Expected output for the dataset item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectedOutput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ExpectedOutput { get; set; }

        /// <summary>
        /// Metadata associated with the dataset item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// The trace ID that sourced this dataset item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceTraceId")]
        public string? SourceTraceId { get; set; }

        /// <summary>
        /// The observation ID that sourced this dataset item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceObservationId")]
        public string? SourceObservationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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