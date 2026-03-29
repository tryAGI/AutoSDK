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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetRunId", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetRunId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetRunName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetRunName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetItemId", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetItemId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("traceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string TraceId { get; set; } = default!;

        /// <summary>
        /// The observation ID associated with this run item
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("observationId")]
        public string? ObservationId { get; set; }

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