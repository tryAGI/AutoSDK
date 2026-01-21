//HintName: G.Models.MessageBatchEndedAt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// RFC 3339 datetime string representing the time at which processing for the Message Batch ended. Specified only once processing ends.<br/>
    /// Processing ends when every request in a Message Batch has either succeeded, errored, canceled, or expired.
    /// </summary>
    public sealed partial class MessageBatchEndedAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}