//HintName: G.Models.ToolPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permissions that will be granted to the agent's dedicated service account when this tool is added to an agent.
    /// </summary>
    public sealed partial class ToolPermissions
    {
        /// <summary>
        /// When true, the tool grants query permissions on corpora specified in its configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpora_query")]
        public bool? CorporaQuery { get; set; }

        /// <summary>
        /// When true, the tool grants index permissions on corpora specified in its configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpora_index")]
        public bool? CorporaIndex { get; set; }

        /// <summary>
        /// When true, the tool grants corpus developer permissions, allowing the agent to list available corpora.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_developer")]
        public bool? CorpusDeveloper { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPermissions" /> class.
        /// </summary>
        /// <param name="corporaQuery">
        /// When true, the tool grants query permissions on corpora specified in its configuration.
        /// </param>
        /// <param name="corporaIndex">
        /// When true, the tool grants index permissions on corpora specified in its configuration.
        /// </param>
        /// <param name="corpusDeveloper">
        /// When true, the tool grants corpus developer permissions, allowing the agent to list available corpora.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolPermissions(
            bool? corporaQuery,
            bool? corporaIndex,
            bool? corpusDeveloper)
        {
            this.CorporaQuery = corporaQuery;
            this.CorporaIndex = corporaIndex;
            this.CorpusDeveloper = corpusDeveloper;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPermissions" /> class.
        /// </summary>
        public ToolPermissions()
        {
        }
    }
}