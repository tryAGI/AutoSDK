//HintName: G.Models.CustomSpellingConfigDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomSpellingConfigDTO
    {
        /// <summary>
        /// The list of spelling applied on the audio transcription<br/>
        /// Example: {"Gettleman":["gettleman"],"SQL":["Sequel"]}
        /// </summary>
        /// <example>{"Gettleman":["gettleman"],"SQL":["Sequel"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spelling_dictionary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> SpellingDictionary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSpellingConfigDTO" /> class.
        /// </summary>
        /// <param name="spellingDictionary">
        /// The list of spelling applied on the audio transcription<br/>
        /// Example: {"Gettleman":["gettleman"],"SQL":["Sequel"]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomSpellingConfigDTO(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> spellingDictionary)
        {
            this.SpellingDictionary = spellingDictionary ?? throw new global::System.ArgumentNullException(nameof(spellingDictionary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSpellingConfigDTO" /> class.
        /// </summary>
        public CustomSpellingConfigDTO()
        {
        }
    }
}