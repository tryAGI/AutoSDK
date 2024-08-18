//HintName: G.Models.DoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a stream ends.
    /// </summary>
    public sealed partial class DoneEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.DoneEventEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DoneEventEvent Event { get; set; } = global::G.DoneEventEvent.Done;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.DoneEventDataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DoneEventData Data { get; set; } = global::G.DoneEventData.DONE;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}