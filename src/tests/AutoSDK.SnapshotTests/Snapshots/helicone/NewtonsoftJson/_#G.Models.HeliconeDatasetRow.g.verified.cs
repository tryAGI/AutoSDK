//HintName: G.Models.HeliconeDatasetRow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeliconeDatasetRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin_request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginRequestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signed_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResultStringString SignedUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeDatasetRow" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="originRequestId"></param>
        /// <param name="datasetId"></param>
        /// <param name="createdAt"></param>
        /// <param name="signedUrl"></param>
        public HeliconeDatasetRow(
            string id,
            string originRequestId,
            string datasetId,
            string createdAt,
            global::G.ResultStringString signedUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OriginRequestId = originRequestId ?? throw new global::System.ArgumentNullException(nameof(originRequestId));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.SignedUrl = signedUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeDatasetRow" /> class.
        /// </summary>
        public HeliconeDatasetRow()
        {
        }
    }
}