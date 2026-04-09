//HintName: G.Models.ResponseOutputTextContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A text output from the model.
    /// </summary>
    public sealed partial class ResponseOutputTextContent
    {
        /// <summary>
        /// The type of the output text. Always `output_text`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputTextContentTypeJsonConverter))]
        public global::G.ResponseOutputTextContentType Type { get; set; }

        /// <summary>
        /// The text output from the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The annotations of the text output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResponseAnnotation> Annotations { get; set; } = default!;

        /// <summary>
        /// Log probability information for the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprobs")]
        public global::System.Collections.Generic.IList<string>? Logprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputTextContent" /> class.
        /// </summary>
        /// <param name="text">
        /// The text output from the model.
        /// </param>
        /// <param name="annotations">
        /// The annotations of the text output.
        /// </param>
        /// <param name="type">
        /// The type of the output text. Always `output_text`.
        /// </param>
        /// <param name="logprobs">
        /// Log probability information for the output.
        /// </param>
        public ResponseOutputTextContent(
            string text,
            global::System.Collections.Generic.IList<global::G.ResponseAnnotation> annotations,
            global::G.ResponseOutputTextContentType type,
            global::System.Collections.Generic.IList<string>? logprobs)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
            this.Logprobs = logprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputTextContent" /> class.
        /// </summary>
        public ResponseOutputTextContent()
        {
        }
    }
}