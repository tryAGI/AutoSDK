﻿//HintName: G.Models.RealtimeConversationItemWithReferenceContentItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RealtimeConversationItemWithReferenceContentItem
    {
        /// <summary>
        /// The content type (`input_text`, `input_audio`, `item_reference`, `text`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeConversationItemWithReferenceContentItemTypeJsonConverter))]
        public global::G.RealtimeConversationItemWithReferenceContentItemType? Type { get; set; }

        /// <summary>
        /// The text content, used for `input_text` and `text` content types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// ID of a previous conversation item to reference (for `item_reference`<br/>
        /// content types in `response.create` events). These can reference both<br/>
        /// client and server created items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Base64-encoded audio bytes, used for `input_audio` content type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// The transcript of the audio, used for `input_audio` content type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemWithReferenceContentItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The content type (`input_text`, `input_audio`, `item_reference`, `text`).
        /// </param>
        /// <param name="text">
        /// The text content, used for `input_text` and `text` content types.
        /// </param>
        /// <param name="id">
        /// ID of a previous conversation item to reference (for `item_reference`<br/>
        /// content types in `response.create` events). These can reference both<br/>
        /// client and server created items.
        /// </param>
        /// <param name="audio">
        /// Base64-encoded audio bytes, used for `input_audio` content type.
        /// </param>
        /// <param name="transcript">
        /// The transcript of the audio, used for `input_audio` content type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationItemWithReferenceContentItem(
            global::G.RealtimeConversationItemWithReferenceContentItemType? type,
            string? text,
            string? id,
            string? audio,
            string? transcript)
        {
            this.Type = type;
            this.Text = text;
            this.Id = id;
            this.Audio = audio;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationItemWithReferenceContentItem" /> class.
        /// </summary>
        public RealtimeConversationItemWithReferenceContentItem()
        {
        }
    }
}