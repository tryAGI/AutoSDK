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
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentSearchCorporaParameters Search { get; set; }

        /// <summary>
        /// Default Value: {"enabled":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation")]
        public global::G.GenerationParameters? Generation { get; set; }

        /// <summary>
        /// Whether to save the query to history.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_history")]
        public bool? SaveHistory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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