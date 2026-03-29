//HintName: G.Models.AgenticSearchConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for agentic multi-query search.
    /// </summary>
    public sealed partial class AgenticSearchConfig
    {
        /// <summary>
        /// Maximum number of search rounds<br/>
        /// Default Value: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_rounds")]
        public int? MaxRounds { get; set; }

        /// <summary>
        /// Maximum queries per round<br/>
        /// Default Value: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queries_per_round")]
        public int? QueriesPerRound { get; set; }

        /// <summary>
        /// Additional custom instructions (followed only when not in conflict with existing rules)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticSearchConfig" /> class.
        /// </summary>
        /// <param name="maxRounds">
        /// Maximum number of search rounds<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="queriesPerRound">
        /// Maximum queries per round<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="instructions">
        /// Additional custom instructions (followed only when not in conflict with existing rules)
        /// </param>
        public AgenticSearchConfig(
            int? maxRounds,
            int? queriesPerRound,
            string? instructions)
        {
            this.MaxRounds = maxRounds;
            this.QueriesPerRound = queriesPerRound;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticSearchConfig" /> class.
        /// </summary>
        public AgenticSearchConfig()
        {
        }
    }
}