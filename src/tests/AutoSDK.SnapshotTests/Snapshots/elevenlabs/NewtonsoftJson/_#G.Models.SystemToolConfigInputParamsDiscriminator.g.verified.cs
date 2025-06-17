//HintName: G.Models.SystemToolConfigInputParamsDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SystemToolConfigInputParamsDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("system_tool_type")]
        public global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType? SystemToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfigInputParamsDiscriminator" /> class.
        /// </summary>
        /// <param name="systemToolType"></param>
        public SystemToolConfigInputParamsDiscriminator(
            global::G.SystemToolConfigInputParamsDiscriminatorSystemToolType? systemToolType)
        {
            this.SystemToolType = systemToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfigInputParamsDiscriminator" /> class.
        /// </summary>
        public SystemToolConfigInputParamsDiscriminator()
        {
        }
    }
}