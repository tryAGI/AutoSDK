//HintName: G.Models.PIIConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PIIConfig
    {
        /// <summary>
        /// The processing mode for PII scrubbing. Currently only post-call is supported.<br/>
        /// Default Value: post_call
        /// </summary>
        /// <default>global::G.PIIConfigMode.PostCall</default>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PIIConfigModeJsonConverter))]
        public global::G.PIIConfigMode Mode { get; set; } = global::G.PIIConfigMode.PostCall;

        /// <summary>
        /// List of PII categories to scrub from transcripts and recordings.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("categories", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PIIConfigCategorie> Categories { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PIIConfig" /> class.
        /// </summary>
        /// <param name="categories">
        /// List of PII categories to scrub from transcripts and recordings.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="mode">
        /// The processing mode for PII scrubbing. Currently only post-call is supported.<br/>
        /// Default Value: post_call
        /// </param>
        public PIIConfig(
            global::System.Collections.Generic.IList<global::G.PIIConfigCategorie> categories,
            global::G.PIIConfigMode mode = global::G.PIIConfigMode.PostCall)
        {
            this.Mode = mode;
            this.Categories = categories ?? throw new global::System.ArgumentNullException(nameof(categories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PIIConfig" /> class.
        /// </summary>
        public PIIConfig()
        {
        }
    }
}