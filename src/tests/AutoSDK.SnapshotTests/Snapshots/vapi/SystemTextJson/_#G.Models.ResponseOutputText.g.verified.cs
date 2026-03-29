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
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Annotations { get; set; }

        /// <summary>
        /// The text output from the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type of the output text<br/>
        /// Default Value: output_text
        /// </summary>
        /// <default>global::G.ResponseOutputTextType.OutputText</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputTextTypeJsonConverter))]
        public global::G.ResponseOutputTextType Type { get; set; } = global::G.ResponseOutputTextType.OutputText;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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