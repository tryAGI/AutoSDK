//HintName: G.Models.Section.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Section
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Section" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="id"></param>
        public Section(
            string? conversationId,
            string? id)
        {
            this.ConversationId = conversationId;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Section" /> class.
        /// </summary>
        public Section()
        {
        }
    }
}