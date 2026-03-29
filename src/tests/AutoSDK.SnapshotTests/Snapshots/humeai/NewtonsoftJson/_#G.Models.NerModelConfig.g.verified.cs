//HintName: G.Models.NerModelConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NerModelConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identify_speakers")]
        public bool? IdentifySpeakers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NerModelConfig" /> class.
        /// </summary>
        /// <param name="identifySpeakers"></param>
        public NerModelConfig(
            bool? identifySpeakers)
        {
            this.IdentifySpeakers = identifySpeakers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NerModelConfig" /> class.
        /// </summary>
        public NerModelConfig()
        {
        }
    }
}