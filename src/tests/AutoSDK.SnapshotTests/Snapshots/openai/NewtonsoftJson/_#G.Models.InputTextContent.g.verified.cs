//HintName: G.Models.InputTextContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A text input to the model.
    /// </summary>
    public sealed partial class InputTextContent
    {
        /// <summary>
        /// The type of the input item. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </summary>
        /// <default>global::G.InputTextContentType.InputText</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputTextContentType Type { get; set; } = global::G.InputTextContentType.InputText;

        /// <summary>
        /// The text input to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTextContent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the input item. Always `input_text`.<br/>
        /// Default Value: input_text
        /// </param>
        /// <param name="text">
        /// The text input to the model.
        /// </param>
        public InputTextContent(
            string text,
            global::G.InputTextContentType type = global::G.InputTextContentType.InputText)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputTextContent" /> class.
        /// </summary>
        public InputTextContent()
        {
        }
    }
}