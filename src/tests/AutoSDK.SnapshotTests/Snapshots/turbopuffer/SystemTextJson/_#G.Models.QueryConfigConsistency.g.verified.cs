//HintName: G.Models.QueryConfigConsistency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The consistency level for a query.
    /// </summary>
    public sealed partial class QueryConfigConsistency
    {
        /// <summary>
        /// The query's consistency level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        public string? Level { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryConfigConsistency" /> class.
        /// </summary>
        /// <param name="level">
        /// The query's consistency level.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryConfigConsistency(
            string? level)
        {
            this.Level = level;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryConfigConsistency" /> class.
        /// </summary>
        public QueryConfigConsistency()
        {
        }
    }
}