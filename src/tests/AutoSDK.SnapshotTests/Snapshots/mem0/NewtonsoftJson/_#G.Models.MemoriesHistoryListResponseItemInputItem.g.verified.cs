//HintName: G.Models.MemoriesHistoryListResponseItemInputItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoriesHistoryListResponseItemInputItem
    {
        /// <summary>
        /// The role of the speaker in the conversation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MemoriesHistoryListResponseItemInputItemRoleJsonConverter))]
        public global::G.MemoriesHistoryListResponseItemInputItemRole Role { get; set; } = default!;

        /// <summary>
        /// The content of the message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesHistoryListResponseItemInputItem" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the speaker in the conversation
        /// </param>
        /// <param name="content">
        /// The content of the message
        /// </param>
        public MemoriesHistoryListResponseItemInputItem(
            global::G.MemoriesHistoryListResponseItemInputItemRole role,
            string content)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoriesHistoryListResponseItemInputItem" /> class.
        /// </summary>
        public MemoriesHistoryListResponseItemInputItem()
        {
        }
    }
}