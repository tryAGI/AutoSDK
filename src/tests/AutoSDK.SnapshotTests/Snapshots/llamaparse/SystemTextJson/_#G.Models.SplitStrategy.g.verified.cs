//HintName: G.Models.SplitStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for how to split the document.
    /// </summary>
    public sealed partial class SplitStrategy
    {
        /// <summary>
        /// Controls handling of pages that don't match any category. 'include': pages can be grouped as 'uncategorized' and included in results. 'forbid': all pages must be assigned to a defined category. 'omit': pages can be classified as 'uncategorized' but are excluded from results.<br/>
        /// Default Value: include
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_uncategorized")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SplitStrategyAllowUncategorizedJsonConverter))]
        public global::G.SplitStrategyAllowUncategorized? AllowUncategorized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitStrategy" /> class.
        /// </summary>
        /// <param name="allowUncategorized">
        /// Controls handling of pages that don't match any category. 'include': pages can be grouped as 'uncategorized' and included in results. 'forbid': all pages must be assigned to a defined category. 'omit': pages can be classified as 'uncategorized' but are excluded from results.<br/>
        /// Default Value: include
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SplitStrategy(
            global::G.SplitStrategyAllowUncategorized? allowUncategorized)
        {
            this.AllowUncategorized = allowUncategorized;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitStrategy" /> class.
        /// </summary>
        public SplitStrategy()
        {
        }
    }
}