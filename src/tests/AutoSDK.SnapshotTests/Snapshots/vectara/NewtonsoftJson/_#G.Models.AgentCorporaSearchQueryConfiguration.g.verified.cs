//HintName: G.Models.AgentCorporaSearchQueryConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Agent-specific query configuration that supports eager references. Use this in agent tool configurations when turn-start resolution is needed.
    /// </summary>
    public sealed partial class AgentCorporaSearchQueryConfiguration
    {
        /// <summary>
        /// Agent-specific search parameters that support eager references.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentSearchCorporaParameters Search { get; set; } = default!;

        /// <summary>
        /// Default Value: {"enabled":false}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation")]
        public global::G.GenerationParameters? Generation { get; set; }

        /// <summary>
        /// Whether to save the query to history.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("save_history")]
        public bool? SaveHistory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCorporaSearchQueryConfiguration" /> class.
        /// </summary>
        /// <param name="search">
        /// Agent-specific search parameters that support eager references.
        /// </param>
        /// <param name="generation">
        /// Default Value: {"enabled":false}
        /// </param>
        /// <param name="saveHistory">
        /// Whether to save the query to history.<br/>
        /// Default Value: false
        /// </param>
        public AgentCorporaSearchQueryConfiguration(
            global::G.AgentSearchCorporaParameters search,
            global::G.GenerationParameters? generation,
            bool? saveHistory)
        {
            this.Search = search ?? throw new global::System.ArgumentNullException(nameof(search));
            this.Generation = generation;
            this.SaveHistory = saveHistory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCorporaSearchQueryConfiguration" /> class.
        /// </summary>
        public AgentCorporaSearchQueryConfiguration()
        {
        }
    }
}