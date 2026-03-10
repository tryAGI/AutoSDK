//HintName: G.Models.MCPToolConfigOverrideInputOverridesDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPToolConfigOverrideInputOverridesDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.MCPToolConfigOverrideInputOverridesDiscriminatorSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOverrideInputOverridesDiscriminator" /> class.
        /// </summary>
        /// <param name="source"></param>
        public MCPToolConfigOverrideInputOverridesDiscriminator(
            global::G.MCPToolConfigOverrideInputOverridesDiscriminatorSource? source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOverrideInputOverridesDiscriminator" /> class.
        /// </summary>
        public MCPToolConfigOverrideInputOverridesDiscriminator()
        {
        }
    }
}