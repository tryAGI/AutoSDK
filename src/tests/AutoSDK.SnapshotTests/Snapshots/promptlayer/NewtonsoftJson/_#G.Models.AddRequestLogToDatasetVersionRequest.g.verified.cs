//HintName: G.Models.AddRequestLogToDatasetVersionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddRequestLogToDatasetVersionRequest
    {
        /// <summary>
        /// ID of the dataset group containing the draft
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_group_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int DatasetGroupId { get; set; } = default!;

        /// <summary>
        /// ID of the request log to add as a dataset row
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_log_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int RequestLogId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRequestLogToDatasetVersionRequest" /> class.
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group containing the draft
        /// </param>
        /// <param name="requestLogId">
        /// ID of the request log to add as a dataset row
        /// </param>
        public AddRequestLogToDatasetVersionRequest(
            int datasetGroupId,
            int requestLogId)
        {
            this.DatasetGroupId = datasetGroupId;
            this.RequestLogId = requestLogId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRequestLogToDatasetVersionRequest" /> class.
        /// </summary>
        public AddRequestLogToDatasetVersionRequest()
        {
        }
    }
}