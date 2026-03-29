//HintName: G.Models.CreateDatasetGroupResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetGroupResponse
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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_group", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DatasetGroup DatasetGroup { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Dataset Dataset { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetGroupResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="message"></param>
        /// <param name="datasetGroup"></param>
        /// <param name="dataset"></param>
        public CreateDatasetGroupResponse(
            bool success,
            string message,
            global::G.DatasetGroup datasetGroup,
            global::G.Dataset dataset)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.DatasetGroup = datasetGroup ?? throw new global::System.ArgumentNullException(nameof(datasetGroup));
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetGroupResponse" /> class.
        /// </summary>
        public CreateDatasetGroupResponse()
        {
        }
    }
}