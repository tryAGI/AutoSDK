//HintName: G.Models.CreateStyleRuleListRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateStyleRuleListRequest
    {
        /// <summary>
        /// Name of the style rule list<br/>
        /// Example: Technical Documentation Rules
        /// </summary>
        /// <example>Technical Documentation Rules</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The language that the style rules are applied to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StyleRuleLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StyleRuleLanguage Language { get; set; }

        /// <summary>
        /// The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configured_rules")]
        public global::G.ConfiguredRules? ConfiguredRules { get; set; }

        /// <summary>
        /// List of custom instructions to enable for the style rule list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public global::System.Collections.Generic.IList<global::G.CustomInstructionRequest>? CustomInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleRuleListRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the style rule list<br/>
        /// Example: Technical Documentation Rules
        /// </param>
        /// <param name="language">
        /// The language that the style rules are applied to.
        /// </param>
        /// <param name="configuredRules">
        /// The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.
        /// </param>
        /// <param name="customInstructions">
        /// List of custom instructions to enable for the style rule list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateStyleRuleListRequest(
            string name,
            global::G.StyleRuleLanguage language,
            global::G.ConfiguredRules? configuredRules,
            global::System.Collections.Generic.IList<global::G.CustomInstructionRequest>? customInstructions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Language = language;
            this.ConfiguredRules = configuredRules;
            this.CustomInstructions = customInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateStyleRuleListRequest" /> class.
        /// </summary>
        public CreateStyleRuleListRequest()
        {
        }
    }
}