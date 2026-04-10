//HintName: G.Models.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceJsonConverter))]
        public global::G.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator" /> class.
        /// </summary>
        /// <param name="source"></param>
        public MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator(
            global::G.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource? source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator" /> class.
        /// </summary>
        public MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator()
        {
        }
    }
}