//HintName: G.Models.Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A change in status of a fine-tuned model.
    /// </summary>
    public sealed partial class Event
    {
        /// <summary>
        /// ID of the user who initiated the event. Empty if initiated by the system.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Status of the fine-tuned model.<br/>
        /// Default Value: STATUS_UNSPECIFIED
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.Status? Status { get; set; }

        /// <summary>
        /// Timestamp when the event happened.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the user who initiated the event. Empty if initiated by the system.
        /// </param>
        /// <param name="status">
        /// Status of the fine-tuned model.<br/>
        /// Default Value: STATUS_UNSPECIFIED
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event happened.
        /// </param>
        public Event(
            string? userId,
            global::G.Status? status,
            global::System.DateTime? createdAt)
        {
            this.UserId = userId;
            this.Status = status;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        public Event()
        {
        }
    }
}