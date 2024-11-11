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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.InviteListResponseObjectJsonConverter))]
        public global::G.InviteListResponseObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Invite> Data { get; set; }

        /// <summary>
        /// The first `invite_id` in the retrieved `list`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// The last `invite_id` in the retrieved `list`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// The `has_more` property is used for pagination to indicate there are additional results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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