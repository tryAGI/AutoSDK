//HintName: G.Models.ConversationInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Conversation information from the server.
    /// </summary>
    public sealed partial class ConversationInfo
    {
        /// <summary>
        /// Conversation ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Object type (realtime.conversation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// Conversation ID.
        /// </param>
        /// <param name="object">
        /// Object type (realtime.conversation).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationInfo(
            string? id,
            string? @object)
        {
            this.Id = id;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationInfo" /> class.
        /// </summary>
        public ConversationInfo()
        {
        }
    }
}