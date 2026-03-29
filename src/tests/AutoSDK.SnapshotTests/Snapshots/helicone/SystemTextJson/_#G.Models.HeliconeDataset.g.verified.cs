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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JsonJsonConverter))]
        public global::G.Json? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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