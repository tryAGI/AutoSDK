//HintName: G.Models.FineTuningJobEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Fine-tuning job event object
    /// </summary>
    public sealed partial class FineTuningJobEvent
    {
        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The data associated with the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public object? Data { get; set; }

        /// <summary>
        /// The object identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The log level of the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FineTuningJobEventLevel Level { get; set; } = default!;

        /// <summary>
        /// The message of the event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The object type, which is always "fine_tuning.job.event".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.FineTuningJobEventObject Object { get; set; }

        /// <summary>
        /// The type of event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FineTuningJobEventType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobEvent" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the fine-tuning job was created.
        /// </param>
        /// <param name="data">
        /// The data associated with the event.
        /// </param>
        /// <param name="id">
        /// The object identifier.
        /// </param>
        /// <param name="level">
        /// The log level of the event.
        /// </param>
        /// <param name="message">
        /// The message of the event.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "fine_tuning.job.event".
        /// </param>
        /// <param name="type">
        /// The type of event.
        /// </param>
        public FineTuningJobEvent(
            global::System.DateTimeOffset createdAt,
            string id,
            global::G.FineTuningJobEventLevel level,
            string message,
            object? data,
            global::G.FineTuningJobEventObject @object,
            global::G.FineTuningJobEventType? type)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Level = level;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Data = data;
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobEvent" /> class.
        /// </summary>
        public FineTuningJobEvent()
        {
        }
    }
}