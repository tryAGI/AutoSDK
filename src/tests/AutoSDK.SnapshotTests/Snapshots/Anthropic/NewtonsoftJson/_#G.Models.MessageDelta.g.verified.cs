//HintName: G.Models.MessageDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A delta in a streaming message.
    /// </summary>
    public sealed partial class MessageDelta
    {
        /// <summary>
        /// The reason that we stopped.<br/>
        /// This may be one the following values:<br/>
        /// - `"end_turn"`: the model reached a natural stopping point<br/>
        /// - `"max_tokens"`: we exceeded the requested `max_tokens` or the model's maximum<br/>
        /// - `"stop_sequence"`: one of your provided custom `stop_sequences` was generated<br/>
        /// In non-streaming mode this value is always non-null. In streaming mode, it is<br/>
        /// null in the `message_start` event and non-null otherwise.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop_reason")]
        public global::G.StopReason? StopReason { get; set; }

        /// <summary>
        /// Which custom stop sequence was generated, if any.<br/>
        /// This value will be a non-null string if one of your custom stop sequences was<br/>
        /// generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop_sequence")]
        public string? StopSequence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.MessageDelta? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MessageDelta>(
                json,
                jsonSerializerOptions);
        }

    }
}