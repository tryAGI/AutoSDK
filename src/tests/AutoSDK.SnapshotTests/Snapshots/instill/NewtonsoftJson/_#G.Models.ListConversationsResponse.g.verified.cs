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
        [global::Newtonsoft.Json.JsonProperty("conversations")]
        public global::System.Collections.Generic.IList<global::G.Conversation>? Conversations { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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