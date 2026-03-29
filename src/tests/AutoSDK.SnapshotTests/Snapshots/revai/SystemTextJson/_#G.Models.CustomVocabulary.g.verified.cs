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
        [global::System.Text.Json.Serialization.JsonPropertyName("phrases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Phrases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomVocabulary" /> class.
        /// </summary>
        /// <param name="phrases">
        /// Array of custom phrases to add to the lexicon
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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