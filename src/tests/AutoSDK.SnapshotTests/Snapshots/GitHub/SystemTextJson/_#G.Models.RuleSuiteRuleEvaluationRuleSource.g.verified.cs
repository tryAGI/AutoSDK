//HintName: G.Models.RuleSuiteRuleEvaluationRuleSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RuleSuiteRuleEvaluationRuleSource
    {
        /// <summary>
        /// The type of rule source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The ID of the rule source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the rule source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuiteRuleEvaluationRuleSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of rule source.
        /// </param>
        /// <param name="id">
        /// The ID of the rule source.
        /// </param>
        /// <param name="name">
        /// The name of the rule source.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RuleSuiteRuleEvaluationRuleSource(
            string? type,
            int? id,
            string? name)
        {
            this.Type = type;
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleSuiteRuleEvaluationRuleSource" /> class.
        /// </summary>
        public RuleSuiteRuleEvaluationRuleSource()
        {
        }
    }
}