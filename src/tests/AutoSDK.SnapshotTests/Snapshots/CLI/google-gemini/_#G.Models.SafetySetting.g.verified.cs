﻿//HintName: G.Models.SafetySetting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Safety setting, affecting the safety-blocking behavior. Passing a safety setting for a category changes the allowed proability that content is blocked.
    /// </summary>
    public sealed partial class SafetySetting
    {
        /// <summary>
        /// Required. The category for this setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SafetySettingCategoryJsonConverter))]
        public global::G.SafetySettingCategory? Category { get; set; }

        /// <summary>
        /// Required. Controls the probability threshold at which harm is blocked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SafetySettingThresholdJsonConverter))]
        public global::G.SafetySettingThreshold? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetySetting" /> class.
        /// </summary>
        /// <param name="category">
        /// Required. The category for this setting.
        /// </param>
        /// <param name="threshold">
        /// Required. Controls the probability threshold at which harm is blocked.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SafetySetting(
            global::G.SafetySettingCategory? category,
            global::G.SafetySettingThreshold? threshold)
        {
            this.Category = category;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetySetting" /> class.
        /// </summary>
        public SafetySetting()
        {
        }
    }
}