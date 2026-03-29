//HintName: G.Models.TextInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model for text input validation.<br/>
    /// Attributes:<br/>
    ///     type: Input type identifier, always "text"<br/>
    ///     text: The actual text content, with length and whitespace constraints
    /// </summary>
    public sealed partial class TextInput
    {
        /// <summary>
        /// Input type identifier<br/>
        /// Default Value: text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Text content to process
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextInput" /> class.
        /// </summary>
        /// <param name="text">
        /// Text content to process
        /// </param>
        /// <param name="type">
        /// Input type identifier<br/>
        /// Default Value: text
        /// </param>
        public TextInput(
            string text,
            string? type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextInput" /> class.
        /// </summary>
        public TextInput()
        {
        }
    }
}