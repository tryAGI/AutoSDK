//HintName: G.Models.RealtimeConversationItemWithReferenceContentItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConversationItemWithReferenceContentItem
    {
        /// <summary>
        /// Base64-encoded audio bytes, used for `input_audio` content type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// ID of a previous conversation item to reference (for `item_reference`<br/>
        /// content types in `response.create` events). These can reference both<br/>
        /// client and server created items.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The text content, used for `input_text` and `text` content types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The transcript of the audio, used for `input_audio` content type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// The content type (`input_text`, `input_audio`, `item_reference`, `text`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeConversationItemWithReferenceContentItemType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemWithReferenceContentItem" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded audio bytes, used for `input_audio` content type.
        /// </param>
        /// <param name="id">
        /// ID of a previous conversation item to reference (for `item_reference`<br/>
        /// content types in `response.create` events). These can reference both<br/>
        /// client and server created items.
        /// </param>
        /// <param name="text">
        /// The text content, used for `input_text` and `text` content types.
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio, used for `input_audio` content type.
        /// </param>
        /// <param name="type">
        /// The content type (`input_text`, `input_audio`, `item_reference`, `text`).
        /// </param>
        public RealtimeConversationItemWithReferenceContentItem(
            string? audio,
            string? id,
            string? text,
            string? transcript,
            global::G.RealtimeConversationItemWithReferenceContentItemType? type)
        {
            this.Audio = audio;
            this.Id = id;
            this.Text = text;
            this.Transcript = transcript;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemWithReferenceContentItem" /> class.
        /// </summary>
        public RealtimeConversationItemWithReferenceContentItem()
        {
        }
    }
}