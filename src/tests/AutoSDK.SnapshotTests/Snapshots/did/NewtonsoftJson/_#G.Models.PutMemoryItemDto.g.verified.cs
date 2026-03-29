//HintName: G.Models.PutMemoryItemDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Item for PUT request. id, created_at and priority are optional; priority defaults if omitted.
    /// </summary>
    public sealed partial class PutMemoryItemDto
    {
        /// <summary>
        /// Unique identifier. Auto-generated if omitted.<br/>
        /// Example: mi_abc123def4567
        /// </summary>
        /// <example>mi_abc123def4567</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Creation timestamp in ISO 8601 UTC. Format validated by TSOA only. Auto-set if omitted.<br/>
        /// Example: 2024-06-15T09:30:00Z
        /// </summary>
        /// <example>2024-06-15T09:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Priority for eviction (default used if omitted). Higher values are kept longer.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("priority")]
        public double? Priority { get; set; }

        /// <summary>
        /// The memory content (max 150 characters).<br/>
        /// Example: User prefers dark mode and metric units
        /// </summary>
        /// <example>User prefers dark mode and metric units</example>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public string Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutMemoryItemDto" /> class.
        /// </summary>
        /// <param name="data">
        /// The memory content (max 150 characters).<br/>
        /// Example: User prefers dark mode and metric units
        /// </param>
        /// <param name="id">
        /// Unique identifier. Auto-generated if omitted.<br/>
        /// Example: mi_abc123def4567
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp in ISO 8601 UTC. Format validated by TSOA only. Auto-set if omitted.<br/>
        /// Example: 2024-06-15T09:30:00Z
        /// </param>
        /// <param name="priority">
        /// Priority for eviction (default used if omitted). Higher values are kept longer.<br/>
        /// Default Value: 0
        /// </param>
        public PutMemoryItemDto(
            string data,
            string? id,
            string? createdAt,
            double? priority)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Priority = priority;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutMemoryItemDto" /> class.
        /// </summary>
        public PutMemoryItemDto()
        {
        }
    }
}