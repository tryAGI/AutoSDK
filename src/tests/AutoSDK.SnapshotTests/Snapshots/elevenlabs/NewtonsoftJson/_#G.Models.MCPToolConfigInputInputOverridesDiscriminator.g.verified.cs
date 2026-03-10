//HintName: G.Models.MCPToolConfigInputInputOverridesDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPToolConfigInputInputOverridesDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.MCPToolConfigInputInputOverridesDiscriminatorSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigInputInputOverridesDiscriminator" /> class.
        /// </summary>
        /// <param name="source"></param>
        public MCPToolConfigInputInputOverridesDiscriminator(
            global::G.MCPToolConfigInputInputOverridesDiscriminatorSource? source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigInputInputOverridesDiscriminator" /> class.
        /// </summary>
        public MCPToolConfigInputInputOverridesDiscriminator()
        {
        }
    }
}