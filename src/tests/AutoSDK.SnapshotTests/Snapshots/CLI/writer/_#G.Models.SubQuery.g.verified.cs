//HintName: G.Models.SubQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A sub-question generated to break down complex queries into more manageable parts, along with its answer and supporting sources.
    /// </summary>
    public sealed partial class SubQuery
    {
        /// <summary>
        /// The subquery that was generated to help answer the main question.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The answer to the subquery based on Knowledge Graph content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Answer { get; set; }

        /// <summary>
        /// Array of source snippets that were used to answer this subquery.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Source> Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubQuery" /> class.
        /// </summary>
        /// <param name="query">
        /// The subquery that was generated to help answer the main question.
        /// </param>
        /// <param name="answer">
        /// The answer to the subquery based on Knowledge Graph content.
        /// </param>
        /// <param name="sources">
        /// Array of source snippets that were used to answer this subquery.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubQuery(
            string query,
            string answer,
            global::System.Collections.Generic.IList<global::G.Source> sources)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Answer = answer ?? throw new global::System.ArgumentNullException(nameof(answer));
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubQuery" /> class.
        /// </summary>
        public SubQuery()
        {
        }
    }
}