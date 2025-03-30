//HintName: G.Models.LanguagePresetTranslation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguagePresetTranslation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceHash { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePresetTranslation" /> class.
        /// </summary>
        /// <param name="sourceHash"></param>
        /// <param name="text"></param>
        public LanguagePresetTranslation(
            string sourceHash,
            string text)
        {
            this.SourceHash = sourceHash ?? throw new global::System.ArgumentNullException(nameof(sourceHash));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguagePresetTranslation" /> class.
        /// </summary>
        public LanguagePresetTranslation()
        {
        }
    }
}