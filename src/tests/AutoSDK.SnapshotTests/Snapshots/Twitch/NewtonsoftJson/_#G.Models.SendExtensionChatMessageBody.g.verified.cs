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
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The ID of the extension that’s sending the chat message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extension_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExtensionId { get; set; } = default!;

        /// <summary>
        /// The extension’s version number.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extension_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExtensionVersion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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