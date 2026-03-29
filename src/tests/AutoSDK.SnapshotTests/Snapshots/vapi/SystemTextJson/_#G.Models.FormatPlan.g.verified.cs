//HintName: G.Models.FormatPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FormatPlan
    {
        /// <summary>
        /// This determines whether the chunk is formatted before being sent to the voice provider. This helps with enunciation. This includes phone numbers, emails and addresses. Default `true`.<br/>
        /// Usage:<br/>
        /// - To rely on the voice provider's formatting logic, set this to `false`.<br/>
        /// If `voice.chunkPlan.enabled` is `false`, this is automatically `false` since there's no chunk to format.<br/>
        /// @default true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This is the cutoff after which a number is converted to individual digits instead of being spoken as words.<br/>
        /// Example:<br/>
        /// - If cutoff 2025, "12345" is converted to "1 2 3 4 5" while "1200" is converted to "twelve hundred".<br/>
        /// Usage:<br/>
        /// - If your use case doesn't involve IDs like zip codes, set this to a high value.<br/>
        /// - If your use case involves IDs that are shorter than 5 digits, set this to a lower value.<br/>
        /// @default 2025<br/>
        /// Example: 2025
        /// </summary>
        /// <example>2025</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberToDigitsCutoff")]
        public double? NumberToDigitsCutoff { get; set; }

        /// <summary>
        /// These are the custom replacements you can make to the chunk before it is sent to the voice provider.<br/>
        /// Usage:<br/>
        /// - To replace a specific word or phrase with a different word or phrase, use the `ExactReplacement` type. Eg. `{ type: 'exact', key: 'hello', value: 'hi' }`<br/>
        /// - To replace a word or phrase that matches a pattern, use the `RegexReplacement` type. Eg. `{ type: 'regex', regex: '\\b[a-zA-Z]{5}\\b', value: 'hi' }`<br/>
        /// @default []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacements")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ExactReplacement, global::G.RegexReplacement>>? Replacements { get; set; }

        /// <summary>
        /// List of formatters to apply. If not provided, all default formatters will be applied.<br/>
        /// If provided, only the specified formatters will be applied.<br/>
        /// Note: Some essential formatters like angle bracket removal will always be applied.<br/>
        /// @default undefined
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formattersEnabled")]
        public global::System.Collections.Generic.IList<global::G.FormatPlanFormattersEnabledItem>? FormattersEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatPlan" /> class.
        /// </summary>
        /// <param name="enabled">
        /// This determines whether the chunk is formatted before being sent to the voice provider. This helps with enunciation. This includes phone numbers, emails and addresses. Default `true`.<br/>
        /// Usage:<br/>
        /// - To rely on the voice provider's formatting logic, set this to `false`.<br/>
        /// If `voice.chunkPlan.enabled` is `false`, this is automatically `false` since there's no chunk to format.<br/>
        /// @default true<br/>
        /// Example: true
        /// </param>
        /// <param name="numberToDigitsCutoff">
        /// This is the cutoff after which a number is converted to individual digits instead of being spoken as words.<br/>
        /// Example:<br/>
        /// - If cutoff 2025, "12345" is converted to "1 2 3 4 5" while "1200" is converted to "twelve hundred".<br/>
        /// Usage:<br/>
        /// - If your use case doesn't involve IDs like zip codes, set this to a high value.<br/>
        /// - If your use case involves IDs that are shorter than 5 digits, set this to a lower value.<br/>
        /// @default 2025<br/>
        /// Example: 2025
        /// </param>
        /// <param name="replacements">
        /// These are the custom replacements you can make to the chunk before it is sent to the voice provider.<br/>
        /// Usage:<br/>
        /// - To replace a specific word or phrase with a different word or phrase, use the `ExactReplacement` type. Eg. `{ type: 'exact', key: 'hello', value: 'hi' }`<br/>
        /// - To replace a word or phrase that matches a pattern, use the `RegexReplacement` type. Eg. `{ type: 'regex', regex: '\\b[a-zA-Z]{5}\\b', value: 'hi' }`<br/>
        /// @default []
        /// </param>
        /// <param name="formattersEnabled">
        /// List of formatters to apply. If not provided, all default formatters will be applied.<br/>
        /// If provided, only the specified formatters will be applied.<br/>
        /// Note: Some essential formatters like angle bracket removal will always be applied.<br/>
        /// @default undefined
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FormatPlan(
            bool? enabled,
            double? numberToDigitsCutoff,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ExactReplacement, global::G.RegexReplacement>>? replacements,
            global::System.Collections.Generic.IList<global::G.FormatPlanFormattersEnabledItem>? formattersEnabled)
        {
            this.Enabled = enabled;
            this.NumberToDigitsCutoff = numberToDigitsCutoff;
            this.Replacements = replacements;
            this.FormattersEnabled = formattersEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatPlan" /> class.
        /// </summary>
        public FormatPlan()
        {
        }
    }
}