//HintName: G.Models.CustomVocabulary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomVocabulary
    {
        /// <summary>
        /// Array of custom phrases to add to the lexicon
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phrases", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Phrases { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomVocabulary" /> class.
        /// </summary>
        /// <param name="phrases">
        /// Array of custom phrases to add to the lexicon
        /// </param>
        public CustomVocabulary(
            global::System.Collections.Generic.IList<string> phrases)
        {
            this.Phrases = phrases ?? throw new global::System.ArgumentNullException(nameof(phrases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomVocabulary" /> class.
        /// </summary>
        public CustomVocabulary()
        {
        }
    }
}