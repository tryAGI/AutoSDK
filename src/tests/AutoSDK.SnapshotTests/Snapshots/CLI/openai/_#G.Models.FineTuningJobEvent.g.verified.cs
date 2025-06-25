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
        /// The object type, which is always "fine_tuning.job.event".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuningJobEventObjectJsonConverter))]
        public global::G.FineTuningJobEventObject Object { get; set; }

        /// <summary>
        /// The object identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The log level of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuningJobEventLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FineTuningJobEventLevel Level { get; set; }

        /// <summary>
        /// The message of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The type of event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuningJobEventTypeJsonConverter))]
        public global::G.FineTuningJobEventType? Type { get; set; }

        /// <summary>
        /// The data associated with the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobEvent" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always "fine_tuning.job.event".
        /// </param>
        /// <param name="id">
        /// The object identifier.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the fine-tuning job was created.
        /// </param>
        /// <param name="level">
        /// The log level of the event.
        /// </param>
        /// <param name="message">
        /// The message of the event.
        /// </param>
        /// <param name="type">
        /// The type of event.
        /// </param>
        /// <param name="data">
        /// The data associated with the event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuningJobEvent(
            string id,
            global::System.DateTimeOffset createdAt,
            global::G.FineTuningJobEventLevel level,
            string message,
            global::G.FineTuningJobEventObject @object,
            global::G.FineTuningJobEventType? type,
            object? data)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Level = level;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Object = @object;
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobEvent" /> class.
        /// </summary>
        public FineTuningJobEvent()
        {
        }
    }
}