//HintName: G.Models.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorTypeJsonConverter))]
        public global::G.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminator(
            global::G.LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminator" /> class.
        /// </summary>
        public LettaSchemasAgentFileAgentSchemaToolRulesVariant1ItemDiscriminator()
        {
        }
    }
}