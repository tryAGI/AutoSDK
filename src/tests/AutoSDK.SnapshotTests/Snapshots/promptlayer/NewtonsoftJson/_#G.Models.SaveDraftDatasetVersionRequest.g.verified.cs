//HintName: G.Models.SaveDraftDatasetVersionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SaveDraftDatasetVersionRequest
    {
        /// <summary>
        /// ID of the dataset group containing the draft to save
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_group_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int DatasetGroupId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveDraftDatasetVersionRequest" /> class.
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group containing the draft to save
        /// </param>
        public SaveDraftDatasetVersionRequest(
            int datasetGroupId)
        {
            this.DatasetGroupId = datasetGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveDraftDatasetVersionRequest" /> class.
        /// </summary>
        public SaveDraftDatasetVersionRequest()
        {
        }
    }
}