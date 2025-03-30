//HintName: G.Models.GetConversationsPageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConversationsPageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ConversationSummaryResponseModel> Conversations { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationsPageResponseModel" /> class.
        /// </summary>
        /// <param name="conversations"></param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore"></param>
        public GetConversationsPageResponseModel(
            global::System.Collections.Generic.IList<global::G.ConversationSummaryResponseModel> conversations,
            bool hasMore,
            string? nextCursor)
        {
            this.Conversations = conversations ?? throw new global::System.ArgumentNullException(nameof(conversations));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationsPageResponseModel" /> class.
        /// </summary>
        public GetConversationsPageResponseModel()
        {
        }
    }
}