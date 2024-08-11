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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ThreadStreamEventVariant1EventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ThreadStreamEventVariant1Event Event { get; set; }

        /// <summary>
        /// Represents a thread that contains [messages](/docs/api-reference/messages).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ThreadObject? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}