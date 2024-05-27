//HintName: G.Models.ChatBadge.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatBadge
    {
        /// <summary>
        /// An ID that identifies this set of chat badges. For example, Bits or Subscriber.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("set_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SetId { get; set; }

        /// <summary>
        /// The list of chat badges in this set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<ChatBadgeVersions> Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}