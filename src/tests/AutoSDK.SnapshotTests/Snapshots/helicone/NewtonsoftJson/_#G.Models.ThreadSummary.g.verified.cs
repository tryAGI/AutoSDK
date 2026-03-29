//HintName: G.Models.ThreadSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("escalated", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Escalated { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double MessageCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_message")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_message")]
        public string? LastMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("soft_delete")]
        public bool? SoftDelete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadSummary" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="escalated"></param>
        /// <param name="messageCount"></param>
        /// <param name="firstMessage"></param>
        /// <param name="lastMessage"></param>
        /// <param name="softDelete"></param>
        public ThreadSummary(
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            bool escalated,
            double messageCount,
            string? firstMessage,
            string? lastMessage,
            bool? softDelete)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Escalated = escalated;
            this.MessageCount = messageCount;
            this.FirstMessage = firstMessage;
            this.LastMessage = lastMessage;
            this.SoftDelete = softDelete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadSummary" /> class.
        /// </summary>
        public ThreadSummary()
        {
        }
    }
}