//HintName: G.Models.MessageBatchCancelInitiatedAt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// RFC 3339 datetime string representing the time at which cancellation was initiated for the Message Batch. Specified only if cancellation was initiated.
    /// </summary>
    public sealed partial class MessageBatchCancelInitiatedAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}