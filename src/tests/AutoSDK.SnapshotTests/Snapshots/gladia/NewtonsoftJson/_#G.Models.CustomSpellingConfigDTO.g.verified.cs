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
        [global::Newtonsoft.Json.JsonProperty("spelling_dictionary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>> SpellingDictionary { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSpellingConfigDTO" /> class.
        /// </summary>
        /// <param name="spellingDictionary">
        /// The list of spelling applied on the audio transcription<br/>
        /// Example: {"Gettleman":["gettleman"],"SQL":["Sequel"]}
        /// </param>
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