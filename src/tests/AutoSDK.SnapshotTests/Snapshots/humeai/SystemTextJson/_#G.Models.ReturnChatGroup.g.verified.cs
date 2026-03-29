//HintName: G.Models.ReturnChatGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnChatGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_start_timestamp")]
        public long? FirstStartTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_recent_start_timestamp")]
        public long? MostRecentStartTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("most_recent_chat_id")]
        public string? MostRecentChatId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_chats")]
        public int? NumChats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChatGroup" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstStartTimestamp"></param>
        /// <param name="mostRecentStartTimestamp"></param>
        /// <param name="mostRecentChatId"></param>
        /// <param name="numChats"></param>
        /// <param name="active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReturnChatGroup(
            string? id,
            long? firstStartTimestamp,
            long? mostRecentStartTimestamp,
            string? mostRecentChatId,
            int? numChats,
            bool? active)
        {
            this.Id = id;
            this.FirstStartTimestamp = firstStartTimestamp;
            this.MostRecentStartTimestamp = mostRecentStartTimestamp;
            this.MostRecentChatId = mostRecentChatId;
            this.NumChats = numChats;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnChatGroup" /> class.
        /// </summary>
        public ReturnChatGroup()
        {
        }
    }
}