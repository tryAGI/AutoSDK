//HintName: G.Models.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceJsonConverter))]
        public global::G.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator" /> class.
        /// </summary>
        /// <param name="source"></param>
        public MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator(
            global::G.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource? source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator" /> class.
        /// </summary>
        public MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminator()
        {
        }
    }
}