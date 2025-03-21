//HintName: G.Models.ThreadStreamEventVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a new [thread](/docs/api-reference/threads/object) is created.
    /// </summary>
    public sealed partial class ThreadStreamEventVariant1
    {
        /// <summary>
        /// Represents a thread that contains [messages](/docs/api-reference/messages).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ThreadObject Data { get; set; }

        /// <summary>
        /// Whether to enable input audio transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ThreadStreamEventVariant1EventJsonConverter))]
        public global::G.ThreadStreamEventVariant1Event Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadStreamEventVariant1" /> class.
        /// </summary>
        /// <param name="data">
        /// Represents a thread that contains [messages](/docs/api-reference/messages).
        /// </param>
        /// <param name="enabled">
        /// Whether to enable input audio transcription.
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadStreamEventVariant1(
            global::G.ThreadObject data,
            bool? enabled,
            global::G.ThreadStreamEventVariant1Event @event)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Enabled = enabled;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadStreamEventVariant1" /> class.
        /// </summary>
        public ThreadStreamEventVariant1()
        {
        }
    }
}