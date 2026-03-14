//HintName: G.Models.CorporaSearchToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CorporaSearchToolVariant2
    {
        /// <summary>
        /// This should always be `corpora_search`.<br/>
        /// Default Value: corpora_search<br/>
        /// Example: corpora_search
        /// </summary>
        /// <default>"corpora_search"</default>
        /// <example>corpora_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "corpora_search";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorporaSearchToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `corpora_search`.<br/>
        /// Default Value: corpora_search<br/>
        /// Example: corpora_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CorporaSearchToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorporaSearchToolVariant2" /> class.
        /// </summary>
        public CorporaSearchToolVariant2()
        {
        }
    }
}