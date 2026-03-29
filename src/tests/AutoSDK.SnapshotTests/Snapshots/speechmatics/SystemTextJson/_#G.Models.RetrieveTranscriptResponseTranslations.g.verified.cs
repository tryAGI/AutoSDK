//HintName: G.Models.RetrieveTranscriptResponseTranslations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Translations of the transcript into other languages. It is a map of ISO language codes to arrays of translated sentences. Configured using `translation_config`.<br/>
    /// Example: {"de":[{"start_time":0.5,"end_time":1.3,"content":"Guten Tag, wie geht es dir?","speaker":"UU"}],"fr":[{"start_time":0.5,"end_time":1.3,"content":"Bonjour, comment \u00E7a va?","speaker":"UU"}]}
    /// </summary>
    public sealed partial class RetrieveTranscriptResponseTranslations
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}