//HintName: G.Models.TenantShareDatasetToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TenantShareDatasetToken
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("share_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string ShareToken { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid DatasetId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareDatasetToken" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="shareToken"></param>
        /// <param name="createdAt"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        public TenantShareDatasetToken(
            string type,
            string shareToken,
            global::System.DateTime createdAt,
            global::System.Guid datasetId,
            string? datasetName)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ShareToken = shareToken ?? throw new global::System.ArgumentNullException(nameof(shareToken));
            this.CreatedAt = createdAt;
            this.DatasetId = datasetId;
            this.DatasetName = datasetName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantShareDatasetToken" /> class.
        /// </summary>
        public TenantShareDatasetToken()
        {
        }
    }
}