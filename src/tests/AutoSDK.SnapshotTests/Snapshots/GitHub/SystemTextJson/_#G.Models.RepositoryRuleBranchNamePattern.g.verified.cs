//HintName: G.Models.RepositoryRuleBranchNamePattern.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters to be used for the branch_name_pattern rule
    /// </summary>
    public sealed partial class RepositoryRuleBranchNamePattern
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleBranchNamePatternTypeJsonConverter))]
        public global::G.RepositoryRuleBranchNamePatternType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.RepositoryRuleBranchNamePatternParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleBranchNamePattern" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRuleBranchNamePattern(
            global::G.RepositoryRuleBranchNamePatternType type,
            global::G.RepositoryRuleBranchNamePatternParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleBranchNamePattern" /> class.
        /// </summary>
        public RepositoryRuleBranchNamePattern()
        {
        }
    }
}