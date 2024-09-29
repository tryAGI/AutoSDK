//HintName: G.Models.SafetySetting.g.cs

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
        [global::Newtonsoft.Json.JsonProperty("category")]
        public global::G.SafetySettingCategory? Category { get; set; }

        /// <summary>
        /// Required. Controls the probability threshold at which harm is blocked.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold")]
        public global::G.SafetySettingThreshold? Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}