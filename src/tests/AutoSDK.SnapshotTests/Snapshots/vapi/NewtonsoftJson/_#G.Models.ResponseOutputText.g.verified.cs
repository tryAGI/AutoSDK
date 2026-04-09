//HintName: G.Models.ResponseOutputText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseOutputText
    {
        /// <summary>
        /// Annotations in the text output<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Annotations { get; set; } = default!;

        /// <summary>
        /// The text output from the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The type of the output text<br/>
        /// Default Value: output_text
        /// </summary>
        /// <default>global::G.ResponseOutputTextType.OutputText</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputTextTypeJsonConverter))]
        public global::G.ResponseOutputTextType Type { get; set; } = global::G.ResponseOutputTextType.OutputText;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputText" /> class.
        /// </summary>
        /// <param name="annotations">
        /// Annotations in the text output<br/>
        /// Default Value: []
        /// </param>
        /// <param name="text">
        /// The text output from the model
        /// </param>
        /// <param name="type">
        /// The type of the output text<br/>
        /// Default Value: output_text
        /// </param>
        public ResponseOutputText(
            global::System.Collections.Generic.IList<object> annotations,
            string text,
            global::G.ResponseOutputTextType type = global::G.ResponseOutputTextType.OutputText)
        {
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputText" /> class.
        /// </summary>
        public ResponseOutputText()
        {
        }
    }
}