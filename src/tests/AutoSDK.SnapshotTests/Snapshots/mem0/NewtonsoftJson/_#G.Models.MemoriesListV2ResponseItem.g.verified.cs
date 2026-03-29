//HintName: G.Models.MemoriesListV2ResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesListV2ResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory", Required = global::Newtonsoft.Json.Required.Always)]
        public string Memory { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public string Owner { get; set; } = default!;

        /// <summary>
        /// Whether the memory is immutable.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("immutable")]
        public bool? Immutable { get; set; }

        /// <summary>
        /// The date and time when the memory will expire. Format: YYYY-MM-DD.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiration_date")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public string Organization { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesListV2ResponseItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="memory"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="owner"></param>
        /// <param name="organization"></param>
        /// <param name="immutable">
        /// Whether the memory is immutable.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expirationDate">
        /// The date and time when the memory will expire. Format: YYYY-MM-DD.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata"></param>
        public MemoriesListV2ResponseItem(
            string id,
            string memory,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string owner,
            string organization,
            bool? immutable,
            global::System.DateTime? expirationDate,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Memory = memory ?? throw new global::System.ArgumentNullException(nameof(memory));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Immutable = immutable;
            this.ExpirationDate = expirationDate;
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesListV2ResponseItem" /> class.
        /// </summary>
        public MemoriesListV2ResponseItem()
        {
        }
    }
}