//HintName: G.Models.NewDatasetParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewDatasetParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetName", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RequestIds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasetType", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.NewDatasetParamsDatasetTypeJsonConverter))]
        public global::G.NewDatasetParamsDatasetType DatasetType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.DatasetMetadata? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewDatasetParams" /> class.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="requestIds"></param>
        /// <param name="datasetType"></param>
        /// <param name="meta"></param>
        public NewDatasetParams(
            string datasetName,
            global::System.Collections.Generic.IList<string> requestIds,
            global::G.NewDatasetParamsDatasetType datasetType,
            global::G.DatasetMetadata? meta)
        {
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.RequestIds = requestIds ?? throw new global::System.ArgumentNullException(nameof(requestIds));
            this.DatasetType = datasetType;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewDatasetParams" /> class.
        /// </summary>
        public NewDatasetParams()
        {
        }
    }
}