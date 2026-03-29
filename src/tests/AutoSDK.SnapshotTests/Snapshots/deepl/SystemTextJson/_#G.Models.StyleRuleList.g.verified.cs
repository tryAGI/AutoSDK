//HintName: G.Models.StyleRuleList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StyleRuleList
    {
        /// <summary>
        /// A unique ID assigned to a style rule.<br/>
        /// Example: bd0a38f3-1831-440b-a8dd-2c702e2325ab
        /// </summary>
        /// <example>bd0a38f3-1831-440b-a8dd-2c702e2325ab</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StyleId { get; set; }

        /// <summary>
        /// Name associated with the style rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The creation time of the style rule in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreationTime { get; set; }

        /// <summary>
        /// The time of the style rule when it was last updated in the ISO 8601-1:2019 format (e.g.: `2022-08-03T14:16:18.329Z`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedTime { get; set; }

        /// <summary>
        /// The language that the style rules are applied to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StyleRuleLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StyleRuleLanguage Language { get; set; }

        /// <summary>
        /// The version of the style rule. Incremented when the style rule is updated.<br/>
        /// Example: 13
        /// </summary>
        /// <example>13</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configured_rules")]
        public global::G.ConfiguredRules? ConfiguredRules { get; set; }

        /// <summary>
        /// List of custom instructions enabled for the style rule list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_instructions")]
        public global::System.Collections.Generic.IList<global::G.CustomInstruction>? CustomInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleRuleList" /> class.
        /// </summary>
        /// <param name="styleId">
        /// A unique ID assigned to a style rule.<br/>
        /// Example: bd0a38f3-1831-440b-a8dd-2c702e2325ab
        /// </param>
        /// <param name="name">
        /// Name associated with the style rule.
        /// </param>
        /// <param name="creationTime">
        /// The creation time of the style rule in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).
        /// </param>
        /// <param name="updatedTime">
        /// The time of the style rule when it was last updated in the ISO 8601-1:2019 format (e.g.: `2022-08-03T14:16:18.329Z`).
        /// </param>
        /// <param name="language">
        /// The language that the style rules are applied to.
        /// </param>
        /// <param name="version">
        /// The version of the style rule. Incremented when the style rule is updated.<br/>
        /// Example: 13
        /// </param>
        /// <param name="configuredRules">
        /// The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.
        /// </param>
        /// <param name="customInstructions">
        /// List of custom instructions enabled for the style rule list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StyleRuleList(
            string styleId,
            string name,
            global::System.DateTime creationTime,
            global::System.DateTime updatedTime,
            global::G.StyleRuleLanguage language,
            int version,
            global::G.ConfiguredRules? configuredRules,
            global::System.Collections.Generic.IList<global::G.CustomInstruction>? customInstructions)
        {
            this.StyleId = styleId ?? throw new global::System.ArgumentNullException(nameof(styleId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreationTime = creationTime;
            this.UpdatedTime = updatedTime;
            this.Language = language;
            this.Version = version;
            this.ConfiguredRules = configuredRules;
            this.CustomInstructions = customInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StyleRuleList" /> class.
        /// </summary>
        public StyleRuleList()
        {
        }
    }
}