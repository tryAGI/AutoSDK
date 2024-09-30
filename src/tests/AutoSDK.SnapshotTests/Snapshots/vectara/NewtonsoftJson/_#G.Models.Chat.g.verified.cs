//HintName: G.Models.Chat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Chat
    {
        /// <summary>
        /// ID of the chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The first query of the chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_query")]
        public string? FirstQuery { get; set; }

        /// <summary>
        /// The first answer of the chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_answer")]
        public string? FirstAnswer { get; set; }

        /// <summary>
        /// Indicates whether this chat is enabled and can have further turns.<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies when this chat was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}