//HintName: G.Models.ListMessageApiRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMessageApiRequest
    {
        /// <summary>
        /// 后序消息游标ID  已TODO str
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("after_id")]
        public string? AfterId { get; set; }

        /// <summary>
        /// 前序消息游标ID  已TODO str
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("before_id")]
        public string? BeforeId { get; set; }

        /// <summary>
        /// 运行id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_id")]
        public string? ChatId { get; set; }

        /// <summary>
        /// 每页限制条数  TODO 限制50条
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询顺序  desc倒序 asc正序 TODO 默认倒序
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ListMessageApiRequestOrderJsonConverter))]
        public global::G.ListMessageApiRequestOrder? Order { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMessageApiRequest" /> class.
        /// </summary>
        /// <param name="afterId">
        /// 后序消息游标ID  已TODO str
        /// </param>
        /// <param name="beforeId">
        /// 前序消息游标ID  已TODO str
        /// </param>
        /// <param name="chatId">
        /// 运行id
        /// </param>
        /// <param name="limit">
        /// 每页限制条数  TODO 限制50条
        /// </param>
        /// <param name="order">
        /// 查询顺序  desc倒序 asc正序 TODO 默认倒序
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListMessageApiRequest(
            string? afterId,
            string? beforeId,
            string? chatId,
            int? limit,
            global::G.ListMessageApiRequestOrder? order)
        {
            this.AfterId = afterId;
            this.BeforeId = beforeId;
            this.ChatId = chatId;
            this.Limit = limit;
            this.Order = order;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMessageApiRequest" /> class.
        /// </summary>
        public ListMessageApiRequest()
        {
        }
    }
}