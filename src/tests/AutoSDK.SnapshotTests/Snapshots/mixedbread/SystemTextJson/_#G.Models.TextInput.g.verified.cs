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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Text content to process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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