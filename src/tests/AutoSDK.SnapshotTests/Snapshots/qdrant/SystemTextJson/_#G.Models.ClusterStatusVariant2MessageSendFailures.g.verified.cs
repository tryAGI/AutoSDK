//HintName: G.Models.ClusterStatusVariant2MessageSendFailures.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Consequent failures of message send operations in consensus by peer address. On the first success to send to that peer - entry is removed from this hashmap.
    /// </summary>
    public sealed partial class ClusterStatusVariant2MessageSendFailures
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}