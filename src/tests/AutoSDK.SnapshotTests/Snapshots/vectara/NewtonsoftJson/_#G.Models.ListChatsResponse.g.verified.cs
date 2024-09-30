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
        [global::Newtonsoft.Json.JsonProperty("chats")]
        public global::System.Collections.Generic.IList<global::G.Chat>? Chats { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}