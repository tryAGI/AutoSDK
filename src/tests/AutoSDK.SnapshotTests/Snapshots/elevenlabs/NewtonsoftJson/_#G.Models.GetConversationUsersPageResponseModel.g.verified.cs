//HintName: G.Models.GetConversationUsersPageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConversationUsersPageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ConversationUserResponseModel> Users { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="GetConversationUsersPageResponseModel" /> class.
        /// </summary>
        /// <param name="users"></param>
        /// <param name="hasMore"></param>
        /// <param name="nextCursor"></param>
        public GetConversationUsersPageResponseModel(
            global::System.Collections.Generic.IList<global::G.ConversationUserResponseModel> users,
            bool hasMore,
            string? nextCursor)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConversationUsersPageResponseModel" /> class.
        /// </summary>
        public GetConversationUsersPageResponseModel()
        {
        }
    }
}