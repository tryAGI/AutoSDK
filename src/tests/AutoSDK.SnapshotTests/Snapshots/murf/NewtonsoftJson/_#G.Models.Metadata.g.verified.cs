//HintName: G.Models.Metadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Metadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_count")]
        public global::G.CharacterCount? CharacterCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits_used")]
        public double? CreditsUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_language")]
        public string? TargetLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata" /> class.
        /// </summary>
        /// <param name="characterCount"></param>
        /// <param name="creditsUsed"></param>
        /// <param name="targetLanguage"></param>
        public Metadata(
            global::G.CharacterCount? characterCount,
            double? creditsUsed,
            string? targetLanguage)
        {
            this.CharacterCount = characterCount;
            this.CreditsUsed = creditsUsed;
            this.TargetLanguage = targetLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata" /> class.
        /// </summary>
        public Metadata()
        {
        }
    }
}