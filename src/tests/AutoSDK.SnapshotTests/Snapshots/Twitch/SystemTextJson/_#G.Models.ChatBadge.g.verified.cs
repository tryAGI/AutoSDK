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
        public required global::System.Collections.Generic.IList<global::G.ChatBadgeVersion> Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBadge" /> class.
        /// </summary>
        /// <param name="setId">
        /// An ID that identifies this set of chat badges. For example, Bits or Subscriber.
        /// </param>
        /// <param name="versions">
        /// The list of chat badges in this set.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatBadge(
            string setId,
            global::System.Collections.Generic.IList<global::G.ChatBadgeVersion> versions)
        {
            this.SetId = setId ?? throw new global::System.ArgumentNullException(nameof(setId));
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatBadge" /> class.
        /// </summary>
        public ChatBadge()
        {
        }
    }
}