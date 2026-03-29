//HintName: G.Models.MemoriesSearchV2ResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesSearchV2ResponseItem
    {
        /// <summary>
        /// Unique identifier for the memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The content of the memory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory", Required = global::Newtonsoft.Json.Required.Always)]
        public string Memory { get; set; } = default!;

        /// <summary>
        /// The identifier of the user associated with this memory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Additional metadata associated with the memory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Categories associated with the memory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

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
        /// The timestamp when the memory was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The timestamp when the memory was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchV2ResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the memory.
        /// </param>
        /// <param name="memory">
        /// The content of the memory
        /// </param>
        /// <param name="userId">
        /// The identifier of the user associated with this memory
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the memory was created.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the memory was last updated.
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the memory
        /// </param>
        /// <param name="categories">
        /// Categories associated with the memory
        /// </param>
        /// <param name="immutable">
        /// Whether the memory is immutable.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expirationDate">
        /// The date and time when the memory will expire. Format: YYYY-MM-DD.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public MemoriesSearchV2ResponseItem(
            global::System.Guid id,
            string memory,
            string userId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            object? metadata,
            global::System.Collections.Generic.IList<string>? categories,
            bool? immutable,
            global::System.DateTime? expirationDate)
        {
            this.Id = id;
            this.Memory = memory ?? throw new global::System.ArgumentNullException(nameof(memory));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Metadata = metadata;
            this.Categories = categories;
            this.Immutable = immutable;
            this.ExpirationDate = expirationDate;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchV2ResponseItem" /> class.
        /// </summary>
        public MemoriesSearchV2ResponseItem()
        {
        }
    }
}