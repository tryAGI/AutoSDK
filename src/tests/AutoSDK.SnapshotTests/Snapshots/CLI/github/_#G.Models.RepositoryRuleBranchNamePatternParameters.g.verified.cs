﻿//HintName: G.Models.RepositoryRuleBranchNamePatternParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleBranchNamePatternParameters
    {
        /// <summary>
        /// How this rule will appear to users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// If true, the rule will fail if the pattern matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negate")]
        public bool? Negate { get; set; }

        /// <summary>
        /// The operator to use for matching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleBranchNamePatternParametersOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryRuleBranchNamePatternParametersOperator Operator { get; set; }

        /// <summary>
        /// The pattern to match with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleBranchNamePatternParameters" /> class.
        /// </summary>
        /// <param name="name">
        /// How this rule will appear to users.
        /// </param>
        /// <param name="negate">
        /// If true, the rule will fail if the pattern matches.
        /// </param>
        /// <param name="operator">
        /// The operator to use for matching.
        /// </param>
        /// <param name="pattern">
        /// The pattern to match with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleBranchNamePatternParameters(
            global::G.RepositoryRuleBranchNamePatternParametersOperator @operator,
            string pattern,
            string? name,
            bool? negate)
        {
            this.Operator = @operator;
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Name = name;
            this.Negate = negate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleBranchNamePatternParameters" /> class.
        /// </summary>
        public RepositoryRuleBranchNamePatternParameters()
        {
        }
    }
}