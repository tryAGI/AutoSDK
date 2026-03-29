//HintName: G.Models.MemoryItemDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single memory item.
    /// </summary>
    public sealed partial class MemoryItemDto
    {
        /// <summary>
        /// Unique identifier. Auto-generated if omitted.<br/>
        /// Example: mi_abc123def4567
        /// </summary>
        /// <example>mi_abc123def4567</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Creation timestamp in ISO 8601 UTC. Format validated by TSOA only. Auto-set if omitted.<br/>
        /// Example: 2024-06-15T09:30:00Z
        /// </summary>
        /// <example>2024-06-15T09:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Priority for eviction. Higher values are kept longer;<br/>
        /// lowest-priority items should be removed first when the limit is reached.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("priority", Required = global::Newtonsoft.Json.Required.Always)]
        public double Priority { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="MemoryItemDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier. Auto-generated if omitted.<br/>
        /// Example: mi_abc123def4567
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp in ISO 8601 UTC. Format validated by TSOA only. Auto-set if omitted.<br/>
        /// Example: 2024-06-15T09:30:00Z
        /// </param>
        /// <param name="priority">
        /// Priority for eviction. Higher values are kept longer;<br/>
        /// lowest-priority items should be removed first when the limit is reached.
        /// </param>
        /// <param name="data">
        /// The memory content (max 150 characters).<br/>
        /// Example: User prefers dark mode and metric units
        /// </param>
        public MemoryItemDto(
            string id,
            string createdAt,
            double priority,
            string data)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Priority = priority;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryItemDto" /> class.
        /// </summary>
        public MemoryItemDto()
        {
        }
    }
}