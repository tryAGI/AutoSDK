//HintName: G.Models.MessageStopReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason that we stopped.<br/>
    /// This may be one the following values:<br/>
    /// * `"end_turn"`: the model reached a natural stopping point<br/>
    /// * `"max_tokens"`: we exceeded the requested `max_tokens` or the model's maximum<br/>
    /// * `"stop_sequence"`: one of your provided custom `stop_sequences` was generated<br/>
    /// * `"tool_use"`: the model invoked one or more tools<br/>
    /// In non-streaming mode this value is always non-null. In streaming mode, it is null in the `message_start` event and non-null otherwise.
    /// </summary>
    public sealed partial class MessageStopReason
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}