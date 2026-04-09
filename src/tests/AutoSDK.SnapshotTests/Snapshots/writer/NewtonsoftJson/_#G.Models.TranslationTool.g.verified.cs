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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TranslationToolTypeJsonConverter))]
        public global::G.TranslationToolType Type { get; set; }

        /// <summary>
        /// A tool that uses Palmyra Translate to translate text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TranslationFunction Function { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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