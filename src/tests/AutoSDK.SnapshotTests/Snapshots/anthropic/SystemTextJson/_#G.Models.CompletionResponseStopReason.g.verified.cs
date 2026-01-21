//HintName: G.Models.CompletionResponseStopReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason that we stopped.<br/>
    /// This may be one the following values:<br/>
    /// * `"stop_sequence"`: we reached a stop sequence — either provided by you via the `stop_sequences` parameter, or a stop sequence built into the model<br/>
    /// * `"max_tokens"`: we exceeded `max_tokens_to_sample` or the model's maximum
    /// </summary>
    public sealed partial class CompletionResponseStopReason
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}