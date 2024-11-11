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
        /// - `"tool_use"`: the model invoked one or more tools<br/>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDelta" /> class.
        /// </summary>
        /// <param name="stopReason">
        /// The reason that we stopped.<br/>
        /// This may be one the following values:<br/>
        /// - `"end_turn"`: the model reached a natural stopping point<br/>
        /// - `"max_tokens"`: we exceeded the requested `max_tokens` or the model's maximum<br/>
        /// - `"stop_sequence"`: one of your provided custom `stop_sequences` was generated<br/>
        /// - `"tool_use"`: the model invoked one or more tools<br/>
        /// In non-streaming mode this value is always non-null. In streaming mode, it is<br/>
        /// null in the `message_start` event and non-null otherwise.
        /// </param>
        /// <param name="stopSequence">
        /// Which custom stop sequence was generated, if any.<br/>
        /// This value will be a non-null string if one of your custom stop sequences was<br/>
        /// generated.
        /// </param>
        public MessageDelta(
            global::G.StopReason? stopReason,
            string? stopSequence)
        {
            this.StopReason = stopReason;
            this.StopSequence = stopSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDelta" /> class.
        /// </summary>
        public MessageDelta()
        {
        }
    }
}