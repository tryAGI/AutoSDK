//HintName: G.Models.CreateDatasetVersionFromFilterParamsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetVersionFromFilterParamsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// ID of the created draft dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int DatasetId { get; set; } = default!;

        /// <summary>
        /// ID of the dataset group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_group_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int DatasetGroupId { get; set; } = default!;

        /// <summary>
        /// Version number of the dataset (-1 for draft)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="datasetId">
        /// ID of the created draft dataset
        /// </param>
        /// <param name="datasetGroupId">
        /// ID of the dataset group
        /// </param>
        /// <param name="versionNumber">
        /// Version number of the dataset (-1 for draft)
        /// </param>
        public CreateDatasetVersionFromFilterParamsResponse(
            bool success,
            string message,
            int datasetId,
            int datasetGroupId,
            int versionNumber)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DatasetId = datasetId;
            this.DatasetGroupId = datasetGroupId;
            this.VersionNumber = versionNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFilterParamsResponse" /> class.
        /// </summary>
        public CreateDatasetVersionFromFilterParamsResponse()
        {
        }
    }
}