//HintName: G.Models.MemoriesSearchCreateResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesSearchCreateResponseItem
    {
        /// <summary>
        /// Unique identifier for the memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The content of the memory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Memory { get; set; }

        /// <summary>
        /// The identifier of the user associated with this memory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional metadata associated with the memory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Categories associated with the memory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.IList<string>? Categories { get; set; }

        /// <summary>
        /// Whether the memory is immutable.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("immutable")]
        public bool? Immutable { get; set; }

        /// <summary>
        /// The date and time when the memory will expire. Format: YYYY-MM-DD.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public global::System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The timestamp when the memory was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the memory was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesSearchCreateResponseItem" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesSearchCreateResponseItem(
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
        /// Initializes a new instance of the <see cref="MemoriesSearchCreateResponseItem" /> class.
        /// </summary>
        public MemoriesSearchCreateResponseItem()
        {
        }
    }
}