//HintName: G.Models.MessageDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageDeltaStopReason? StopReason { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stop_sequence", Required = global::Newtonsoft.Json.Required.Always)]
        public string? StopSequence { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDelta" /> class.
        /// </summary>
        /// <param name="stopReason"></param>
        /// <param name="stopSequence"></param>
        public MessageDelta(
            global::G.MessageDeltaStopReason? stopReason,
            string? stopSequence)
        {
            this.StopReason = stopReason;
            this.StopSequence = stopSequence ?? throw new global::System.ArgumentNullException(nameof(stopSequence));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDelta" /> class.
        /// </summary>
        public MessageDelta()
        {
        }
    }
}