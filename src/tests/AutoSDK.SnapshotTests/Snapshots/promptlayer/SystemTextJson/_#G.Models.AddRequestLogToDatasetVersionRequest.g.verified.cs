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
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DatasetGroupId { get; set; }

        /// <summary>
        /// ID of the request log to add as a dataset row
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_log_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestLogId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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