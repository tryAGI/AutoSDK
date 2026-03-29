//HintName: G.Models.CreateDatasetVersionFromFileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetVersionFromFileResponse
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFileResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="datasetId">
        /// ID of the created draft dataset
        /// </param>
        public CreateDatasetVersionFromFileResponse(
            bool success,
            string message,
            int datasetId)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DatasetId = datasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFileResponse" /> class.
        /// </summary>
        public CreateDatasetVersionFromFileResponse()
        {
        }
    }
}