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
        [global::Newtonsoft.Json.JsonProperty("style_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string StyleId { get; set; } = default!;

        /// <summary>
        /// Name associated with the style rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The creation time of the style rule in the ISO 8601-1:2019 format (e.g.: `2021-08-03T14:16:18.329Z`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creation_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreationTime { get; set; } = default!;

        /// <summary>
        /// The time of the style rule when it was last updated in the ISO 8601-1:2019 format (e.g.: `2022-08-03T14:16:18.329Z`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedTime { get; set; } = default!;

        /// <summary>
        /// The language that the style rules are applied to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StyleRuleLanguage Language { get; set; } = default!;

        /// <summary>
        /// The version of the style rule. Incremented when the style rule is updated.<br/>
        /// Example: 13
        /// </summary>
        /// <example>13</example>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// The enabled rules for the style rule list including what option was selected for each rule. This schema combines rules from all supported languages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configured_rules")]
        public global::G.ConfiguredRules? ConfiguredRules { get; set; }

        /// <summary>
        /// List of custom instructions enabled for the style rule list.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_instructions")]
        public global::System.Collections.Generic.IList<global::G.CustomInstruction>? CustomInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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