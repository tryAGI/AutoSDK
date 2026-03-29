//HintName: G.Models.VoiceSleeptimeManagerUpdateMinMessageBufferLength.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The desired minimum length of messages in the context window of the convo agent. This is a best effort, and may be off-by-one due to user/assistant interleaving.
    /// </summary>
    public sealed partial class VoiceSleeptimeManagerUpdateMinMessageBufferLength
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}