//HintName: G.Models.ContainsAllTokensFilterParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional (optional) parameters for the ContainsAllTokens filter.
    /// </summary>
    public sealed partial class ContainsAllTokensFilterParams
    {
        /// <summary>
        /// Whether to treat the last token in the query input as a literal prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_as_prefix")]
        public bool? LastAsPrefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsAllTokensFilterParams" /> class.
        /// </summary>
        /// <param name="lastAsPrefix">
        /// Whether to treat the last token in the query input as a literal prefix.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainsAllTokensFilterParams(
            bool? lastAsPrefix)
        {
            this.LastAsPrefix = lastAsPrefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsAllTokensFilterParams" /> class.
        /// </summary>
        public ContainsAllTokensFilterParams()
        {
        }
    }
}