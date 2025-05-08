//HintName: G.Models.EvalItemContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A text output from the model.
    /// </summary>
    public sealed partial class EvalItemContent
    {
        /// <summary>
        /// The type of the output text. Always `output_text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalItemContentTypeJsonConverter))]
        public global::G.EvalItemContentType Type { get; set; }

        /// <summary>
        /// The text output from the model.
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
        /// Initializes a new instance of the <see cref="EvalItemContent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the output text. Always `output_text`.
        /// </param>
        /// <param name="text">
        /// The text output from the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalItemContent(
            string text,
            global::G.EvalItemContentType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalItemContent" /> class.
        /// </summary>
        public EvalItemContent()
        {
        }
    }
}