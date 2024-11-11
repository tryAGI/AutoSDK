//HintName: G.Models.ListConversationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListConversationsResponse
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversations")]
        public global::System.Collections.Generic.IList<global::G.Conversation>? Conversations { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConversationsResponse" /> class.
        /// </summary>
        /// <param name="conversations">
        /// Included only in responses
        /// </param>
        /// <param name="nextPageToken">
        /// Included only in responses
        /// </param>
        /// <param name="totalSize">
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListConversationsResponse(
            global::System.Collections.Generic.IList<global::G.Conversation>? conversations,
            string? nextPageToken,
            int? totalSize)
        {
            this.Conversations = conversations;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConversationsResponse" /> class.
        /// </summary>
        public ListConversationsResponse()
        {
        }
    }
}