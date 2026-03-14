//HintName: G.Models.HcmSourceDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of source documents used to verify the factual accuracy of the generated text. Each document should reflect the context used to generate the original text.
    /// </summary>
    public sealed partial class HcmSourceDocument
    {
        /// <summary>
        /// The full text content of the source document. Hallucination correction uses this content as the factual basis for correcting the generated text.
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
        /// Initializes a new instance of the <see cref="HcmSourceDocument" /> class.
        /// </summary>
        /// <param name="text">
        /// The full text content of the source document. Hallucination correction uses this content as the factual basis for correcting the generated text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HcmSourceDocument(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HcmSourceDocument" /> class.
        /// </summary>
        public HcmSourceDocument()
        {
        }
    }
}