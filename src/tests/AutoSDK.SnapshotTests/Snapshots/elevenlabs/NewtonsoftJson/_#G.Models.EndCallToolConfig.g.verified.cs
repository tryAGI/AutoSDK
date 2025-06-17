//HintName: G.Models.EndCallToolConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndCallToolConfig
    {
        /// <summary>
        /// Default Value: end_call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_tool_type")]
        public global::G.EndCallToolConfigSystemToolType? SystemToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndCallToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: end_call
        /// </param>
        public EndCallToolConfig(
            global::G.EndCallToolConfigSystemToolType? systemToolType)
        {
            this.SystemToolType = systemToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndCallToolConfig" /> class.
        /// </summary>
        public EndCallToolConfig()
        {
        }
    }
}