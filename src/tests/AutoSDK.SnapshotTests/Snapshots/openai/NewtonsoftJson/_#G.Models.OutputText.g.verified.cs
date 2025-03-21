//HintName: G.Models.OutputText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A text output from the model.
    /// </summary>
    public sealed partial class OutputText
    {
        /// <summary>
        /// The type of the output text. Always `output_text`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OutputTextType Type { get; set; }

        /// <summary>
        /// The text output from the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The annotations of the text output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Annotation> Annotations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputText" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the output text. Always `output_text`.
        /// </param>
        /// <param name="text">
        /// The text output from the model.
        /// </param>
        /// <param name="annotations">
        /// The annotations of the text output.
        /// </param>
        public OutputText(
            string text,
            global::System.Collections.Generic.IList<global::G.Annotation> annotations,
            global::G.OutputTextType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputText" /> class.
        /// </summary>
        public OutputText()
        {
        }
    }
}