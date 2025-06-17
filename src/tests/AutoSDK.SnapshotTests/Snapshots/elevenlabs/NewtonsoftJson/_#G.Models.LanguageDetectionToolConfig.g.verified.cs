//HintName: G.Models.LanguageDetectionToolConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageDetectionToolConfig
    {
        /// <summary>
        /// Default Value: language_detection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_tool_type")]
        public global::G.LanguageDetectionToolConfigSystemToolType? SystemToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDetectionToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: language_detection
        /// </param>
        public LanguageDetectionToolConfig(
            global::G.LanguageDetectionToolConfigSystemToolType? systemToolType)
        {
            this.SystemToolType = systemToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDetectionToolConfig" /> class.
        /// </summary>
        public LanguageDetectionToolConfig()
        {
        }
    }
}