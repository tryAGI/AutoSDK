//HintName: G.Models.PronunciationDictionaryPhonemeRuleRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PronunciationDictionaryPhonemeRuleRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PronunciationDictionaryPhonemeRuleRequestModelTypeJsonConverter))]
        public global::G.PronunciationDictionaryPhonemeRuleRequestModelType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("string_to_replace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StringToReplace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneme")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Phoneme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alphabet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alphabet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}