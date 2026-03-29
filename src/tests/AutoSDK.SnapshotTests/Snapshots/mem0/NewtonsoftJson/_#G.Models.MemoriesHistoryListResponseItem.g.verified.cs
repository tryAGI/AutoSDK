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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the associated memory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memory_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid MemoryId { get; set; } = default!;

        /// <summary>
        /// The conversation input that led to this memory change
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.MemoriesHistoryListResponseItemInputItem> Input { get; set; } = default!;

        /// <summary>
        /// The previous state of the memory, if applicable
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("old_memory")]
        public string? OldMemory { get; set; }

        /// <summary>
        /// The new or updated state of the memory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_memory", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewMemory { get; set; } = default!;

        /// <summary>
        /// The identifier of the user associated with this memory
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The type of event that occurred
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MemoriesHistoryListResponseItemEvent Event { get; set; } = default!;

        /// <summary>
        /// Additional metadata associated with the memory change
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The timestamp when this history entry was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The timestamp when this history entry was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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