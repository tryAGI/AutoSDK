//HintName: G.Models.TranslationTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that uses Palmyra Translate to translate text. Note that this tool does not stream results. The response is returned after the translation is complete.
    /// </summary>
    public sealed partial class TranslationTool
    {
        /// <summary>
        /// The type of tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranslationToolTypeJsonConverter))]
        public global::G.TranslationToolType Type { get; set; }

        /// <summary>
        /// A tool that uses Palmyra Translate to translate text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TranslationFunction Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationTool" /> class.
        /// </summary>
        /// <param name="function">
        /// A tool that uses Palmyra Translate to translate text.
        /// </param>
        /// <param name="type">
        /// The type of tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranslationTool(
            global::G.TranslationFunction function,
            global::G.TranslationToolType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationTool" /> class.
        /// </summary>
        public TranslationTool()
        {
        }
    }
}