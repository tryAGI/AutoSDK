//HintName: G.Models.PodcastConversationMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"conversation":{"guest_voice_id":"aw1NgEzBg83R7vgmiJt7","host_voice_id":"aw1NgEzBg83R7vgmiJt6"},"type":"conversation"}
    /// </summary>
    public sealed partial class PodcastConversationMode
    {
        /// <summary>
        /// The type of podcast to create.
        /// </summary>
        /// <default>"conversation"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "conversation";

        /// <summary>
        /// The voice settings for the conversation.<br/>
        /// Example: {"guest_voice_id":"aw1NgEzBg83R7vgmiJt7","host_voice_id":"aw1NgEzBg83R7vgmiJt6"}
        /// </summary>
        /// <example>{"guest_voice_id":"aw1NgEzBg83R7vgmiJt7","host_voice_id":"aw1NgEzBg83R7vgmiJt6"}</example>
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
        /// <param name="conversation">
        /// The voice settings for the conversation.<br/>
        /// Example: {"guest_voice_id":"aw1NgEzBg83R7vgmiJt7","host_voice_id":"aw1NgEzBg83R7vgmiJt6"}
        /// </param>
        public PodcastConversationMode(
            global::G.PodcastConversationModeData conversation,
            string type = "conversation")
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