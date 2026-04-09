//HintName: G.Models.MCPToolConfigOutputInputOverridesDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPToolConfigOutputInputOverridesDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MCPToolConfigOutputInputOverridesDiscriminatorSourceJsonConverter))]
        public global::G.MCPToolConfigOutputInputOverridesDiscriminatorSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOutputInputOverridesDiscriminator" /> class.
        /// </summary>
        /// <param name="source"></param>
        public MCPToolConfigOutputInputOverridesDiscriminator(
            global::G.MCPToolConfigOutputInputOverridesDiscriminatorSource? source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOutputInputOverridesDiscriminator" /> class.
        /// </summary>
        public MCPToolConfigOutputInputOverridesDiscriminator()
        {
        }
    }
}