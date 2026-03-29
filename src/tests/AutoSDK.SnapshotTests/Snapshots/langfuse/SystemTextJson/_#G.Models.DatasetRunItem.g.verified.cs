//HintName: G.Models.DatasetRunItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetRunItem
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
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetRunId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetRunName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetRunName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetItemId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// The observation ID associated with this run item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observationId")]
        public string? ObservationId { get; set; }

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
        /// Initializes a new instance of the <see cref="DatasetRunItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="datasetRunId"></param>
        /// <param name="datasetRunName"></param>
        /// <param name="datasetItemId"></param>
        /// <param name="traceId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="observationId">
        /// The observation ID associated with this run item
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetRunItem(
            string id,
            string datasetRunId,
            string datasetRunName,
            string datasetItemId,
            string traceId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? observationId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DatasetRunId = datasetRunId ?? throw new global::System.ArgumentNullException(nameof(datasetRunId));
            this.DatasetRunName = datasetRunName ?? throw new global::System.ArgumentNullException(nameof(datasetRunName));
            this.DatasetItemId = datasetItemId ?? throw new global::System.ArgumentNullException(nameof(datasetItemId));
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.ObservationId = observationId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetRunItem" /> class.
        /// </summary>
        public DatasetRunItem()
        {
        }
    }
}