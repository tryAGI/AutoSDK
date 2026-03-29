//HintName: G.Models.DubbingAssetRequestConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Public API configuration for dubbing assets.
    /// </summary>
    public sealed partial class DubbingAssetRequestConfiguration
    {
        /// <summary>
        /// Default Value: dubbing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.DubbingAssetRequestConfigurationName? Name { get; set; }

        /// <summary>
        /// Whether to detect the language of the asset.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detectLanguage")]
        public bool? DetectLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingAssetRequestConfiguration" /> class.
        /// </summary>
        /// <param name="name">
        /// Default Value: dubbing
        /// </param>
        /// <param name="detectLanguage">
        /// Whether to detect the language of the asset.<br/>
        /// Default Value: true
        /// </param>
        public DubbingAssetRequestConfiguration(
            global::G.DubbingAssetRequestConfigurationName? name,
            bool? detectLanguage)
        {
            this.Name = name;
            this.DetectLanguage = detectLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingAssetRequestConfiguration" /> class.
        /// </summary>
        public DubbingAssetRequestConfiguration()
        {
        }
    }
}