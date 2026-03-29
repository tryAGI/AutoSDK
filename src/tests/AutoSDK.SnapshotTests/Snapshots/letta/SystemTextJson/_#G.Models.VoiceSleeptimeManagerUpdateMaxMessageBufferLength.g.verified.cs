//HintName: G.Models.VoiceSleeptimeManagerUpdateMaxMessageBufferLength.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The desired maximum length of messages in the context window of the convo agent. This is a best effort, and may be off slightly due to user/assistant interleaving.
    /// </summary>
    public sealed partial class VoiceSleeptimeManagerUpdateMaxMessageBufferLength
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}