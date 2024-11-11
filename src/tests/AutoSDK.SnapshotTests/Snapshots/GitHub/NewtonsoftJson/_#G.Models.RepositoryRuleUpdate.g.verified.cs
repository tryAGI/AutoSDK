//HintName: G.Models.RepositoryRuleUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Only allow users with bypass permission to update matching refs.
    /// </summary>
    public sealed partial class RepositoryRuleUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RepositoryRuleUpdateType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.RepositoryRuleUpdateParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleUpdate" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        public RepositoryRuleUpdate(
            global::G.RepositoryRuleUpdateType type,
            global::G.RepositoryRuleUpdateParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleUpdate" /> class.
        /// </summary>
        public RepositoryRuleUpdate()
        {
        }
    }
}