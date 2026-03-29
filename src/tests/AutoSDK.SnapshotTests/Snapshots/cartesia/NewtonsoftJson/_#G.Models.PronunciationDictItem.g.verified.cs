//HintName: G.Models.PronunciationDictItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A pronunciation dictionary item mapping text to a custom pronunciation
    /// </summary>
    public sealed partial class PronunciationDictItem
    {
        /// <summary>
        /// The original text to be replaced
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// A phonetic representation or text to be said in place of the original text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias", Required = global::Newtonsoft.Json.Required.Always)]
        public string Alias { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictItem" /> class.
        /// </summary>
        /// <param name="text">
        /// The original text to be replaced
        /// </param>
        /// <param name="alias">
        /// A phonetic representation or text to be said in place of the original text
        /// </param>
        public PronunciationDictItem(
            string text,
            string alias)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PronunciationDictItem" /> class.
        /// </summary>
        public PronunciationDictItem()
        {
        }
    }
}