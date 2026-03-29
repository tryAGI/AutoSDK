//HintName: G.Models.CreateDatasetOpenApiData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetOpenApiData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetOpenApiData" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        public CreateDatasetOpenApiData(
            string? datasetId)
        {
            this.DatasetId = datasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetOpenApiData" /> class.
        /// </summary>
        public CreateDatasetOpenApiData()
        {
        }
    }
}