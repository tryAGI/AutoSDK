//HintName: G.Models.MurfApiTranslationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MurfApiTranslationRequest
    {
        /// <summary>
        /// The language code for the target translation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("targetLanguage", Required = global::Newtonsoft.Json.Required.Always)]
        public string TargetLanguage { get; set; } = default!;

        /// <summary>
        /// List of texts to translate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("texts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Texts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MurfApiTranslationRequest" /> class.
        /// </summary>
        /// <param name="targetLanguage">
        /// The language code for the target translation
        /// </param>
        /// <param name="texts">
        /// List of texts to translate
        /// </param>
        public MurfApiTranslationRequest(
            string targetLanguage,
            global::System.Collections.Generic.IList<string> texts)
        {
            this.TargetLanguage = targetLanguage ?? throw new global::System.ArgumentNullException(nameof(targetLanguage));
            this.Texts = texts ?? throw new global::System.ArgumentNullException(nameof(texts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MurfApiTranslationRequest" /> class.
        /// </summary>
        public MurfApiTranslationRequest()
        {
        }
    }
}