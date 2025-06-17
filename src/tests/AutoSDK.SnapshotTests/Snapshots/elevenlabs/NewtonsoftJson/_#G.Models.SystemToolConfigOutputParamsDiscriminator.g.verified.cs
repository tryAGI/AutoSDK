//HintName: G.Models.SystemToolConfigOutputParamsDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemToolConfigOutputParamsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_tool_type")]
        public global::G.SystemToolConfigOutputParamsDiscriminatorSystemToolType? SystemToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfigOutputParamsDiscriminator" /> class.
        /// </summary>
        /// <param name="systemToolType"></param>
        public SystemToolConfigOutputParamsDiscriminator(
            global::G.SystemToolConfigOutputParamsDiscriminatorSystemToolType? systemToolType)
        {
            this.SystemToolType = systemToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfigOutputParamsDiscriminator" /> class.
        /// </summary>
        public SystemToolConfigOutputParamsDiscriminator()
        {
        }
    }
}