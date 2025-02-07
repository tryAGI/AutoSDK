//HintName: G.Models.RepositoryRuleVariant16.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Prevent commits that include changes in specified file paths from being pushed to the commit graph.
    /// </summary>
    public sealed partial class RepositoryRuleVariant16
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleVariant16TypeJsonConverter))]
        public global::G.RepositoryRuleVariant16Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.RepositoryRuleVariant16Parameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleVariant16" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleVariant16(
            global::G.RepositoryRuleVariant16Type type,
            global::G.RepositoryRuleVariant16Parameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleVariant16" /> class.
        /// </summary>
        public RepositoryRuleVariant16()
        {
        }
    }
}