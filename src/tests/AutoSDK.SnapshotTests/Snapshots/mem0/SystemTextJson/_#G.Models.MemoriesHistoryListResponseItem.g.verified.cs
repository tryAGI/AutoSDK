//HintName: G.Models.MemoriesHistoryListResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesHistoryListResponseItem
    {
        /// <summary>
        /// Unique identifier for the history entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Unique identifier of the associated memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MemoryId { get; set; }

        /// <summary>
        /// The conversation input that led to this memory change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MemoriesHistoryListResponseItemInputItem> Input { get; set; }

        /// <summary>
        /// The previous state of the memory, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_memory")]
        public string? OldMemory { get; set; }

        /// <summary>
        /// The new or updated state of the memory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_memory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewMemory { get; set; }

        /// <summary>
        /// The identifier of the user associated with this memory
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The type of event that occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MemoriesHistoryListResponseItemEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MemoriesHistoryListResponseItemEvent Event { get; set; }

        /// <summary>
        /// Additional metadata associated with the memory change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The timestamp when this history entry was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when this history entry was last updated.
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
        /// Initializes a new instance of the <see cref="MemoriesHistoryListResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the history entry.
        /// </param>
        /// <param name="memoryId">
        /// Unique identifier of the associated memory.
        /// </param>
        /// <param name="input">
        /// The conversation input that led to this memory change
        /// </param>
        /// <param name="newMemory">
        /// The new or updated state of the memory
        /// </param>
        /// <param name="userId">
        /// The identifier of the user associated with this memory
        /// </param>
        /// <param name="event">
        /// The type of event that occurred
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when this history entry was created.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when this history entry was last updated.
        /// </param>
        /// <param name="oldMemory">
        /// The previous state of the memory, if applicable
        /// </param>
        /// <param name="metadata">
        /// Additional metadata associated with the memory change
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoriesHistoryListResponseItem(
            global::System.Guid id,
            global::System.Guid memoryId,
            global::System.Collections.Generic.IList<global::G.MemoriesHistoryListResponseItemInputItem> input,
            string newMemory,
            string userId,
            global::G.MemoriesHistoryListResponseItemEvent @event,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? oldMemory,
            object? metadata)
        {
            this.Id = id;
            this.MemoryId = memoryId;
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.OldMemory = oldMemory;
            this.NewMemory = newMemory ?? throw new global::System.ArgumentNullException(nameof(newMemory));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Event = @event;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesHistoryListResponseItem" /> class.
        /// </summary>
        public MemoriesHistoryListResponseItem()
        {
        }
    }
}