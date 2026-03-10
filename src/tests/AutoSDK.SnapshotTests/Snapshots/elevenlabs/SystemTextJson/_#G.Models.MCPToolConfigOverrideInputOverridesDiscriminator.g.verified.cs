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
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MCPToolConfigOverrideInputOverridesDiscriminatorSourceJsonConverter))]
        public global::G.MCPToolConfigOverrideInputOverridesDiscriminatorSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOverrideInputOverridesDiscriminator" /> class.
        /// </summary>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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