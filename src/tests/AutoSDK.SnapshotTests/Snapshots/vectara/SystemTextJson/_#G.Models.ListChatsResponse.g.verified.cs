//HintName: G.Models.ListChatsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListChatsResponse
    {
        /// <summary>
        /// List of chats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chats")]
        public global::System.Collections.Generic.IList<global::G.Chat>? Chats { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChatsResponse" /> class.
        /// </summary>
        /// <param name="chats">
        /// List of chats.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListChatsResponse(
            global::System.Collections.Generic.IList<global::G.Chat>? chats,
            global::G.ListMetadata? metadata)
        {
            this.Chats = chats;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChatsResponse" /> class.
        /// </summary>
        public ListChatsResponse()
        {
        }
    }
}