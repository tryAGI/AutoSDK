//HintName: G.Models.TextContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextContent
    {
        /// <summary>
        /// The type of the message.<br/>
        /// Default Value: text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The text content of the message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Stores a unique identifier for any reasoning associated with this text content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContent" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content of the message.
        /// </param>
        /// <param name="type">
        /// The type of the message.<br/>
        /// Default Value: text
        /// </param>
        /// <param name="signature">
        /// Stores a unique identifier for any reasoning associated with this text content.
        /// </param>
        public TextContent(
            string text,
            string? type,
            string? signature)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextContent" /> class.
        /// </summary>
        public TextContent()
        {
        }
    }
}