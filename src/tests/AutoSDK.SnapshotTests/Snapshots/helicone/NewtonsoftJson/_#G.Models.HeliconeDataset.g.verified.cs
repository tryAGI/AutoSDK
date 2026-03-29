//HintName: G.Models.HeliconeDataset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HeliconeDataset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.Json? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public string Organization { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double RequestsCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeDataset" /> class.
        /// </summary>
        /// <param name="datasetType"></param>
        /// <param name="id"></param>
        /// <param name="organization"></param>
        /// <param name="requestsCount"></param>
        /// <param name="createdAt"></param>
        /// <param name="meta"></param>
        /// <param name="name"></param>
        public HeliconeDataset(
            string datasetType,
            string id,
            string organization,
            double requestsCount,
            string? createdAt,
            global::G.Json? meta,
            string? name)
        {
            this.CreatedAt = createdAt;
            this.DatasetType = datasetType ?? throw new global::System.ArgumentNullException(nameof(datasetType));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Meta = meta;
            this.Name = name;
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.RequestsCount = requestsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeliconeDataset" /> class.
        /// </summary>
        public HeliconeDataset()
        {
        }
    }
}