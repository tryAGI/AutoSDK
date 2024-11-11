//HintName: G.Models.UpdateConversationBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConversationBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newConversationId")]
        public string? NewConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUsedCatalogUid")]
        public string? LastUsedCatalogUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lastUsedTopK")]
        public long? LastUsedTopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationBody" /> class.
        /// </summary>
        /// <param name="newConversationId"></param>
        /// <param name="lastUsedCatalogUid"></param>
        /// <param name="lastUsedTopK"></param>
        public UpdateConversationBody(
            string? newConversationId,
            string? lastUsedCatalogUid,
            long? lastUsedTopK)
        {
            this.NewConversationId = newConversationId;
            this.LastUsedCatalogUid = lastUsedCatalogUid;
            this.LastUsedTopK = lastUsedTopK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationBody" /> class.
        /// </summary>
        public UpdateConversationBody()
        {
        }
    }
}