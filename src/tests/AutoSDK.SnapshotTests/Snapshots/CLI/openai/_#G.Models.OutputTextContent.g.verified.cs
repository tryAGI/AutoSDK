//HintName: G.Models.OutputTextContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A text output from the model.
    /// </summary>
    public sealed partial class OutputTextContent
    {
        /// <summary>
        /// The type of the output text. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </summary>
        /// <default>global::G.OutputTextContentType.OutputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputTextContentTypeJsonConverter))]
        public global::G.OutputTextContentType Type { get; set; } = global::G.OutputTextContentType.OutputText;

        /// <summary>
        /// The text output from the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The annotations of the text output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Annotation> Annotations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::System.Collections.Generic.IList<global::G.LogProb>? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTextContent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the output text. Always `output_text`.<br/>
        /// Default Value: output_text
        /// </param>
        /// <param name="text">
        /// The text output from the model.
        /// </param>
        /// <param name="annotations">
        /// The annotations of the text output.
        /// </param>
        /// <param name="logprobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputTextContent(
            string text,
            global::System.Collections.Generic.IList<global::G.Annotation> annotations,
            global::System.Collections.Generic.IList<global::G.LogProb>? logprobs,
            global::G.OutputTextContentType type = global::G.OutputTextContentType.OutputText)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
            this.Type = type;
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputTextContent" /> class.
        /// </summary>
        public OutputTextContent()
        {
        }
    }
}