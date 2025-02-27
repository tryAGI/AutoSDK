//HintName: G.Models.BetaThinkingConfigParamDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaThinkingConfigParamDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaThinkingConfigParamDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingConfigParamDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public BetaThinkingConfigParamDiscriminator(
            global::G.BetaThinkingConfigParamDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThinkingConfigParamDiscriminator" /> class.
        /// </summary>
        public BetaThinkingConfigParamDiscriminator()
        {
        }
    }
}