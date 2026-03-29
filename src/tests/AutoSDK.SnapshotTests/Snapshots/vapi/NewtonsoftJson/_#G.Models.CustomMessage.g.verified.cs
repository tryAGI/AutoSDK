//HintName: G.Models.CustomMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomMessage
    {
        /// <summary>
        /// This is an alternative to the `content` property. It allows to specify variants of the same content, one per language.<br/>
        /// Usage:<br/>
        /// - If your assistants are multilingual, you can provide content for each language.<br/>
        /// - If you don't provide content for a language, the first item in the array will be automatically translated to the active language at that moment.<br/>
        /// This will override the `content` property.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents")]
        public global::System.Collections.Generic.IList<global::G.TextContent>? Contents { get; set; }

        /// <summary>
        /// This is a custom message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CustomMessageType Type { get; set; }

        /// <summary>
        /// This is the content that the assistant will say when this message is triggered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMessage" /> class.
        /// </summary>
        /// <param name="contents">
        /// This is an alternative to the `content` property. It allows to specify variants of the same content, one per language.<br/>
        /// Usage:<br/>
        /// - If your assistants are multilingual, you can provide content for each language.<br/>
        /// - If you don't provide content for a language, the first item in the array will be automatically translated to the active language at that moment.<br/>
        /// This will override the `content` property.
        /// </param>
        /// <param name="type">
        /// This is a custom message.
        /// </param>
        /// <param name="content">
        /// This is the content that the assistant will say when this message is triggered.
        /// </param>
        public CustomMessage(
            global::System.Collections.Generic.IList<global::G.TextContent>? contents,
            global::G.CustomMessageType type,
            string? content)
        {
            this.Contents = contents;
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomMessage" /> class.
        /// </summary>
        public CustomMessage()
        {
        }
    }
}