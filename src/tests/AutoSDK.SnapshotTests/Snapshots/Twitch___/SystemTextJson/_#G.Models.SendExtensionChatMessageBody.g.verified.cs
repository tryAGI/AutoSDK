//HintName: G.Models.SendExtensionChatMessageBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendExtensionChatMessageBody
    {
        /// <summary>
        /// The message. The message may contain a maximum of 280 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The ID of the extension that’s sending the chat message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExtensionId { get; set; }

        /// <summary>
        /// The extension’s version number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExtensionVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendExtensionChatMessageBody" /> class.
        /// </summary>
        /// <param name="text">
        /// The message. The message may contain a maximum of 280 characters.
        /// </param>
        /// <param name="extensionId">
        /// The ID of the extension that’s sending the chat message.
        /// </param>
        /// <param name="extensionVersion">
        /// The extension’s version number.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SendExtensionChatMessageBody(
            string text,
            string extensionId,
            string extensionVersion)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.ExtensionId = extensionId ?? throw new global::System.ArgumentNullException(nameof(extensionId));
            this.ExtensionVersion = extensionVersion ?? throw new global::System.ArgumentNullException(nameof(extensionVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendExtensionChatMessageBody" /> class.
        /// </summary>
        public SendExtensionChatMessageBody()
        {
        }
    }
}