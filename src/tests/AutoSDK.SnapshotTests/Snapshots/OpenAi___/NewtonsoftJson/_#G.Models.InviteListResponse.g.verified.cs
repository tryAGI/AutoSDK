//HintName: G.Models.InviteListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteListResponse
    {
        /// <summary>
        /// The object type, which is always `list`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.InviteListResponseObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Invite> Data { get; set; } = default!;

        /// <summary>
        /// The first `invite_id` in the retrieved `list`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// The last `invite_id` in the retrieved `list`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// The `has_more` property is used for pagination to indicate there are additional results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteListResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type, which is always `list`
        /// </param>
        /// <param name="data"></param>
        /// <param name="firstId">
        /// The first `invite_id` in the retrieved `list`
        /// </param>
        /// <param name="lastId">
        /// The last `invite_id` in the retrieved `list`
        /// </param>
        /// <param name="hasMore">
        /// The `has_more` property is used for pagination to indicate there are additional results.
        /// </param>
        public InviteListResponse(
            global::System.Collections.Generic.IList<global::G.Invite> data,
            global::G.InviteListResponseObject @object,
            string? firstId,
            string? lastId,
            bool? hasMore)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
            this.FirstId = firstId;
            this.LastId = lastId;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteListResponse" /> class.
        /// </summary>
        public InviteListResponse()
        {
        }
    }
}