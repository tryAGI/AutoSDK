//HintName: G.Models.CorporaSearchToolParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// LLM-exposed parameters for the corpora search tool that can be filled in during execution.
    /// </summary>
    public sealed partial class CorporaSearchToolParameters
    {
        /// <summary>
        /// The search query string, which is the question the user is asking. If not provided, will be filled in by the agent.<br/>
        /// Example: Am I allowed to bring pets to work?
        /// </summary>
        /// <example>Am I allowed to bring pets to work?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorporaSearchToolParameters" /> class.
        /// </summary>
        /// <param name="query">
        /// The search query string, which is the question the user is asking. If not provided, will be filled in by the agent.<br/>
        /// Example: Am I allowed to bring pets to work?
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CorporaSearchToolParameters(
            string? query)
        {
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorporaSearchToolParameters" /> class.
        /// </summary>
        public CorporaSearchToolParameters()
        {
        }
    }
}