//HintName: G.Models.CreateDatasetItemsFromCsvRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetItemsFromCsvRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public object File { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DatasetId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromCsvRequest" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="datasetId"></param>
        public CreateDatasetItemsFromCsvRequest(
            object file,
            global::System.Guid datasetId)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.DatasetId = datasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetItemsFromCsvRequest" /> class.
        /// </summary>
        public CreateDatasetItemsFromCsvRequest()
        {
        }
    }
}