//HintName: G.Models.PodcastConversationMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PodcastConversationMode
    {
        /// <summary>
        /// The type of podcast to create.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PodcastConversationModeType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PodcastConversationModeData Conversation { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastConversationMode" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of podcast to create.
        /// </param>
        /// <param name="conversation"></param>
        public PodcastConversationMode(
            global::G.PodcastConversationModeData conversation,
            global::G.PodcastConversationModeType type)
        {
            this.Conversation = conversation ?? throw new global::System.ArgumentNullException(nameof(conversation));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodcastConversationMode" /> class.
        /// </summary>
        public PodcastConversationMode()
        {
        }
    }
}